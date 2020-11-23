---
external help file: Microsoft.Graph.Identity.Governance-help.xml
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgprivilegedaccessroleassignment
schema: 2.0.0
---

# Update-MgPrivilegedAccessRoleAssignment

## SYNOPSIS
Update the navigation property roleAssignments in privilegedAccess

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgPrivilegedAccessRoleAssignment -GovernanceRoleAssignmentId <String> -PrivilegedAccessId <String>
 [-AdditionalProperties <Hashtable>] [-AssignmentState <String>] [-EndDateTime <DateTime>]
 [-ExternalId <String>] [-Id <String>]
 [-LinkedEligibleRoleAssignment <IMicrosoftGraphGovernanceRoleAssignment>]
 [-LinkedEligibleRoleAssignmentId <String>] [-MemberType <String>]
 [-Resource <IMicrosoftGraphGovernanceResource>] [-ResourceId <String>]
 [-RoleDefinition <IMicrosoftGraphGovernanceRoleDefinition>] [-RoleDefinitionId <String>]
 [-StartDateTime <DateTime>] [-Status <String>] [-Subject <IMicrosoftGraphGovernanceSubject>]
 [-SubjectId <String>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgPrivilegedAccessRoleAssignment -GovernanceRoleAssignmentId <String> -PrivilegedAccessId <String>
 -BodyParameter <IMicrosoftGraphGovernanceRoleAssignment> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgPrivilegedAccessRoleAssignment -InputObject <IIdentityGovernanceIdentity>
 [-AdditionalProperties <Hashtable>] [-AssignmentState <String>] [-EndDateTime <DateTime>]
 [-ExternalId <String>] [-Id <String>]
 [-LinkedEligibleRoleAssignment <IMicrosoftGraphGovernanceRoleAssignment>]
 [-LinkedEligibleRoleAssignmentId <String>] [-MemberType <String>]
 [-Resource <IMicrosoftGraphGovernanceResource>] [-ResourceId <String>]
 [-RoleDefinition <IMicrosoftGraphGovernanceRoleDefinition>] [-RoleDefinitionId <String>]
 [-StartDateTime <DateTime>] [-Status <String>] [-Subject <IMicrosoftGraphGovernanceSubject>]
 [-SubjectId <String>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgPrivilegedAccessRoleAssignment -InputObject <IIdentityGovernanceIdentity>
 -BodyParameter <IMicrosoftGraphGovernanceRoleAssignment> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property roleAssignments in privilegedAccess

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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssignmentState
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
governanceRoleAssignment
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphGovernanceRoleAssignment
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EndDateTime
.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExternalId
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GovernanceRoleAssignmentId
key: id of governanceRoleAssignment

```yaml
Type: String
Parameter Sets: UpdateExpanded, Update
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: IIdentityGovernanceIdentity
Parameter Sets: UpdateViaIdentityExpanded, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LinkedEligibleRoleAssignment
governanceRoleAssignment
To construct, see NOTES section for LINKEDELIGIBLEROLEASSIGNMENT properties and create a hash table.

```yaml
Type: IMicrosoftGraphGovernanceRoleAssignment
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LinkedEligibleRoleAssignmentId
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MemberType
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
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

### -PrivilegedAccessId
key: id of privilegedAccess

```yaml
Type: String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Resource
governanceResource
To construct, see NOTES section for RESOURCE properties and create a hash table.

```yaml
Type: IMicrosoftGraphGovernanceResource
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceId
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoleDefinition
governanceRoleDefinition
To construct, see NOTES section for ROLEDEFINITION properties and create a hash table.

```yaml
Type: IMicrosoftGraphGovernanceRoleDefinition
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoleDefinitionId
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartDateTime
.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Subject
governanceSubject
To construct, see NOTES section for SUBJECT properties and create a hash table.

```yaml
Type: IMicrosoftGraphGovernanceSubject
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubjectId
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IIdentityGovernanceIdentity
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGovernanceRoleAssignment
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphGovernanceRoleAssignment\>: governanceRoleAssignment
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[AssignmentState \<String\>\]: 
  \[EndDateTime \<DateTime?\>\]: 
  \[ExternalId \<String\>\]: 
  \[LinkedEligibleRoleAssignment \<IMicrosoftGraphGovernanceRoleAssignment\>\]: governanceRoleAssignment
  \[LinkedEligibleRoleAssignmentId \<String\>\]: 
  \[MemberType \<String\>\]: 
  \[Resource \<IMicrosoftGraphGovernanceResource\>\]: governanceResource
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[DisplayName \<String\>\]: 
    \[ExternalId \<String\>\]: 
    \[Parent \<IMicrosoftGraphGovernanceResource\>\]: governanceResource
    \[RegisteredDateTime \<DateTime?\>\]: 
    \[RegisteredRoot \<String\>\]: 
    \[RoleAssignmentRequests \<IMicrosoftGraphGovernanceRoleAssignmentRequest\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[AssignmentState \<String\>\]: 
      \[LinkedEligibleRoleAssignmentId \<String\>\]: 
      \[Reason \<String\>\]: 
      \[RequestedDateTime \<DateTime?\>\]: 
      \[Resource \<IMicrosoftGraphGovernanceResource\>\]: governanceResource
      \[ResourceId \<String\>\]: 
      \[RoleDefinition \<IMicrosoftGraphGovernanceRoleDefinition\>\]: governanceRoleDefinition
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Id \<String\>\]: Read-only.
        \[DisplayName \<String\>\]: 
        \[ExternalId \<String\>\]: 
        \[Resource \<IMicrosoftGraphGovernanceResource\>\]: governanceResource
        \[ResourceId \<String\>\]: 
        \[RoleSetting \<IMicrosoftGraphGovernanceRoleSetting\>\]: governanceRoleSetting
          \[(Any) \<Object\>\]: This indicates any property can be added to this object.
          \[Id \<String\>\]: Read-only.
          \[AdminEligibleSettings \<IMicrosoftGraphGovernanceRuleSetting\[\]\>\]: 
            \[RuleIdentifier \<String\>\]: 
            \[Setting \<String\>\]: 
          \[AdminMemberSettings \<IMicrosoftGraphGovernanceRuleSetting\[\]\>\]: 
          \[IsDefault \<Boolean?\>\]: 
          \[LastUpdatedBy \<String\>\]: 
          \[LastUpdatedDateTime \<DateTime?\>\]: 
          \[Resource \<IMicrosoftGraphGovernanceResource\>\]: governanceResource
          \[ResourceId \<String\>\]: 
          \[RoleDefinition \<IMicrosoftGraphGovernanceRoleDefinition\>\]: governanceRoleDefinition
          \[RoleDefinitionId \<String\>\]: 
          \[UserEligibleSettings \<IMicrosoftGraphGovernanceRuleSetting\[\]\>\]: 
          \[UserMemberSettings \<IMicrosoftGraphGovernanceRuleSetting\[\]\>\]: 
        \[TemplateId \<String\>\]: 
      \[RoleDefinitionId \<String\>\]: 
      \[Schedule \<IMicrosoftGraphGovernanceSchedule\>\]: governanceSchedule
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Duration \<TimeSpan?\>\]: 
        \[EndDateTime \<DateTime?\>\]: 
        \[StartDateTime \<DateTime?\>\]: 
        \[Type \<String\>\]: 
      \[Status \<IMicrosoftGraphGovernanceRoleAssignmentRequestStatus\>\]: governanceRoleAssignmentRequestStatus
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Status \<String\>\]: 
        \[StatusDetails \<IMicrosoftGraphKeyValue\[\]\>\]: 
          \[Key \<String\>\]: Key for the key-value pair.
          \[Value \<String\>\]: Value for the key-value pair.
        \[SubStatus \<String\>\]: 
      \[Subject \<IMicrosoftGraphGovernanceSubject\>\]: governanceSubject
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Id \<String\>\]: Read-only.
        \[DisplayName \<String\>\]: 
        \[Email \<String\>\]: 
        \[PrincipalName \<String\>\]: 
        \[Type \<String\>\]: 
      \[SubjectId \<String\>\]: 
      \[Type \<String\>\]: 
    \[RoleAssignments \<IMicrosoftGraphGovernanceRoleAssignment\[\]\>\]: 
    \[RoleDefinitions \<IMicrosoftGraphGovernanceRoleDefinition\[\]\>\]: 
    \[RoleSettings \<IMicrosoftGraphGovernanceRoleSetting\[\]\>\]: 
    \[Status \<String\>\]: 
    \[Type \<String\>\]: 
  \[ResourceId \<String\>\]: 
  \[RoleDefinition \<IMicrosoftGraphGovernanceRoleDefinition\>\]: governanceRoleDefinition
  \[RoleDefinitionId \<String\>\]: 
  \[StartDateTime \<DateTime?\>\]: 
  \[Status \<String\>\]: 
  \[Subject \<IMicrosoftGraphGovernanceSubject\>\]: governanceSubject
  \[SubjectId \<String\>\]: 

