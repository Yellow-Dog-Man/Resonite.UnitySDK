
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RealtimeNetworkingSettings
// Generated on: pátek 6. března 2026 14:19:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RealtimeNetworkingSettings")]
public partial class RealtimeNetworkingSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.RealtimeNetworkingSettings>

{
    public global::System.Boolean DisableLAN { get => DisableLAN_Element.Data; set => DisableLAN_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DisableLAN_Element = new();
public global::System.Boolean PreferSteamNetworking { get => PreferSteamNetworking_Element.Data; set => PreferSteamNetworking_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PreferSteamNetworking_Element = new();
public global::System.Boolean PreferTCP { get => PreferTCP_Element.Data; set => PreferTCP_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PreferTCP_Element = new();
public global::System.Int32 LNL_WindowSize { get => LNL_WindowSize_Element.Data; set => LNL_WindowSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> LNL_WindowSize_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DisableLAN", DisableLAN_Element.ToLinkField(context));
members.Add("PreferSteamNetworking", PreferSteamNetworking_Element.ToLinkField(context));
members.Add("PreferTCP", PreferTCP_Element.ToLinkField(context));
members.Add("LNL_WindowSize", LNL_WindowSize_Element.ToLinkField(context));
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
