---
external help file: Microsoft.Graph.Identity.SignIns-help.xml
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/new-mgpolicyprivatelinkresourcepolicy
schema: 2.0.0
---

# New-MgPolicyPrivateLinkResourcePolicy

## SYNOPSIS
Create new navigation property to privateLinkResourcePolicies for policies

## SYNTAX

### CreateExpanded (Default)
```
New-MgPolicyPrivateLinkResourcePolicy [-AdditionalProperties <Hashtable>] [-ExternalPrivateLinkId <String>]
 [-Id <String>] [-TenantApprovals <IMicrosoftGraphTenantApprovals[]>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgPolicyPrivateLinkResourcePolicy -BodyParameter <IMicrosoftGraphPrivateLinkResourcePolicy> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to privateLinkResourcePolicies for policies

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

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
privateLinkResourcePolicy
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphPrivateLinkResourcePolicy
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ExternalPrivateLinkId
.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TenantApprovals
.
To construct, see NOTES section for TENANTAPPROVALS properties and create a hash table.

```yaml
Type: IMicrosoftGraphTenantApprovals[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivateLinkResourcePolicy
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivateLinkResourcePolicy
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphPrivateLinkResourcePolicy\>: privateLinkResourcePolicy
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[ExternalPrivateLinkId \<String\>\]: 
  \[TenantApprovals \<IMicrosoftGraphTenantApprovals\[\]\>\]: 
    \[State \<String\>\]: 
    \[TenantId \<String\>\]: 

TENANTAPPROVALS \<IMicrosoftGraphTenantApprovals\[\]\>: .
  \[State \<String\>\]: 
  \[TenantId \<String\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/new-mgpolicyprivatelinkresourcepolicy](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/new-mgpolicyprivatelinkresourcepolicy)
