---
external help file: Microsoft.Graph.Teams-help.xml
Module Name: Microsoft.Graph.Teams
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/new-mgteamscheduleopenshiftchangerequest
schema: 2.0.0
---

# New-MgTeamScheduleOpenShiftChangeRequest

## SYNOPSIS
Create new navigation property to openShiftChangeRequests for teams

## SYNTAX

### CreateExpanded (Default)
```
New-MgTeamScheduleOpenShiftChangeRequest -TeamId <String> [-AdditionalProperties <Hashtable>]
 [-AssignedTo <String>] [-CreatedBy <IMicrosoftGraphIdentitySet>] [-CreatedDateTime <DateTime>] [-Id <String>]
 [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-ManagerActionDateTime <DateTime>] [-ManagerActionMessage <String>] [-ManagerUserId <String>]
 [-OpenShiftId <String>] [-SenderDateTime <DateTime>] [-SenderMessage <String>] [-SenderUserId <String>]
 [-State <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgTeamScheduleOpenShiftChangeRequest -TeamId <String>
 -BodyParameter <IMicrosoftGraphOpenShiftChangeRequest> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgTeamScheduleOpenShiftChangeRequest -InputObject <ITeamsIdentity> [-AdditionalProperties <Hashtable>]
 [-AssignedTo <String>] [-CreatedBy <IMicrosoftGraphIdentitySet>] [-CreatedDateTime <DateTime>] [-Id <String>]
 [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-ManagerActionDateTime <DateTime>] [-ManagerActionMessage <String>] [-ManagerUserId <String>]
 [-OpenShiftId <String>] [-SenderDateTime <DateTime>] [-SenderMessage <String>] [-SenderUserId <String>]
 [-State <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgTeamScheduleOpenShiftChangeRequest -InputObject <ITeamsIdentity>
 -BodyParameter <IMicrosoftGraphOpenShiftChangeRequest> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to openShiftChangeRequests for teams

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

### -AssignedTo
scheduleChangeRequestActor

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

### -BodyParameter
openShiftChangeRequest
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphOpenShiftChangeRequest
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedBy
identitySet
To construct, see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: IMicrosoftGraphIdentitySet
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'

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
Type: ITeamsIdentity
Parameter Sets: CreateViaIdentityExpanded, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastModifiedBy
identitySet
To construct, see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: IMicrosoftGraphIdentitySet
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'

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

### -ManagerActionDateTime
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

### -ManagerActionMessage
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

### -ManagerUserId
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

### -OpenShiftId
ID for the open shift.

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

### -SenderDateTime
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

### -SenderMessage
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

### -SenderUserId
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

### -State
scheduleChangeState

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

### -TeamId
key: id of team

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOpenShiftChangeRequest
### Microsoft.Graph.PowerShell.Models.ITeamsIdentity
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOpenShiftChangeRequest
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphOpenShiftChangeRequest1\>: openShiftChangeRequest
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[AssignedTo \<String\>\]: scheduleChangeRequestActor
  \[ManagerActionDateTime \<DateTime?\>\]: 
  \[ManagerActionMessage \<String\>\]: 
  \[ManagerUserId \<String\>\]: 
  \[SenderDateTime \<DateTime?\>\]: 
  \[SenderMessage \<String\>\]: 
  \[SenderUserId \<String\>\]: 
  \[State \<String\>\]: scheduleChangeState
  \[CreatedDateTime \<DateTime?\>\]: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  \[LastModifiedBy \<IMicrosoftGraphIdentitySet\>\]: identitySet
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Application \<IMicrosoftGraphIdentity\>\]: identity
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      \[Id \<String\>\]: Unique identifier for the identity.
    \[Device \<IMicrosoftGraphIdentity\>\]: identity
    \[User \<IMicrosoftGraphIdentity\>\]: identity
  \[LastModifiedDateTime \<DateTime?\>\]: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  \[Id \<String\>\]: Read-only.
  \[OpenShiftId \<String\>\]: ID for the open shift.

INPUTOBJECT \<ITeamsIdentity\>: Identity Parameter
  \[ChannelId \<String\>\]: key: id of channel
  \[ChatId \<String\>\]: key: id of chat
  \[ChatMessageHostedContentId \<String\>\]: key: id of chatMessageHostedContent
  \[ChatMessageId \<String\>\]: key: id of chatMessage
  \[ChatMessageId1 \<String\>\]: key: id of chatMessage
  \[ConversationMemberId \<String\>\]: key: id of conversationMember
  \[GroupId \<String\>\]: key: id of group
  \[OfferShiftRequestId \<String\>\]: key: id of offerShiftRequest
  \[OpenShiftChangeRequestId \<String\>\]: key: id of openShiftChangeRequest
  \[OpenShiftId \<String\>\]: key: id of openShift
  \[SchedulingGroupId \<String\>\]: key: id of schedulingGroup
  \[ShiftId \<String\>\]: key: id of shift
  \[SwapShiftsChangeRequestId \<String\>\]: key: id of swapShiftsChangeRequest
  \[TeamId \<String\>\]: key: id of team
  \[TeamsAppDefinitionId \<String\>\]: key: id of teamsAppDefinition
  \[TeamsAppId \<String\>\]: key: id of teamsApp
  \[TeamsAppInstallationId \<String\>\]: key: id of teamsAppInstallation
  \[TeamsAsyncOperationId \<String\>\]: key: id of teamsAsyncOperation
  \[TeamsTabId \<String\>\]: key: id of teamsTab
  \[TimeCardId \<String\>\]: key: id of timeCard
  \[TimeOffId \<String\>\]: key: id of timeOff
  \[TimeOffReasonId \<String\>\]: key: id of timeOffReason
  \[TimeOffRequestId \<String\>\]: key: id of timeOffRequest
  \[UserId \<String\>\]: key: id of user
  \[UserScopeTeamsAppInstallationId \<String\>\]: key: id of userScopeTeamsAppInstallation
  \[WorkforceIntegrationId \<String\>\]: key: id of workforceIntegration

LASTMODIFIEDBY \<IMicrosoftGraphIdentitySet\>: identitySet
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Application \<IMicrosoftGraphIdentity\>\]: identity
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    \[Id \<String\>\]: Unique identifier for the identity.
  \[Device \<IMicrosoftGraphIdentity\>\]: identity
  \[User \<IMicrosoftGraphIdentity\>\]: identity

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/new-mgteamscheduleopenshiftchangerequest](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/new-mgteamscheduleopenshiftchangerequest)
