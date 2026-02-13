
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NamePlateSettings
// Generated on: pátek 13. února 2026 23:23:16
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NamePlateSettings")]
public partial class NamePlateSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.NamePlateSettings>

{
    public global::FrooxEngine.NameplateVisibility NameplateVisibility;
public global::System.Boolean UseCustomNameplates;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("NameplateVisibility", NameplateVisibility.ToResoniteLinkField());
members.Add("UseCustomNameplates", UseCustomNameplates.ToResoniteLinkField());
}

}
}
