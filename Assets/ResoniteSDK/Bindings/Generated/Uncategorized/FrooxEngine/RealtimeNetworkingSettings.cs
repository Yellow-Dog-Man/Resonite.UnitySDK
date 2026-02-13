
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RealtimeNetworkingSettings
// Generated on: pátek 13. února 2026 23:23:17
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("DisableLAN", DisableLAN.ToResoniteLinkField());
members.Add("PreferSteamNetworking", PreferSteamNetworking.ToResoniteLinkField());
members.Add("PreferTCP", PreferTCP.ToResoniteLinkField());
members.Add("LNL_WindowSize", LNL_WindowSize.ToResoniteLinkField());
}

}
}
