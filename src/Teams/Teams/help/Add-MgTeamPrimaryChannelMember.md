---
external help file: Microsoft.Graph.Teams-help.xml
Module Name: Microsoft.Graph.Teams
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/add-mgteamprimarychannelmember
schema: 2.0.0
---

# Add-MgTeamPrimaryChannelMember

## SYNOPSIS
Invoke action add

## SYNTAX

### AddExpanded (Default)
```
Add-MgTeamPrimaryChannelMember -TeamId <String> [-AdditionalProperties <Hashtable>]
 [-Values <IMicrosoftGraphConversationMember[]>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Add
```
Add-MgTeamPrimaryChannelMember -TeamId <String>
 -BodyParameter <IPathsU53MjcTeamsTeamIdPrimarychannelMembersMicrosoftGraphAddPostRequestbodyContentApplicationJsonSchema>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### AddViaIdentityExpanded
```
Add-MgTeamPrimaryChannelMember -InputObject <ITeamsIdentity> [-AdditionalProperties <Hashtable>]
 [-Values <IMicrosoftGraphConversationMember[]>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### AddViaIdentity
```
Add-MgTeamPrimaryChannelMember -InputObject <ITeamsIdentity>
 -BodyParameter <IPathsU53MjcTeamsTeamIdPrimarychannelMembersMicrosoftGraphAddPostRequestbodyContentApplicationJsonSchema>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Invoke action add

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
Parameter Sets: AddExpanded, AddViaIdentityExpanded
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
Type: IPathsU53MjcTeamsTeamIdPrimarychannelMembersMicrosoftGraphAddPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Add, AddViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: ITeamsIdentity
Parameter Sets: AddViaIdentityExpanded, AddViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -TeamId
key: id of team

```yaml
Type: String
Parameter Sets: AddExpanded, Add
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Values
.
To construct, see NOTES section for VALUES properties and create a hash table.

```yaml
Type: IMicrosoftGraphConversationMember[]
Parameter Sets: AddExpanded, AddViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IPathsU53MjcTeamsTeamIdPrimarychannelMembersMicrosoftGraphAddPostRequestbodyContentApplicationJsonSchema
### Microsoft.Graph.PowerShell.Models.ITeamsIdentity
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphActionResultPart
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IPathsU53MjcTeamsTeamIdPrimarychannelMembersMicrosoftGraphAddPostRequestbodyContentApplicationJsonSchema\>: .
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Values \<IMicrosoftGraphConversationMember\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[DisplayName \<String\>\]: The display name of the user.
    \[Roles \<String\[\]\>\]: The roles for that user.

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

VALUES \<IMicrosoftGraphConversationMember\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[DisplayName \<String\>\]: The display name of the user.
  \[Roles \<String\[\]\>\]: The roles for that user.

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/add-mgteamprimarychannelmember](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/add-mgteamprimarychannelmember)
