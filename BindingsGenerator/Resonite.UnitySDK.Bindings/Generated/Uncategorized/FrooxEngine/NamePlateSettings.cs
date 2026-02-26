
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NamePlateSettings
// Generated on: čtvrtek 26. února 2026 15:09:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NamePlateSettings")]
public partial class NamePlateSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.NamePlateSettings>

{
    public global::FrooxEngine.NameplateVisibility NameplateVisibility { get => NameplateVisibility_Element.Data; set => NameplateVisibility_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.NameplateVisibility>, global::FrooxEngine.NameplateVisibility> NameplateVisibility_Element = new();
public global::System.Boolean UseCustomNameplates { get => UseCustomNameplates_Element.Data; set => UseCustomNameplates_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseCustomNameplates_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("NameplateVisibility", NameplateVisibility_Element.ToLinkField(context));
members.Add("UseCustomNameplates", UseCustomNameplates_Element.ToLinkField(context));
}

}
}
