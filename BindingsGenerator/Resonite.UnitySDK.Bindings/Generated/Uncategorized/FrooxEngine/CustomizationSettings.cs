
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CustomizationSettings
// Generated on: čtvrtek 26. února 2026 12:28:10
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CustomizationSettings")]
public partial class CustomizationSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.CustomizationSettings>

{
    public global::System.Boolean UserInterfaceEditMode { get => UserInterfaceEditMode_Element.Data; set => UserInterfaceEditMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UserInterfaceEditMode_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UserInterfaceEditMode", UserInterfaceEditMode_Element.ToLinkField(context));
}

}
}
