
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyFeatureSettings
// Generated on: sobota 14. února 2026 8:58:45
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyFeatureSettings")]
public partial class LegacyFeatureSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.LegacyFeatureSettings>

{
    public global::System.Boolean UseLegacyGripEquip;
public global::System.Boolean UseLegacyWorldSwitcher;
public global::System.Boolean UseLegacyInventorySessionShortcuts;
public global::System.Boolean SuppressFeetSimulation;
public global::System.Boolean PreserveLegacyReverbZoneHandling;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseLegacyGripEquip", UseLegacyGripEquip.ToResoniteLinkField());
members.Add("UseLegacyWorldSwitcher", UseLegacyWorldSwitcher.ToResoniteLinkField());
members.Add("UseLegacyInventorySessionShortcuts", UseLegacyInventorySessionShortcuts.ToResoniteLinkField());
members.Add("SuppressFeetSimulation", SuppressFeetSimulation.ToResoniteLinkField());
members.Add("PreserveLegacyReverbZoneHandling", PreserveLegacyReverbZoneHandling.ToResoniteLinkField());
}

}
}
