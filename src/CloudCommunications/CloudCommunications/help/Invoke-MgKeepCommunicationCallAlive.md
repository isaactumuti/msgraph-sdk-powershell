---
external help file: Microsoft.Graph.CloudCommunications-help.xml
Module Name: Microsoft.Graph.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.cloudcommunications/invoke-mgkeepcommunicationcallalive
schema: 2.0.0
---

# Invoke-MgKeepCommunicationCallAlive

## SYNOPSIS
Invoke action keepAlive

## SYNTAX

### Keep (Default)
```
Invoke-MgKeepCommunicationCallAlive -CallId <String> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### KeepViaIdentity
```
Invoke-MgKeepCommunicationCallAlive -InputObject <ICloudCommunicationsIdentity> [-PassThru] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Invoke action keepAlive

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

### -CallId
key: id of call

```yaml
Type: String
Parameter Sets: Keep
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
Type: ICloudCommunicationsIdentity
Parameter Sets: KeepViaIdentity
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

### Microsoft.Graph.PowerShell.Models.ICloudCommunicationsIdentity
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT \<ICloudCommunicationsIdentity\>: Identity Parameter
  \[AudioRoutingGroupId \<String\>\]: key: id of audioRoutingGroup
  \[CallId \<String\>\]: key: id of call
  \[CallRecordId \<String\>\]: key: id of callRecord
  \[CommsOperationId \<String\>\]: key: id of commsOperation
  \[OnlineMeetingId \<String\>\]: key: id of onlineMeeting
  \[ParticipantId \<String\>\]: key: id of participant
  \[PresenceId \<String\>\]: key: id of presence
  \[SessionId \<String\>\]: key: id of session
  \[UserId \<String\>\]: key: id of user

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.cloudcommunications/invoke-mgkeepcommunicationcallalive](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.cloudcommunications/invoke-mgkeepcommunicationcallalive)
