param(
    # The .NET build configuration
    [ValidateSet('Debug', 'Release')]
    [string]
    $Configuration = 'Debug'
)

# Convenient reusable constants
$mod = "Authentication"
$modPrefix = "Microsoft.Graph"
$netStandard = "netstandard2.0"
$copyExtensions = @('.dll', '.pdb')

# Source code locations
$coreSrc = "$mod.Core"
$cmdletsSrc = "$mod"

# Generated output locations
$outDir = "$PSScriptRoot/out/$mod"
$outDeps = "$outDir/Dependencies"
$outStartupScripts = "$outDir/StartupScripts"

# Clean src bin
Remove-Item -Path "$coreSrc/bin" -Recurse -ErrorAction Ignore
Remove-Item -Path "$cmdletsSrc/bin" -Recurse -ErrorAction Ignore

# Build Authentication.Core
Push-Location $coreSrc
dotnet publish -c $Configuration
Pop-Location

# Build Authentication
Push-Location $cmdletsSrc
dotnet publish -c $Configuration
Pop-Location

# Ensure out directory exists and is clean
Remove-Item -Path $outDir -Recurse -ErrorAction Ignore
New-Item -Path $outDir -ItemType Directory
New-Item -Path $outDeps -ItemType Directory

# Copy manifest
Copy-Item -Path "$cmdletsSrc/StartupScripts/" -Recurse -Destination $outStartupScripts

# Copy manifest
Copy-Item -Path "$cmdletsSrc/$modPrefix.$mod.psm1" -Destination $outDir
Copy-Item -Path "$cmdletsSrc/$modPrefix.$mod.psd1" -Destination $outDir

# Copy each core asset and remember it
$deps = [System.Collections.Generic.HashSet[string]]::new()
Get-ChildItem -Path "$coreSrc/bin/$Configuration/$netStandard/publish/" |
    Where-Object { $_.Extension -in $copyExtensions } |
    ForEach-Object { [void]$deps.Add($_.Name); Copy-Item -Path $_.FullName -Destination $outDeps }

# Now copy each Cmdlets asset, not taking any found in Engine
Get-ChildItem -Path "$cmdletsSrc/bin/$Configuration/$netStandard/publish/" |
    Where-Object { -not $deps.Contains($_.Name) -and $_.Extension -in $copyExtensions } |
    ForEach-Object { Copy-Item -Path $_.FullName -Destination $outDir }