
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ColorMemberEditorBase
// Generated on: čtvrtek 26. února 2026 12:28:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ColorMemberEditorBase")]
public abstract partial class ColorMemberEditorBase : global::FrooxEngine.MemberEditor

{
    public global::System.Boolean Labels { get => Labels_Element.Data; set => Labels_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Labels_Element = new();
public global::System.Boolean Vertical { get => Vertical_Element.Data; set => Vertical_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Vertical_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _colorDrive { get => _colorDrive_Element.Data; set => _colorDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _colorDrive_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _colorDriveNoAlpha { get => _colorDriveNoAlpha_Element.Data; set => _colorDriveNoAlpha_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _colorDriveNoAlpha_Element = new();
public global::FrooxEngine.ColorDialogInterface _colorDialog { get => _colorDialog_Element.Data; set => _colorDialog_Element.Data = value; }
public Field<global::FrooxEngine.SlotCleanupRef<global::FrooxEngine.ColorDialogInterface>, global::FrooxEngine.ColorDialogInterface> _colorDialog_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Labels", Labels_Element.ToLinkField(context));
members.Add("Vertical", Vertical_Element.ToLinkField(context));
members.Add("_colorDrive", _colorDrive_Element.ToLinkReference(context));
members.Add("_colorDriveNoAlpha", _colorDriveNoAlpha_Element.ToLinkReference(context));
members.Add("_colorDialog", _colorDialog_Element.ToLinkReference(context));
}

}
}
