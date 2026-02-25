
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GamepadSettings
// Generated on: středa 25. února 2026 16:14:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GamepadSettings")]
public partial class GamepadSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.GamepadSettings>

{
    public global::System.Single ThumbstickLookSpeed;
public global::System.Single ThumbstickLookExponent;
public global::System.Boolean UseGamepadWhenUnfocused;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ThumbstickLookSpeed", ThumbstickLookSpeed.ToResoniteLinkField());
members.Add("ThumbstickLookExponent", ThumbstickLookExponent.ToResoniteLinkField());
members.Add("UseGamepadWhenUnfocused", UseGamepadWhenUnfocused.ToResoniteLinkField());
}

}
}
