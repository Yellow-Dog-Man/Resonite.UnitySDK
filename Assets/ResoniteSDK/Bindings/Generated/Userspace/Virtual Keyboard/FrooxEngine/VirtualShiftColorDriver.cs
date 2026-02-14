
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VirtualShiftColorDriver
// Generated on: sobota 14. února 2026 8:58:50
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VirtualShiftColorDriver")]
public partial class VirtualShiftColorDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.VirtualKeyboard Keyboard;
public global::FrooxEngine.IField<UnityEngine.ColorX> ColorTarget;
public UnityEngine.ColorX NormalColor;
public UnityEngine.ColorX ShiftColor;
public UnityEngine.ColorX HoldColor;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Keyboard", Keyboard.ToResoniteReference(context));
members.Add("ColorTarget", ColorTarget.ToResoniteReference(context));
members.Add("NormalColor", NormalColor.ToResoniteLinkField());
members.Add("ShiftColor", ShiftColor.ToResoniteLinkField());
members.Add("HoldColor", HoldColor.ToResoniteLinkField());
}

}
}
