
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RealtimeNetworkingSettings
// Generated on: středa 25. února 2026 16:14:42
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
    public global::System.Boolean DisableLAN;
public global::System.Boolean PreferSteamNetworking;
public global::System.Boolean PreferTCP;
public global::System.Int32 LNL_WindowSize;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DisableLAN", DisableLAN.ToResoniteLinkField());
members.Add("PreferSteamNetworking", PreferSteamNetworking.ToResoniteLinkField());
members.Add("PreferTCP", PreferTCP.ToResoniteLinkField());
members.Add("LNL_WindowSize", LNL_WindowSize.ToResoniteLinkField());
}

}
}
