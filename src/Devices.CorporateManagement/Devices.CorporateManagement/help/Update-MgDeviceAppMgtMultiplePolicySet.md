---
external help file: Microsoft.Graph.Devices.CorporateManagement-help.xml
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgdeviceappmgtmultiplepolicyset
schema: 2.0.0
---

# Update-MgDeviceAppMgtMultiplePolicySet

## SYNOPSIS
Invoke action update

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgDeviceAppMgtMultiplePolicySet -PolicySetId <String>
 [-AddedPolicySetItems <IMicrosoftGraphPolicySetItem[]>] [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphPolicySetAssignment[]>] [-DeletedPolicySetItems <String[]>]
 [-UpdatedPolicySetItems <IMicrosoftGraphPolicySetItem[]>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Update1
```
Update-MgDeviceAppMgtMultiplePolicySet -PolicySetId <String>
 -BodyParameter <IPathsNb5PtwDeviceappmanagementPolicysetsPolicysetIdMicrosoftGraphUpdatePostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgDeviceAppMgtMultiplePolicySet -InputObject <IDevicesCorporateManagementIdentity>
 [-AddedPolicySetItems <IMicrosoftGraphPolicySetItem[]>] [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphPolicySetAssignment[]>] [-DeletedPolicySetItems <String[]>]
 [-UpdatedPolicySetItems <IMicrosoftGraphPolicySetItem[]>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgDeviceAppMgtMultiplePolicySet -InputObject <IDevicesCorporateManagementIdentity>
 -BodyParameter <IPathsNb5PtwDeviceappmanagementPolicysetsPolicysetIdMicrosoftGraphUpdatePostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Invoke action update

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

### -AddedPolicySetItems
.
To construct, see NOTES section for ADDEDPOLICYSETITEMS properties and create a hash table.

```yaml
Type: IMicrosoftGraphPolicySetItem[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Assignments
.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: IMicrosoftGraphPolicySetAssignment[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IPathsNb5PtwDeviceappmanagementPolicysetsPolicysetIdMicrosoftGraphUpdatePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeletedPolicySetItems
.

```yaml
Type: String[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Type: IDevicesCorporateManagementIdentity
Parameter Sets: UpdateViaIdentityExpanded1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -PolicySetId
key: id of policySet

```yaml
Type: String
Parameter Sets: UpdateExpanded1, Update1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UpdatedPolicySetItems
.
To construct, see NOTES section for UPDATEDPOLICYSETITEMS properties and create a hash table.

```yaml
Type: IMicrosoftGraphPolicySetItem[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IDevicesCorporateManagementIdentity
### Microsoft.Graph.PowerShell.Models.IPathsNb5PtwDeviceappmanagementPolicysetsPolicysetIdMicrosoftGraphUpdatePostRequestbodyContentApplicationJsonSchema
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

ADDEDPOLICYSETITEMS \<IMicrosoftGraphPolicySetItem\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[CreatedDateTime \<DateTime?\>\]: Creation time of the PolicySetItem.
  \[DisplayName \<String\>\]: DisplayName of the PolicySetItem.
  \[ErrorCode \<String\>\]: errorCode
  \[GuidedDeploymentTags \<String\[\]\>\]: Tags of the guided deployment
  \[ItemType \<String\>\]: policySetType of the PolicySetItem.
  \[LastModifiedDateTime \<DateTime?\>\]: Last modified time of the PolicySetItem.
  \[PayloadId \<String\>\]: PayloadId of the PolicySetItem.
  \[Status \<String\>\]: policySetStatus

ASSIGNMENTS \<IMicrosoftGraphPolicySetAssignment\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[LastModifiedDateTime \<DateTime?\>\]: Last modified time of the PolicySetAssignment.
  \[Target \<IMicrosoftGraphDeviceAndAppManagementAssignmentTarget\>\]: Base type for assignment targets.
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[DeviceAndAppManagementAssignmentFilterId \<String\>\]: The Id of the filter for the target assignment.
    \[DeviceAndAppManagementAssignmentFilterType \<String\>\]: deviceAndAppManagementAssignmentFilterType

BODYPARAMETER \<IPathsNb5PtwDeviceappmanagementPolicysetsPolicysetIdMicrosoftGraphUpdatePostRequestbodyContentApplicationJsonSchema\>: .
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[AddedPolicySetItems \<IMicrosoftGraphPolicySetItem\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[CreatedDateTime \<DateTime?\>\]: Creation time of the PolicySetItem.
    \[DisplayName \<String\>\]: DisplayName of the PolicySetItem.
    \[ErrorCode \<String\>\]: errorCode
    \[GuidedDeploymentTags \<String\[\]\>\]: Tags of the guided deployment
    \[ItemType \<String\>\]: policySetType of the PolicySetItem.
    \[LastModifiedDateTime \<DateTime?\>\]: Last modified time of the PolicySetItem.
    \[PayloadId \<String\>\]: PayloadId of the PolicySetItem.
    \[Status \<String\>\]: policySetStatus
  \[Assignments \<IMicrosoftGraphPolicySetAssignment\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[LastModifiedDateTime \<DateTime?\>\]: Last modified time of the PolicySetAssignment.
    \[Target \<IMicrosoftGraphDeviceAndAppManagementAssignmentTarget\>\]: Base type for assignment targets.
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[DeviceAndAppManagementAssignmentFilterId \<String\>\]: The Id of the filter for the target assignment.
      \[DeviceAndAppManagementAssignmentFilterType \<String\>\]: deviceAndAppManagementAssignmentFilterType
  \[DeletedPolicySetItems \<String\[\]\>\]: 
  \[UpdatedPolicySetItems \<IMicrosoftGraphPolicySetItem\[\]\>\]: 

INPUTOBJECT \<IDevicesCorporateManagementIdentity\>: Identity Parameter
  \[AndroidManagedAppProtectionId \<String\>\]: key: id of androidManagedAppProtection
  \[AppLogCollectionRequestId \<String\>\]: key: id of appLogCollectionRequest
  \[BundleId \<String\>\]: 
  \[Count \<Int64?\>\]: 
  \[DefaultManagedAppProtectionId \<String\>\]: key: id of defaultManagedAppProtection
  \[DeviceAppManagementTaskId \<String\>\]: key: id of deviceAppManagementTask
  \[DeviceCompliancePolicyStateId \<String\>\]: key: id of deviceCompliancePolicyState
  \[DeviceConfigurationStateId \<String\>\]: key: id of deviceConfigurationState
  \[DeviceEnrollmentConfigurationId \<String\>\]: key: id of deviceEnrollmentConfiguration
  \[DeviceId \<String\>\]: 
  \[DeviceInstallStateId \<String\>\]: key: id of deviceInstallState
  \[DeviceLogCollectionResponseId \<String\>\]: key: id of deviceLogCollectionResponse
  \[DeviceManagementTroubleshootingEventId \<String\>\]: key: id of deviceManagementTroubleshootingEvent
  \[EnrollmentConfigurationAssignmentId \<String\>\]: key: id of enrollmentConfigurationAssignment
  \[EnterpriseCodeSigningCertificateId \<String\>\]: key: id of enterpriseCodeSigningCertificate
  \[IosLobAppProvisioningConfigurationAssignmentId \<String\>\]: key: id of iosLobAppProvisioningConfigurationAssignment
  \[IosLobAppProvisioningConfigurationId \<String\>\]: key: id of iosLobAppProvisioningConfiguration
  \[IosManagedAppProtectionId \<String\>\]: key: id of iosManagedAppProtection
  \[ManagedAppOperationId \<String\>\]: key: id of managedAppOperation
  \[ManagedAppPolicyId \<String\>\]: key: id of managedAppPolicy
  \[ManagedAppRegistrationId \<String\>\]: key: id of managedAppRegistration
  \[ManagedAppStatusId \<String\>\]: key: id of managedAppStatus
  \[ManagedDeviceId \<String\>\]: key: id of managedDevice
  \[ManagedDeviceMobileAppConfigurationAssignmentId \<String\>\]: key: id of managedDeviceMobileAppConfigurationAssignment
  \[ManagedDeviceMobileAppConfigurationDeviceStatusId \<String\>\]: key: id of managedDeviceMobileAppConfigurationDeviceStatus
  \[ManagedDeviceMobileAppConfigurationId \<String\>\]: key: id of managedDeviceMobileAppConfiguration
  \[ManagedDeviceMobileAppConfigurationStateId \<String\>\]: key: id of managedDeviceMobileAppConfigurationState
  \[ManagedDeviceMobileAppConfigurationUserStatusId \<String\>\]: key: id of managedDeviceMobileAppConfigurationUserStatus
  \[ManagedEBookAssignmentId \<String\>\]: key: id of managedEBookAssignment
  \[ManagedEBookCategoryId \<String\>\]: key: id of managedEBookCategory
  \[ManagedEBookId \<String\>\]: key: id of managedEBook
  \[ManagedMobileAppId \<String\>\]: key: id of managedMobileApp
  \[MdmWindowsInformationProtectionPolicyId \<String\>\]: key: id of mdmWindowsInformationProtectionPolicy
  \[MobileAppAssignmentId \<String\>\]: key: id of mobileAppAssignment
  \[MobileAppCategoryId \<String\>\]: key: id of mobileAppCategory
  \[MobileAppId \<String\>\]: key: id of mobileApp
  \[MobileAppInstallStatusId \<String\>\]: key: id of mobileAppInstallStatus
  \[MobileAppIntentAndStateId \<String\>\]: key: id of mobileAppIntentAndState
  \[MobileAppProvisioningConfigGroupAssignmentId \<String\>\]: key: id of mobileAppProvisioningConfigGroupAssignment
  \[MobileAppRelationshipId \<String\>\]: key: id of mobileAppRelationship
  \[MobileAppTroubleshootingEventId \<String\>\]: key: id of mobileAppTroubleshootingEvent
  \[OfficeClientConfigurationAssignmentId \<String\>\]: key: id of officeClientConfigurationAssignment
  \[OfficeClientConfigurationId \<String\>\]: key: id of officeClientConfiguration
  \[PolicySetAssignmentId \<String\>\]: key: id of policySetAssignment
  \[PolicySetId \<String\>\]: key: id of policySet
  \[PolicySetItemId \<String\>\]: key: id of policySetItem
  \[SecurityBaselineSettingStateId \<String\>\]: key: id of securityBaselineSettingState
  \[SecurityBaselineStateId \<String\>\]: key: id of securityBaselineState
  \[SideLoadingKeyId \<String\>\]: key: id of sideLoadingKey
  \[Status \<String\>\]: 
  \[TargetedManagedAppConfigurationId \<String\>\]: key: id of targetedManagedAppConfiguration
  \[TargetedManagedAppPolicyAssignmentId \<String\>\]: key: id of targetedManagedAppPolicyAssignment
  \[UserAppInstallStatusId \<String\>\]: key: id of userAppInstallStatus
  \[UserId \<String\>\]: key: id of user
  \[UserId1 \<String\>\]: key: id of user
  \[UserInstallStateSummaryId \<String\>\]: key: id of userInstallStateSummary
  \[UserPrincipalName \<String\>\]: 
  \[VppTokenId \<String\>\]: key: id of vppToken
  \[WindowsDefenderApplicationControlSupplementalPolicyAssignmentId \<String\>\]: key: id of windowsDefenderApplicationControlSupplementalPolicyAssignment
  \[WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatusId \<String\>\]: key: id of windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus
  \[WindowsDefenderApplicationControlSupplementalPolicyId \<String\>\]: key: id of windowsDefenderApplicationControlSupplementalPolicy
  \[WindowsDeviceMalwareStateId \<String\>\]: key: id of windowsDeviceMalwareState
  \[WindowsInformationProtectionDeviceRegistrationId \<String\>\]: key: id of windowsInformationProtectionDeviceRegistration
  \[WindowsInformationProtectionPolicyId \<String\>\]: key: id of windowsInformationProtectionPolicy
  \[WindowsInformationProtectionWipeActionId \<String\>\]: key: id of windowsInformationProtectionWipeAction

UPDATEDPOLICYSETITEMS \<IMicrosoftGraphPolicySetItem\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[CreatedDateTime \<DateTime?\>\]: Creation time of the PolicySetItem.
  \[DisplayName \<String\>\]: DisplayName of the PolicySetItem.
  \[ErrorCode \<String\>\]: errorCode
  \[GuidedDeploymentTags \<String\[\]\>\]: Tags of the guided deployment
  \[ItemType \<String\>\]: policySetType of the PolicySetItem.
  \[LastModifiedDateTime \<DateTime?\>\]: Last modified time of the PolicySetItem.
  \[PayloadId \<String\>\]: PayloadId of the PolicySetItem.
  \[Status \<String\>\]: policySetStatus

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgdeviceappmgtmultiplepolicyset](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgdeviceappmgtmultiplepolicyset)
