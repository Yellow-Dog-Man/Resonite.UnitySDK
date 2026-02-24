
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NamePlateSettings
// Generated on: úterý 24. února 2026 18:20:26
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NamePlateSettings")]
public partial class NamePlateSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.NamePlateSettings>

{
    public global::FrooxEngine.NameplateVisibility NameplateVisibility;
public global::System.Boolean UseCustomNameplates;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("NameplateVisibility", NameplateVisibility.ToResoniteLinkField());
members.Add("UseCustomNameplates", UseCustomNameplates.ToResoniteLinkField());
}

}
}