INPUTOBJECT \<IIdentityGovernanceIdentity\>: Identity Parameter
  \[AccessPackageAssignmentId \<String\>\]: key: id of accessPackageAssignment
  \[AccessPackageAssignmentPolicyId \<String\>\]: key: id of accessPackageAssignmentPolicy
  \[AccessPackageAssignmentRequestId \<String\>\]: key: id of accessPackageAssignmentRequest
  \[AccessPackageAssignmentResourceRoleId \<String\>\]: key: id of accessPackageAssignmentResourceRole
  \[AccessPackageCatalogId \<String\>\]: key: id of accessPackageCatalog
  \[AccessPackageId \<String\>\]: key: id of accessPackage
  \[AccessPackageResourceId \<String\>\]: key: id of accessPackageResource
  \[AccessPackageResourceRequestId \<String\>\]: key: id of accessPackageResourceRequest
  \[AccessPackageResourceRoleId \<String\>\]: key: id of accessPackageResourceRole
  \[AccessPackageResourceRoleScopeId \<String\>\]: key: id of accessPackageResourceRoleScope
  \[AccessPackageResourceScopeId \<String\>\]: key: id of accessPackageResourceScope
  \[AccessReviewDecisionId \<String\>\]: key: id of accessReviewDecision
  \[AccessReviewId \<String\>\]: key: id of accessReview
  \[AccessReviewId1 \<String\>\]: key: id of accessReview
  \[AccessReviewInstanceId \<String\>\]: key: id of accessReviewInstance
  \[AccessReviewReviewerId \<String\>\]: key: id of accessReviewReviewer
  \[AccessReviewScheduleDefinitionId \<String\>\]: key: id of accessReviewScheduleDefinition
  \[AgreementAcceptanceId \<String\>\]: key: id of agreementAcceptance
  \[AgreementFileLocalizationId \<String\>\]: key: id of agreementFileLocalization
  \[AgreementFileVersionId \<String\>\]: key: id of agreementFileVersion
  \[AgreementId \<String\>\]: key: id of agreement
  \[BusinessFlowTemplateId \<String\>\]: key: id of businessFlowTemplate
  \[ConnectedOrganizationId \<String\>\]: key: id of connectedOrganization
  \[DirectoryObjectId \<String\>\]: key: id of directoryObject
  \[GovernanceResourceId \<String\>\]: key: id of governanceResource
  \[GovernanceRoleAssignmentId \<String\>\]: key: id of governanceRoleAssignment
  \[GovernanceRoleAssignmentRequestId \<String\>\]: key: id of governanceRoleAssignmentRequest
  \[GovernanceRoleDefinitionId \<String\>\]: key: id of governanceRoleDefinition
  \[GovernanceRoleSettingId \<String\>\]: key: id of governanceRoleSetting
  \[PrivilegedAccessId \<String\>\]: key: id of privilegedAccess
  \[PrivilegedApprovalId \<String\>\]: key: id of privilegedApproval
  \[PrivilegedOperationEventId \<String\>\]: key: id of privilegedOperationEvent
  \[PrivilegedRoleAssignmentId \<String\>\]: key: id of privilegedRoleAssignment
  \[PrivilegedRoleAssignmentRequestId \<String\>\]: key: id of privilegedRoleAssignmentRequest
  \[PrivilegedRoleId \<String\>\]: key: id of privilegedRole
  \[ProgramControlId \<String\>\]: key: id of programControl
  \[ProgramControlTypeId \<String\>\]: key: id of programControlType
  \[ProgramId \<String\>\]: key: id of program
  \[UserId \<String\>\]: key: id of user

