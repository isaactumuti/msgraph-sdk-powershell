---
external help file: Microsoft.Graph.PersonalContacts-help.xml
Module Name: Microsoft.Graph.PersonalContacts
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.personalcontacts/new-mgusercontactfoldermultivalueextendedproperty
schema: 2.0.0
---

# New-MgUserContactFolderMultiValueExtendedProperty

## SYNOPSIS
Create new navigation property to multiValueExtendedProperties for users

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgUserContactFolderMultiValueExtendedProperty -ContactFolderId <String> -UserId <String>
 [-AdditionalProperties <Hashtable>] [-Id <String>] [-Value <String[]>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Create1
```
New-MgUserContactFolderMultiValueExtendedProperty -ContactFolderId <String> -UserId <String>
 -BodyParameter <IMicrosoftGraphMultiValueLegacyExtendedProperty> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgUserContactFolderMultiValueExtendedProperty -InputObject <IPersonalContactsIdentity>
 [-AdditionalProperties <Hashtable>] [-Id <String>] [-Value <String[]>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgUserContactFolderMultiValueExtendedProperty -InputObject <IPersonalContactsIdentity>
 -BodyParameter <IMicrosoftGraphMultiValueLegacyExtendedProperty> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to multiValueExtendedProperties for users

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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
multiValueLegacyExtendedProperty
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphMultiValueLegacyExtendedProperty
Parameter Sets: Create1, CreateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContactFolderId
key: id of contactFolder

```yaml
Type: String
Parameter Sets: CreateExpanded1, Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Type: IPersonalContactsIdentity
Parameter Sets: CreateViaIdentityExpanded1, CreateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -UserId
key: id of user

```yaml
Type: String
Parameter Sets: CreateExpanded1, Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Value
A collection of property values.

```yaml
Type: String[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty
### Microsoft.Graph.PowerShell.Models.IPersonalContactsIdentity
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphMultiValueLegacyExtendedProperty\>: multiValueLegacyExtendedProperty
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[Value \<String\[\]\>\]: A collection of property values.

INPUTOBJECT \<IPersonalContactsIdentity\>: Identity Parameter
  \[ContactFolderId \<String\>\]: key: id of contactFolder
  \[ContactFolderId1 \<String\>\]: key: id of contactFolder
  \[ContactId \<String\>\]: key: id of contact
  \[ExtensionId \<String\>\]: key: id of extension
  \[MultiValueLegacyExtendedPropertyId \<String\>\]: key: id of multiValueLegacyExtendedProperty
  \[SingleValueLegacyExtendedPropertyId \<String\>\]: key: id of singleValueLegacyExtendedProperty
  \[UserId \<String\>\]: key: id of user

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.personalcontacts/new-mgusercontactfoldermultivalueextendedproperty](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.personalcontacts/new-mgusercontactfoldermultivalueextendedproperty)
