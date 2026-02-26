
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonEditColorX
// Generated on: čtvrtek 26. února 2026 10:03:37
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonEditColorX")]
public partial class ButtonEditColorX : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::FrooxEngine.IField<UnityEngine.ColorX> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.ColorX>>, global::FrooxEngine.IField<UnityEngine.ColorX>> Target_Element = new();
public global::FrooxEngine.ColorDialogInterface _colorPicker { get => _colorPicker_Element.Data; set => _colorPicker_Element.Data = value; }
public Field<global::FrooxEngine.SlotCleanupRef<global::FrooxEngine.ColorDialogInterface>, global::FrooxEngine.ColorDialogInterface> _colorPicker_Element = new();
public global::System.Boolean Continuous { get => Continuous_Element.Data; set => Continuous_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Continuous_Element = new();
public global::System.Boolean Alpha { get => Alpha_Element.Data; set => Alpha_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Alpha_Element = new();
public global::System.Boolean HDR { get => HDR_Element.Data; set => HDR_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> HDR_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.Data.ToResoniteReference(context));
members.Add("_colorPicker", _colorPicker_Element.Data.ToResoniteReference(context));
members.Add("Continuous", Continuous_Element.Data.ToResoniteLinkField());
members.Add("Alpha", Alpha_Element.Data.ToResoniteLinkField());
members.Add("HDR", HDR_Element.Data.ToResoniteLinkField());
}

}
}
