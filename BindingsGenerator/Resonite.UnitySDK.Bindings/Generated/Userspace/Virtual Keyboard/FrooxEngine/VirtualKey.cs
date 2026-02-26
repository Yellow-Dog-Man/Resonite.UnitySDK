
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VirtualKey
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VirtualKey")]
public partial class VirtualKey : global::FrooxEngine.VirtualKeyBase, global::FrooxEngine.IButtonPressReceiver

{
    public global::Renderite.Shared.Key TargetKey { get => TargetKey_Element.Data; set => TargetKey_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.Key>, global::Renderite.Shared.Key> TargetKey_Element = new();
public global::System.String AppendString { get => AppendString_Element.Data; set => AppendString_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> AppendString_Element = new();
public global::Renderite.Shared.Key ShiftTargetKey { get => ShiftTargetKey_Element.Data; set => ShiftTargetKey_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.Key>, global::Renderite.Shared.Key> ShiftTargetKey_Element = new();
public global::System.String ShiftAppendString { get => ShiftAppendString_Element.Data; set => ShiftAppendString_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> ShiftAppendString_Element = new();
public global::System.Boolean IgnoreShift { get => IgnoreShift_Element.Data; set => IgnoreShift_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IgnoreShift_Element = new();
public global::FrooxEngine.VirtualModifierKey ModifierKey { get => ModifierKey_Element.Data; set => ModifierKey_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.VirtualModifierKey>, global::FrooxEngine.VirtualModifierKey> ModifierKey_Element = new();
public global::Renderite.Shared.Key ModifiedTargetKey { get => ModifiedTargetKey_Element.Data; set => ModifiedTargetKey_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.Key>, global::Renderite.Shared.Key> ModifiedTargetKey_Element = new();
public global::System.String ModifiedAppendString { get => ModifiedAppendString_Element.Data; set => ModifiedAppendString_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> ModifiedAppendString_Element = new();
public global::FrooxEngine.VirtualKeyboard Keyboard { get => Keyboard_Element.Data; set => Keyboard_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.VirtualKeyboard>, global::FrooxEngine.VirtualKeyboard> Keyboard_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetKey", TargetKey_Element.Data.ToResoniteLinkField());
members.Add("AppendString", AppendString_Element.Data.ToResoniteLinkField());
members.Add("ShiftTargetKey", ShiftTargetKey_Element.Data.ToResoniteLinkField());
members.Add("ShiftAppendString", ShiftAppendString_Element.Data.ToResoniteLinkField());
members.Add("IgnoreShift", IgnoreShift_Element.Data.ToResoniteLinkField());
members.Add("ModifierKey", ModifierKey_Element.Data.ToResoniteReference(context));
members.Add("ModifiedTargetKey", ModifiedTargetKey_Element.Data.ToResoniteLinkField());
members.Add("ModifiedAppendString", ModifiedAppendString_Element.Data.ToResoniteLinkField());
members.Add("Keyboard", Keyboard_Element.Data.ToResoniteReference(context));
}

}
}