LINKEDELIGIBLEROLEASSIGNMENT \<IMicrosoftGraphGovernanceRoleAssignment\>: governanceRoleAssignment
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[AssignmentState \<String\>\]: 
  \[EndDateTime \<DateTime?\>\]: 
  \[ExternalId \<String\>\]: 
  \[LinkedEligibleRoleAssignment \<IMicrosoftGraphGovernanceRoleAssignment\>\]: governanceRoleAssignment
  \[LinkedEligibleRoleAssignmentId \<String\>\]: 
  \[MemberType \<String\>\]: 
  \[Resource \<IMicrosoftGraphGovernanceResource\>\]: governanceResource
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[DisplayName \<String\>\]: 
    \[ExternalId \<String\>\]: 
    \[Parent \<IMicrosoftGraphGovernanceResource\>\]: governanceResource
    \[RegisteredDateTime \<DateTime?\>\]: 
    \[RegisteredRoot \<String\>\]: 
    \[RoleAssignmentRequests \<IMicrosoftGraphGovernanceRoleAssignmentRequest\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[AssignmentState \<String\>\]: 
      \[LinkedEligibleRoleAssignmentId \<String\>\]: 
      \[Reason \<String\>\]: 
      \[RequestedDateTime \<DateTime?\>\]: 
      \[Resource \<IMicrosoftGraphGovernanceResource\>\]: governanceResource
      \[ResourceId \<String\>\]: 
      \[RoleDefinition \<IMicrosoftGraphGovernanceRoleDefinition\>\]: governanceRoleDefinition
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Id \<String\>\]: Read-only.
        \[DisplayName \<String\>\]: 
        \[ExternalId \<String\>\]: 
        \[Resource \<IMicrosoftGraphGovernanceResource\>\]: governanceResource
        \[ResourceId \<String\>\]: 
        \[RoleSetting \<IMicrosoftGraphGovernanceRoleSetting\>\]: governanceRoleSetting
          \[(Any) \<Object\>\]: This indicates any property can be added to this object.
          \[Id \<String\>\]: Read-only.
          \[AdminEligibleSettings \<IMicrosoftGraphGovernanceRuleSetting\[\]\>\]: 
            \[RuleIdentifier \<String\>\]: 
            \[Setting \<String\>\]: 
          \[AdminMemberSettings \<IMicrosoftGraphGovernanceRuleSetting\[\]\>\]: 
          \[IsDefault \<Boolean?\>\]: 
          \[LastUpdatedBy \<String\>\]: 
          \[LastUpdatedDateTime \<DateTime?\>\]: 
          \[Resource \<IMicrosoftGraphGovernanceResource\>\]: governanceResource
          \[ResourceId \<String\>\]: 
          \[RoleDefinition \<IMicrosoftGraphGovernanceRoleDefinition\>\]: governanceRoleDefinition
          \[RoleDefinitionId \<String\>\]: 
          \[UserEligibleSettings \<IMicrosoftGraphGovernanceRuleSetting\[\]\>\]: 
          \[UserMemberSettings \<IMicrosoftGraphGovernanceRuleSetting\[\]\>\]: 
        \[TemplateId \<String\>\]: 
      \[RoleDefinitionId \<String\>\]: 
      \[Schedule \<IMicrosoftGraphGovernanceSchedule\>\]: governanceSchedule
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Duration \<TimeSpan?\>\]: 
        \[EndDateTime \<DateTime?\>\]: 
        \[StartDateTime \<DateTime?\>\]: 
        \[Type \<String\>\]: 
      \[Status \<IMicrosoftGraphGovernanceRoleAssignmentRequestStatus\>\]: governanceRoleAssignmentRequestStatus
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Status \<String\>\]: 
        \[StatusDetails \<IMicrosoftGraphKeyValue\[\]\>\]: 
          \[Key \<String\>\]: Key for the key-value pair.
          \[Value \<String\>\]: Value for the key-value pair.
        \[SubStatus \<String\>\]: 
      \[Subject \<IMicrosoftGraphGovernanceSubject\>\]: governanceSubject
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Id \<String\>\]: Read-only.
        \[DisplayName \<String\>\]: 
        \[Email \<String\>\]: 
        \[PrincipalName \<String\>\]: 
        \[Type \<String\>\]: 
      \[SubjectId \<String\>\]: 
      \[Type \<String\>\]: 
    \[RoleAssignments \<IMicrosoftGraphGovernanceRoleAssignment\[\]\>\]: 
    \[RoleDefinitions \<IMicrosoftGraphGovernanceRoleDefinition\[\]\>\]: 
    \[RoleSettings \<IMicrosoftGraphGovernanceRoleSetting\[\]\>\]: 
    \[Status \<String\>\]: 
    \[Type \<String\>\]: 
  \[ResourceId \<String\>\]: 
  \[RoleDefinition \<IMicrosoftGraphGovernanceRoleDefinition\>\]: governanceRoleDefinition
  \[RoleDefinitionId \<String\>\]: 
  \[StartDateTime \<DateTime?\>\]: 
  \[Status \<String\>\]: 
  \[Subject \<IMicrosoftGraphGovernanceSubject\>\]: governanceSubject
  \[SubjectId \<String\>\]: 

