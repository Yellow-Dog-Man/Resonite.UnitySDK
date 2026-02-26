
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ColorTool
// Generated on: čtvrtek 26. února 2026 12:28:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ColorTool")]
public partial class ColorTool : global::FrooxEngine.Tool

{
    public UnityEngine.ColorX Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color_Element = new();
public global::System.Boolean EnsureUniqueMaterial { get => EnsureUniqueMaterial_Element.Data; set => EnsureUniqueMaterial_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EnsureUniqueMaterial_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncList<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>>, global::FrooxEngine.IField<UnityEngine.ColorX>, Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>>> ColorIndicators = new();
public global::FrooxEngine.ColorDialogInterface _colorDialog { get => _colorDialog_Element.Data; set => _colorDialog_Element.Data = value; }
public Field<global::FrooxEngine.SlotCleanupRef<global::FrooxEngine.ColorDialogInterface>, global::FrooxEngine.ColorDialogInterface> _colorDialog_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Color", Color_Element.ToLinkField(context));
members.Add("EnsureUniqueMaterial", EnsureUniqueMaterial_Element.ToLinkField(context));
members.Add("ColorIndicators", ColorIndicators.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("_colorDialog", _colorDialog_Element.ToLinkReference(context));
}

}
}
