---
external help file: Microsoft.Graph.Notes-help.xml
Module Name: Microsoft.Graph.Notes
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.notes/get-mgsiteonenoteoperation
schema: 2.0.0
---

# Get-MgSiteOnenoteOperation

## SYNOPSIS
Get operations from sites

## SYNTAX

### Get1 (Default)
```
Get-MgSiteOnenoteOperation -OnenoteOperationId <String> -SiteId <String> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity1
```
Get-MgSiteOnenoteOperation -InputObject <INotesIdentity> [-ExpandProperty <String[]>] [-Property <String[]>]
 [<CommonParameters>]
```

## DESCRIPTION
Get operations from sites

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

### -ExpandProperty
Expand related entities

```yaml
Type: String[]
Parameter Sets: (All)
Aliases: Expand

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
Parameter Sets: GetViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OnenoteOperationId
key: id of onenoteOperation

```yaml
Type: String
Parameter Sets: Get1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Property
Select properties to be returned

```yaml
Type: String[]
Parameter Sets: (All)
Aliases: Select

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SiteId
key: id of site

```yaml
Type: String
Parameter Sets: Get1
Aliases:

Required: True
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnenoteOperation
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

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.notes/get-mgsiteonenoteoperation](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.notes/get-mgsiteonenoteoperation)