RESOURCE \<IMicrosoftGraphGovernanceResource\>: governanceResource
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[DisplayName \<String\>\]: 
  \[ExternalId \<String\>\]: 
  \[Parent \<IMicrosoftGraphGovernanceResource\>\]: governanceResource
  \[RegisteredDateTime \<DateTime?\>\]: 
  \[RegisteredRoot \<String\>\]: 
  \[RoleAssignmentRequests \<IMicrosoftGraphGovernanceRoleAssignmentRequest\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[AssignmentState \<String\>\]: 
    \[LinkedEligibleRoleAssignmentId \<String\>\]: 
    \[Reason \<String\>\]: 
    \[RequestedDateTime \<DateTime?\>\]: 
    \[Resource \<IMicrosoftGraphGovernanceResource\>\]: governanceResource
    \[ResourceId \<String\>\]: 
    \[RoleDefinition \<IMicrosoftGraphGovernanceRoleDefinition\>\]: governanceRoleDefinition
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Id \<String\>\]: Read-only.
      \[DisplayName \<String\>\]: 
      \[ExternalId \<String\>\]: 
      \[Resource \<IMicrosoftGraphGovernanceResource\>\]: governanceResource
      \[ResourceId \<String\>\]: 
      \[RoleSetting \<IMicrosoftGraphGovernanceRoleSetting\>\]: governanceRoleSetting
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Id \<String\>\]: Read-only.
        \[AdminEligibleSettings \<IMicrosoftGraphGovernanceRuleSetting\[\]\>\]: 
          \[RuleIdentifier \<String\>\]: 
          \[Setting \<String\>\]: 
        \[AdminMemberSettings \<IMicrosoftGraphGovernanceRuleSetting\[\]\>\]: 
        \[IsDefault \<Boolean?\>\]: 
        \[LastUpdatedBy \<String\>\]: 
        \[LastUpdatedDateTime \<DateTime?\>\]: 
        \[Resource \<IMicrosoftGraphGovernanceResource\>\]: governanceResource
        \[ResourceId \<String\>\]: 
        \[RoleDefinition \<IMicrosoftGraphGovernanceRoleDefinition\>\]: governanceRoleDefinition
        \[RoleDefinitionId \<String\>\]: 
        \[UserEligibleSettings \<IMicrosoftGraphGovernanceRuleSetting\[\]\>\]: 
        \[UserMemberSettings \<IMicrosoftGraphGovernanceRuleSetting\[\]\>\]: 
      \[TemplateId \<String\>\]: 
    \[RoleDefinitionId \<String\>\]: 
    \[Schedule \<IMicrosoftGraphGovernanceSchedule\>\]: governanceSchedule
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Duration \<TimeSpan?\>\]: 
      \[EndDateTime \<DateTime?\>\]: 
      \[StartDateTime \<DateTime?\>\]: 
      \[Type \<String\>\]: 
    \[Status \<IMicrosoftGraphGovernanceRoleAssignmentRequestStatus\>\]: governanceRoleAssignmentRequestStatus
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Status \<String\>\]: 
      \[StatusDetails \<IMicrosoftGraphKeyValue\[\]\>\]: 
        \[Key \<String\>\]: Key for the key-value pair.
        \[Value \<String\>\]: Value for the key-value pair.
      \[SubStatus \<String\>\]: 
    \[Subject \<IMicrosoftGraphGovernanceSubject\>\]: governanceSubject
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Id \<String\>\]: Read-only.
      \[DisplayName \<String\>\]: 
      \[Email \<String\>\]: 
      \[PrincipalName \<String\>\]: 
      \[Type \<String\>\]: 
    \[SubjectId \<String\>\]: 
    \[Type \<String\>\]: 
  \[RoleAssignments \<IMicrosoftGraphGovernanceRoleAssignment\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[AssignmentState \<String\>\]: 
    \[EndDateTime \<DateTime?\>\]: 
    \[ExternalId \<String\>\]: 
    \[LinkedEligibleRoleAssignment \<IMicrosoftGraphGovernanceRoleAssignment\>\]: governanceRoleAssignment
    \[LinkedEligibleRoleAssignmentId \<String\>\]: 
    \[MemberType \<String\>\]: 
    \[Resource \<IMicrosoftGraphGovernanceResource\>\]: governanceResource
    \[ResourceId \<String\>\]: 
    \[RoleDefinition \<IMicrosoftGraphGovernanceRoleDefinition\>\]: governanceRoleDefinition
    \[RoleDefinitionId \<String\>\]: 
    \[StartDateTime \<DateTime?\>\]: 
    \[Status \<String\>\]: 
    \[Subject \<IMicrosoftGraphGovernanceSubject\>\]: governanceSubject
    \[SubjectId \<String\>\]: 
  \[RoleDefinitions \<IMicrosoftGraphGovernanceRoleDefinition\[\]\>\]: 
  \[RoleSettings \<IMicrosoftGraphGovernanceRoleSetting\[\]\>\]: 
  \[Status \<String\>\]: 
  \[Type \<String\>\]: 

ROLEDEFINITION \<IMicrosoftGraphGovernanceRoleDefinition\>: governanceRoleDefinition
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[DisplayName \<String\>\]: 
  \[ExternalId \<String\>\]: 
  \[Resource \<IMicrosoftGraphGovernanceResource\>\]: governanceResource
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[DisplayName \<String\>\]: 
    \[ExternalId \<String\>\]: 
    \[Parent \<IMicrosoftGraphGovernanceResource\>\]: governanceResource
    \[RegisteredDateTime \<DateTime?\>\]: 
    \[RegisteredRoot \<String\>\]: 
    \[RoleAssignmentRequests \<IMicrosoftGraphGovernanceRoleAssignmentRequest\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[AssignmentState \<String\>\]: 
      \[LinkedEligibleRoleAssignmentId \<String\>\]: 
      \[Reason \<String\>\]: 
      \[RequestedDateTime \<DateTime?\>\]: 
      \[Resource \<IMicrosoftGraphGovernanceResource\>\]: governanceResource
      \[ResourceId \<String\>\]: 
      \[RoleDefinition \<IMicrosoftGraphGovernanceRoleDefinition\>\]: governanceRoleDefinition
      \[RoleDefinitionId \<String\>\]: 
      \[Schedule \<IMicrosoftGraphGovernanceSchedule\>\]: governanceSchedule
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Duration \<TimeSpan?\>\]: 
        \[EndDateTime \<DateTime?\>\]: 
        \[StartDateTime \<DateTime?\>\]: 
        \[Type \<String\>\]: 
      \[Status \<IMicrosoftGraphGovernanceRoleAssignmentRequestStatus\>\]: governanceRoleAssignmentRequestStatus
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Status \<String\>\]: 
        \[StatusDetails \<IMicrosoftGraphKeyValue\[\]\>\]: 
          \[Key \<String\>\]: Key for the key-value pair.
          \[Value \<String\>\]: Value for the key-value pair.
        \[SubStatus \<String\>\]: 
      \[Subject \<IMicrosoftGraphGovernanceSubject\>\]: governanceSubject
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Id \<String\>\]: Read-only.
        \[DisplayName \<String\>\]: 
        \[Email \<String\>\]: 
        \[PrincipalName \<String\>\]: 
        \[Type \<String\>\]: 
      \[SubjectId \<String\>\]: 
      \[Type \<String\>\]: 
    \[RoleAssignments \<IMicrosoftGraphGovernanceRoleAssignment\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[AssignmentState \<String\>\]: 
      \[EndDateTime \<DateTime?\>\]: 
      \[ExternalId \<String\>\]: 
      \[LinkedEligibleRoleAssignment \<IMicrosoftGraphGovernanceRoleAssignment\>\]: governanceRoleAssignment
      \[LinkedEligibleRoleAssignmentId \<String\>\]: 
      \[MemberType \<String\>\]: 
      \[Resource \<IMicrosoftGraphGovernanceResource\>\]: governanceResource
      \[ResourceId \<String\>\]: 
      \[RoleDefinition \<IMicrosoftGraphGovernanceRoleDefinition\>\]: governanceRoleDefinition
      \[RoleDefinitionId \<String\>\]: 
      \[StartDateTime \<DateTime?\>\]: 
      \[Status \<String\>\]: 
      \[Subject \<IMicrosoftGraphGovernanceSubject\>\]: governanceSubject
      \[SubjectId \<String\>\]: 
    \[RoleDefinitions \<IMicrosoftGraphGovernanceRoleDefinition\[\]\>\]: 
    \[RoleSettings \<IMicrosoftGraphGovernanceRoleSetting\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[AdminEligibleSettings \<IMicrosoftGraphGovernanceRuleSetting\[\]\>\]: 
        \[RuleIdentifier \<String\>\]: 
        \[Setting \<String\>\]: 
      \[AdminMemberSettings \<IMicrosoftGraphGovernanceRuleSetting\[\]\>\]: 
      \[IsDefault \<Boolean?\>\]: 
      \[LastUpdatedBy \<String\>\]: 
      \[LastUpdatedDateTime \<DateTime?\>\]: 
      \[Resource \<IMicrosoftGraphGovernanceResource\>\]: governanceResource
      \[ResourceId \<String\>\]: 
      \[RoleDefinition \<IMicrosoftGraphGovernanceRoleDefinition\>\]: governanceRoleDefinition
      \[RoleDefinitionId \<String\>\]: 
      \[UserEligibleSettings \<IMicrosoftGraphGovernanceRuleSetting\[\]\>\]: 
      \[UserMemberSettings \<IMicrosoftGraphGovernanceRuleSetting\[\]\>\]: 
    \[Status \<String\>\]: 
    \[Type \<String\>\]: 
  \[ResourceId \<String\>\]: 
  \[RoleSetting \<IMicrosoftGraphGovernanceRoleSetting\>\]: governanceRoleSetting
  \[TemplateId \<String\>\]: 

SUBJECT \<IMicrosoftGraphGovernanceSubject\>: governanceSubject
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[DisplayName \<String\>\]: 
  \[Email \<String\>\]: 
  \[PrincipalName \<String\>\]: 
  \[Type \<String\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgprivilegedaccessroleassignment](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgprivilegedaccessroleassignment)
