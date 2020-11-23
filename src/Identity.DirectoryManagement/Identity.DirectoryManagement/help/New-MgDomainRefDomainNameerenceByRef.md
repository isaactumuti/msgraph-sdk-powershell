---
external help file: Microsoft.Graph.Identity.DirectoryManagement-help.xml
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgdomainrefdomainnameerencebyref
schema: 2.0.0
---

# New-MgDomainRefDomainNameerenceByRef

## SYNOPSIS
Create new navigation property ref to domainNameReferences for domains

## SYNTAX

### CreateExpanded (Default)
```
New-MgDomainRefDomainNameerenceByRef -DomainId <String> [-AdditionalProperties <Hashtable>] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgDomainRefDomainNameerenceByRef -DomainId <String> -BodyParameter <Hashtable> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgDomainRefDomainNameerenceByRef -InputObject <IIdentityDirectoryManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgDomainRefDomainNameerenceByRef -InputObject <IIdentityDirectoryManagementIdentity>
 -BodyParameter <Hashtable> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property ref to domainNameReferences for domains

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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.

```yaml
Type: Hashtable
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DomainId
key: id of domain

```yaml
Type: String
Parameter Sets: CreateExpanded, Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: IIdentityDirectoryManagementIdentity
Parameter Sets: CreateViaIdentityExpanded, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### Microsoft.Graph.PowerShell.Models.IIdentityDirectoryManagementIdentity
### System.Collections.Hashtable
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IPaths16TdfjnDomainsDomainIdDomainnamereferencesRefPostResponses201ContentApplicationJsonSchema
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT \<IIdentityDirectoryManagementIdentity\>: Identity Parameter
  \[AdministrativeUnitId \<String\>\]: key: id of administrativeUnit
  \[CommandId \<String\>\]: key: id of command
  \[ContractId \<String\>\]: key: id of contract
  \[DeviceId \<String\>\]: key: id of device
  \[DirectoryObjectId \<String\>\]: key: id of directoryObject
  \[DirectoryRoleId \<String\>\]: key: id of directoryRole
  \[DirectoryRoleTemplateId \<String\>\]: key: id of directoryRoleTemplate
  \[DirectorySettingId \<String\>\]: key: id of directorySetting
  \[DirectorySettingTemplateId \<String\>\]: key: id of directorySettingTemplate
  \[DomainDnsRecordId \<String\>\]: key: id of domainDnsRecord
  \[DomainId \<String\>\]: key: id of domain
  \[ExtensionId \<String\>\]: key: id of extension
  \[FeatureRolloutPolicyId \<String\>\]: key: id of featureRolloutPolicy
  \[OrgContactId \<String\>\]: key: id of orgContact
  \[OrganizationId \<String\>\]: key: id of organization
  \[ProfileCardPropertyId \<String\>\]: key: id of profileCardProperty
  \[ScopedRoleMembershipId \<String\>\]: key: id of scopedRoleMembership
  \[SharedEmailDomainId \<String\>\]: key: id of sharedEmailDomain
  \[SharedEmailDomainInvitationId \<String\>\]: key: id of sharedEmailDomainInvitation
  \[SubscribedSkuId \<String\>\]: key: id of subscribedSku
  \[UserId \<String\>\]: key: id of user

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgdomainrefdomainnameerencebyref](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgdomainrefdomainnameerencebyref)
