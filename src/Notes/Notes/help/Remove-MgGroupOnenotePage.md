---
external help file: Microsoft.Graph.Notes-help.xml
Module Name: Microsoft.Graph.Notes
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.notes/remove-mggrouponenotepage
schema: 2.0.0
---

# Remove-MgGroupOnenotePage

## SYNOPSIS
Delete navigation property pages for groups

## SYNTAX

### Delete1 (Default)
```
Remove-MgGroupOnenotePage -GroupId <String> -OnenotePageId <String> [-IfMatch <String>] [-PassThru] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### DeleteViaIdentity1
```
Remove-MgGroupOnenotePage -InputObject <INotesIdentity> [-IfMatch <String>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Delete navigation property pages for groups

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -GroupId
key: id of group

```yaml
Type: String
Parameter Sets: Delete1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IfMatch
ETag

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: INotesIdentity
Parameter Sets: DeleteViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OnenotePageId
key: id of onenotePage

```yaml
Type: String
Parameter Sets: Delete1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.INotesIdentity
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT \<INotesIdentity\>: Identity Parameter
  \[GroupId \<String\>\]: key: id of group
  \[NotebookId \<String\>\]: key: id of notebook
  \[OnenoteOperationId \<String\>\]: key: id of onenoteOperation
  \[OnenotePageId \<String\>\]: key: id of onenotePage
  \[OnenoteResourceId \<String\>\]: key: id of onenoteResource
  \[OnenoteSectionId \<String\>\]: key: id of onenoteSection
  \[SectionGroupId \<String\>\]: key: id of sectionGroup
  \[SiteId \<String\>\]: key: id of site
  \[UserId \<String\>\]: key: id of user

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.notes/remove-mggrouponenotepage](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.notes/remove-mggrouponenotepage)
