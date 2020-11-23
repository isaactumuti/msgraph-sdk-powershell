---
external help file: Microsoft.Graph.Identity.DirectoryManagement-help.xml
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgcontact
schema: 2.0.0
---

# New-MgContact

## SYNOPSIS
Add new entity to contacts

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgContact [-AdditionalProperties <Hashtable>] [-Addresses <IMicrosoftGraphPhysicalOfficeAddress[]>]
 [-CompanyName <String>] [-DeletedDateTime <DateTime>] [-Department <String>]
 [-DirectReports <IMicrosoftGraphDirectoryObject[]>] [-DisplayName <String>] [-GivenName <String>]
 [-Id <String>] [-JobTitle <String>] [-Mail <String>] [-MailNickname <String>]
 [-Manager <IMicrosoftGraphDirectoryObject>] [-MemberOf <IMicrosoftGraphDirectoryObject[]>]
 [-OnPremisesLastSyncDateTime <DateTime>]
 [-OnPremisesProvisioningErrors <IMicrosoftGraphOnPremisesProvisioningError[]>] [-OnPremisesSyncEnabled]
 [-Phones <IMicrosoftGraphPhone1[]>] [-ProxyAddresses <String[]>] [-Surname <String>]
 [-TransitiveMemberOf <IMicrosoftGraphDirectoryObject[]>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create1
```
New-MgContact -BodyParameter <IMicrosoftGraphOrgContact1> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Add new entity to contacts

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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Addresses
.
To construct, see NOTES section for ADDRESSES properties and create a hash table.

```yaml
Type: IMicrosoftGraphPhysicalOfficeAddress[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphOrgContact1
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CompanyName
.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeletedDateTime
.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Department
.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DirectReports
.
To construct, see NOTES section for DIRECTREPORTS properties and create a hash table.

```yaml
Type: IMicrosoftGraphDirectoryObject[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GivenName
.

```yaml
Type: String
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobTitle
.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Mail
.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MailNickname
.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Manager
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.
To construct, see NOTES section for MANAGER properties and create a hash table.

```yaml
Type: IMicrosoftGraphDirectoryObject
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MemberOf
.
To construct, see NOTES section for MEMBEROF properties and create a hash table.

```yaml
Type: IMicrosoftGraphDirectoryObject[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesLastSyncDateTime
.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesProvisioningErrors
.
To construct, see NOTES section for ONPREMISESPROVISIONINGERRORS properties and create a hash table.

```yaml
Type: IMicrosoftGraphOnPremisesProvisioningError[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesSyncEnabled
.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Phones
.
To construct, see NOTES section for PHONES properties and create a hash table.

```yaml
Type: IMicrosoftGraphPhone1[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProxyAddresses
.

```yaml
Type: String[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Surname
.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TransitiveMemberOf
.
To construct, see NOTES section for TRANSITIVEMEMBEROF properties and create a hash table.

```yaml
Type: IMicrosoftGraphDirectoryObject[]
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOrgContact1
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOrgContact1
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

ADDRESSES \<IMicrosoftGraphPhysicalOfficeAddress\[\]\>: .
  \[City \<String\>\]: The city.
  \[CountryOrRegion \<String\>\]: The country or region.
It's a free-format string value, for example, 'United States'.
  \[OfficeLocation \<String\>\]: Office location such as building and office number for an organizational contact.
  \[PostalCode \<String\>\]: The postal code.
  \[State \<String\>\]: The state.
  \[Street \<String\>\]: The street.

BODYPARAMETER \<IMicrosoftGraphOrgContact\>: Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[DeletedDateTime \<DateTime?\>\]: 
  \[Id \<String\>\]: Read-only.
  \[Addresses \<IMicrosoftGraphPhysicalOfficeAddress\[\]\>\]: 
    \[City \<String\>\]: The city.
    \[CountryOrRegion \<String\>\]: The country or region.
It's a free-format string value, for example, 'United States'.
    \[OfficeLocation \<String\>\]: Office location such as building and office number for an organizational contact.
    \[PostalCode \<String\>\]: The postal code.
    \[State \<String\>\]: The state.
    \[Street \<String\>\]: The street.
  \[CompanyName \<String\>\]: 
  \[Department \<String\>\]: 
  \[DirectReports \<IMicrosoftGraphDirectoryObject\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[DeletedDateTime \<DateTime?\>\]: 
  \[DisplayName \<String\>\]: 
  \[GivenName \<String\>\]: 
  \[JobTitle \<String\>\]: 
  \[Mail \<String\>\]: 
  \[MailNickname \<String\>\]: 
  \[Manager \<IMicrosoftGraphDirectoryObject\>\]: Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.
  \[MemberOf \<IMicrosoftGraphDirectoryObject\[\]\>\]: 
  \[OnPremisesLastSyncDateTime \<DateTime?\>\]: 
  \[OnPremisesProvisioningErrors \<IMicrosoftGraphOnPremisesProvisioningError\[\]\>\]: 
    \[Category \<String\>\]: Category of the provisioning error.
Note: Currently, there is only one possible value.
Possible value: PropertyConflict - indicates a property value is not unique.
Other objects contain the same value for the property.
    \[OccurredDateTime \<DateTime?\>\]: The date and time at which the error occurred.
    \[PropertyCausingError \<String\>\]: Name of the directory property causing the error.
Current possible values: UserPrincipalName or ProxyAddress
    \[Value \<String\>\]: Value of the property causing the error.
  \[OnPremisesSyncEnabled \<Boolean?\>\]: 
  \[Phones \<IMicrosoftGraphPhone\[\]\>\]: 
    \[Language \<String\>\]: 
    \[Number \<String\>\]: The phone number.
    \[Region \<String\>\]: 
    \[Type \<String\>\]: phoneType
  \[ProxyAddresses \<String\[\]\>\]: 
  \[Surname \<String\>\]: 
  \[TransitiveMemberOf \<IMicrosoftGraphDirectoryObject\[\]\>\]: 

DIRECTREPORTS \<IMicrosoftGraphDirectoryObject\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[DeletedDateTime \<DateTime?\>\]: 

MANAGER \<IMicrosoftGraphDirectoryObject\>: Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[DeletedDateTime \<DateTime?\>\]: 

MEMBEROF \<IMicrosoftGraphDirectoryObject\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[DeletedDateTime \<DateTime?\>\]: 

ONPREMISESPROVISIONINGERRORS \<IMicrosoftGraphOnPremisesProvisioningError\[\]\>: .
  \[Category \<String\>\]: Category of the provisioning error.
Note: Currently, there is only one possible value.
Possible value: PropertyConflict - indicates a property value is not unique.
Other objects contain the same value for the property.
  \[OccurredDateTime \<DateTime?\>\]: The date and time at which the error occurred.
  \[PropertyCausingError \<String\>\]: Name of the directory property causing the error.
Current possible values: UserPrincipalName or ProxyAddress
  \[Value \<String\>\]: Value of the property causing the error.

PHONES \<IMicrosoftGraphPhone\[\]\>: .
  \[Language \<String\>\]: 
  \[Number \<String\>\]: The phone number.
  \[Region \<String\>\]: 
  \[Type \<String\>\]: phoneType

TRANSITIVEMEMBEROF \<IMicrosoftGraphDirectoryObject\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[DeletedDateTime \<DateTime?\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgcontact](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgcontact)
