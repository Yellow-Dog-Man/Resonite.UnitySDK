
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GamepadSettings
// Generated on: čtvrtek 26. února 2026 12:28:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GamepadSettings")]
public partial class GamepadSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.GamepadSettings>

{
    public global::System.Single ThumbstickLookSpeed { get => ThumbstickLookSpeed_Element.Data; set => ThumbstickLookSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ThumbstickLookSpeed_Element = new();
public global::System.Single ThumbstickLookExponent { get => ThumbstickLookExponent_Element.Data; set => ThumbstickLookExponent_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ThumbstickLookExponent_Element = new();
public global::System.Boolean UseGamepadWhenUnfocused { get => UseGamepadWhenUnfocused_Element.Data; set => UseGamepadWhenUnfocused_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseGamepadWhenUnfocused_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ThumbstickLookSpeed", ThumbstickLookSpeed_Element.ToLinkField(context));
members.Add("ThumbstickLookExponent", ThumbstickLookExponent_Element.ToLinkField(context));
members.Add("UseGamepadWhenUnfocused", UseGamepadWhenUnfocused_Element.ToLinkField(context));
}

}
}
