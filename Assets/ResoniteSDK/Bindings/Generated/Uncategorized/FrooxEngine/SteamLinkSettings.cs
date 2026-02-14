
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SteamLinkSettings
// Generated on: sobota 14. února 2026 8:58:48
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SteamLinkSettings")]
public partial class SteamLinkSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.SteamLinkSettings>

{
    public global::FrooxEngine.SteamLinkSettings.OSC_Port OSC_DataPort;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OSC_DataPort", OSC_DataPort.ToResoniteLinkField());
}

}
}
