
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VirtualShiftColorDriver
// Generated on: čtvrtek 26. února 2026 12:28:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VirtualShiftColorDriver")]
public partial class VirtualShiftColorDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.VirtualKeyboard Keyboard { get => Keyboard_Element.Data; set => Keyboard_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.VirtualKeyboard>, global::FrooxEngine.VirtualKeyboard> Keyboard_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> ColorTarget { get => ColorTarget_Element.Data; set => ColorTarget_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.ColorX>>, global::FrooxEngine.IField<UnityEngine.ColorX>> ColorTarget_Element = new();
public UnityEngine.ColorX NormalColor { get => NormalColor_Element.Data; set => NormalColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> NormalColor_Element = new();
public UnityEngine.ColorX ShiftColor { get => ShiftColor_Element.Data; set => ShiftColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> ShiftColor_Element = new();
public UnityEngine.ColorX HoldColor { get => HoldColor_Element.Data; set => HoldColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> HoldColor_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Keyboard", Keyboard_Element.ToLinkReference(context));
members.Add("ColorTarget", ColorTarget_Element.ToLinkReference(context));
members.Add("NormalColor", NormalColor_Element.ToLinkField(context));
members.Add("ShiftColor", ShiftColor_Element.ToLinkField(context));
members.Add("HoldColor", HoldColor_Element.ToLinkField(context));
}

}
}
