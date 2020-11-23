---
external help file: Microsoft.Graph.Identity.Governance-help.xml
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgprivilegedaccessrolesetting
schema: 2.0.0
---

# New-MgPrivilegedAccessRoleSetting

## SYNOPSIS
Create new navigation property to roleSettings for privilegedAccess

## SYNTAX

### CreateExpanded (Default)
```
New-MgPrivilegedAccessRoleSetting -PrivilegedAccessId <String> [-AdditionalProperties <Hashtable>]
 [-AdminEligibleSettings <IMicrosoftGraphGovernanceRuleSetting[]>]
 [-AdminMemberSettings <IMicrosoftGraphGovernanceRuleSetting[]>] [-Id <String>] [-IsDefault]
 [-LastUpdatedBy <String>] [-LastUpdatedDateTime <DateTime>] [-Resource <IMicrosoftGraphGovernanceResource>]
 [-ResourceId <String>] [-RoleDefinition <IMicrosoftGraphGovernanceRoleDefinition>]
 [-RoleDefinitionId <String>] [-UserEligibleSettings <IMicrosoftGraphGovernanceRuleSetting[]>]
 [-UserMemberSettings <IMicrosoftGraphGovernanceRuleSetting[]>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgPrivilegedAccessRoleSetting -PrivilegedAccessId <String>
 -BodyParameter <IMicrosoftGraphGovernanceRoleSetting> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgPrivilegedAccessRoleSetting -InputObject <IIdentityGovernanceIdentity>
 [-AdditionalProperties <Hashtable>] [-AdminEligibleSettings <IMicrosoftGraphGovernanceRuleSetting[]>]
 [-AdminMemberSettings <IMicrosoftGraphGovernanceRuleSetting[]>] [-Id <String>] [-IsDefault]
 [-LastUpdatedBy <String>] [-LastUpdatedDateTime <DateTime>] [-Resource <IMicrosoftGraphGovernanceResource>]
 [-ResourceId <String>] [-RoleDefinition <IMicrosoftGraphGovernanceRoleDefinition>]
 [-RoleDefinitionId <String>] [-UserEligibleSettings <IMicrosoftGraphGovernanceRuleSetting[]>]
 [-UserMemberSettings <IMicrosoftGraphGovernanceRuleSetting[]>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgPrivilegedAccessRoleSetting -InputObject <IIdentityGovernanceIdentity>
 -BodyParameter <IMicrosoftGraphGovernanceRoleSetting> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to roleSettings for privilegedAccess

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

### -AdminEligibleSettings
.
To construct, see NOTES section for ADMINELIGIBLESETTINGS properties and create a hash table.

```yaml
Type: IMicrosoftGraphGovernanceRuleSetting[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdminMemberSettings
.
To construct, see NOTES section for ADMINMEMBERSETTINGS properties and create a hash table.

```yaml
Type: IMicrosoftGraphGovernanceRuleSetting[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
governanceRoleSetting
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphGovernanceRoleSetting
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateViaIdentityExpanded, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsDefault
.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastUpdatedBy
.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastUpdatedDateTime
.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrivilegedAccessId
key: id of privilegedAccess

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

### -Resource
governanceResource
To construct, see NOTES section for RESOURCE properties and create a hash table.

```yaml
Type: IMicrosoftGraphGovernanceResource
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserEligibleSettings
.
To construct, see NOTES section for USERELIGIBLESETTINGS properties and create a hash table.

```yaml
Type: IMicrosoftGraphGovernanceRuleSetting[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserMemberSettings
.
To construct, see NOTES section for USERMEMBERSETTINGS properties and create a hash table.

```yaml
Type: IMicrosoftGraphGovernanceRuleSetting[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGovernanceRoleSetting
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGovernanceRoleSetting
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

ADMINELIGIBLESETTINGS \<IMicrosoftGraphGovernanceRuleSetting\[\]\>: .
  \[RuleIdentifier \<String\>\]: 
  \[Setting \<String\>\]: 

ADMINMEMBERSETTINGS \<IMicrosoftGraphGovernanceRuleSetting\[\]\>: .
  \[RuleIdentifier \<String\>\]: 
  \[Setting \<String\>\]: 

BODYPARAMETER \<IMicrosoftGraphGovernanceRoleSetting\>: governanceRoleSetting
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
  \[ResourceId \<String\>\]: 
  \[RoleDefinition \<IMicrosoftGraphGovernanceRoleDefinition\>\]: governanceRoleDefinition
  \[RoleDefinitionId \<String\>\]: 
  \[UserEligibleSettings \<IMicrosoftGraphGovernanceRuleSetting\[\]\>\]: 
  \[UserMemberSettings \<IMicrosoftGraphGovernanceRuleSetting\[\]\>\]: 

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

USERELIGIBLESETTINGS \<IMicrosoftGraphGovernanceRuleSetting\[\]\>: .
  \[RuleIdentifier \<String\>\]: 
  \[Setting \<String\>\]: 

USERMEMBERSETTINGS \<IMicrosoftGraphGovernanceRuleSetting\[\]\>: .
  \[RuleIdentifier \<String\>\]: 
  \[Setting \<String\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgprivilegedaccessrolesetting](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgprivilegedaccessrolesetting)
