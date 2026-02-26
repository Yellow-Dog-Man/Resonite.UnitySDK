
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VirtualShift
// Generated on: čtvrtek 26. února 2026 10:04:50
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
    public global::FrooxEngine.VirtualKeyboard Keyboard { get => Keyboard_Element.Data; set => Keyboard_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.VirtualKeyboard>, global::FrooxEngine.VirtualKeyboard> Keyboard_Element = new();
public global::System.Single HoldPressInterval { get => HoldPressInterval_Element.Data; set => HoldPressInterval_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HoldPressInterval_Element = new();
public global::System.Boolean AlwaysHold { get => AlwaysHold_Element.Data; set => AlwaysHold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AlwaysHold_Element = new();
public global::System.Double _lastPress { get => _lastPress_Element.Data; set => _lastPress_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Double>, global::System.Double> _lastPress_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Keyboard", Keyboard_Element.Data.ToResoniteReference(context));
members.Add("HoldPressInterval", HoldPressInterval_Element.Data.ToResoniteLinkField());
members.Add("AlwaysHold", AlwaysHold_Element.Data.ToResoniteLinkField());
members.Add("_lastPress", _lastPress_Element.Data.ToResoniteLinkField());
}

}
}
