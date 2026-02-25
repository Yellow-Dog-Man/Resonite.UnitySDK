
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VirtualShift
// Generated on: středa 25. února 2026 16:14:46
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VirtualShift")]
public partial class VirtualShift : global::FrooxEngine.VirtualKeyBase, global::FrooxEngine.IButtonPressReceiver

{
    public global::FrooxEngine.VirtualKeyboard Keyboard;
public global::System.Single HoldPressInterval;
public global::System.Boolean AlwaysHold;
public global::System.Double _lastPress;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Keyboard", Keyboard.ToResoniteReference(context));
members.Add("HoldPressInterval", HoldPressInterval.ToResoniteLinkField());
members.Add("AlwaysHold", AlwaysHold.ToResoniteLinkField());
members.Add("_lastPress", _lastPress.ToResoniteLinkField());
}

}
}
