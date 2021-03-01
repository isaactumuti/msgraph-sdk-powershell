try {
	[Microsoft.Graph.PowerShell.Authentication.Utilities.DependencyAssemblyResolver]::Initialize()
} catch {
    Write-Warning $_
}