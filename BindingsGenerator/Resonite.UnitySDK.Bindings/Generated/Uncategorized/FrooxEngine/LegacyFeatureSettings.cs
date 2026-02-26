
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyFeatureSettings
// Generated on: čtvrtek 26. února 2026 15:09:12
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::System.Boolean UseLegacyGripEquip { get => UseLegacyGripEquip_Element.Data; set => UseLegacyGripEquip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseLegacyGripEquip_Element = new();
public global::System.Boolean UseLegacyWorldSwitcher { get => UseLegacyWorldSwitcher_Element.Data; set => UseLegacyWorldSwitcher_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseLegacyWorldSwitcher_Element = new();
public global::System.Boolean UseLegacyInventorySessionShortcuts { get => UseLegacyInventorySessionShortcuts_Element.Data; set => UseLegacyInventorySessionShortcuts_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseLegacyInventorySessionShortcuts_Element = new();
public global::System.Boolean SuppressFeetSimulation { get => SuppressFeetSimulation_Element.Data; set => SuppressFeetSimulation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SuppressFeetSimulation_Element = new();
public global::System.Boolean PreserveLegacyReverbZoneHandling { get => PreserveLegacyReverbZoneHandling_Element.Data; set => PreserveLegacyReverbZoneHandling_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PreserveLegacyReverbZoneHandling_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseLegacyGripEquip", UseLegacyGripEquip_Element.ToLinkField(context));
members.Add("UseLegacyWorldSwitcher", UseLegacyWorldSwitcher_Element.ToLinkField(context));
members.Add("UseLegacyInventorySessionShortcuts", UseLegacyInventorySessionShortcuts_Element.ToLinkField(context));
members.Add("SuppressFeetSimulation", SuppressFeetSimulation_Element.ToLinkField(context));
members.Add("PreserveLegacyReverbZoneHandling", PreserveLegacyReverbZoneHandling_Element.ToLinkField(context));
}

}
}
