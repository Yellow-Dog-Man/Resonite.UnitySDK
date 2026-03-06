
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SteamIntegrationSettings
// Generated on: pátek 6. března 2026 14:19:11
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SteamIntegrationSettings")]
public partial class SteamIntegrationSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.SteamIntegrationSettings>

{
    public global::FrooxEngine.RichPresenceLevel RichPresence { get => RichPresence_Element.Data; set => RichPresence_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.RichPresenceLevel>, global::FrooxEngine.RichPresenceLevel> RichPresence_Element = new();
public global::System.Boolean SaveScreenshots { get => SaveScreenshots_Element.Data; set => SaveScreenshots_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SaveScreenshots_Element = new();
public global::System.Boolean ForceSteamVoiceOnRemotePlay { get => ForceSteamVoiceOnRemotePlay_Element.Data; set => ForceSteamVoiceOnRemotePlay_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ForceSteamVoiceOnRemotePlay_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RichPresence", RichPresence_Element.ToLinkField(context));
members.Add("SaveScreenshots", SaveScreenshots_Element.ToLinkField(context));
members.Add("ForceSteamVoiceOnRemotePlay", ForceSteamVoiceOnRemotePlay_Element.ToLinkField(context));
}
public  async System.Threading.Tasks.Task ResetToDefault(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "ResetToDefault";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
}


}
}
