
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextGizmo
// Generated on: čtvrtek 26. února 2026 12:28:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextGizmo")]
public partial class TextGizmo : global::FrooxEngine.Component, global::FrooxEngine.IComponentGizmo

{
    public global::FrooxEngine.TextRenderer _target { get => _target_Element.Data; set => _target_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> _target_Element = new();
public global::FrooxEngine.TextEditor _editor { get => _editor_Element.Data; set => _editor_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.TextEditor>, global::FrooxEngine.TextEditor> _editor_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _editIconPosition { get => _editIconPosition_Element.Data; set => _editIconPosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _editIconPosition_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _editIconScale { get => _editIconScale_Element.Data; set => _editIconScale_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _editIconScale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_target", _target_Element.ToLinkReference(context));
members.Add("_editor", _editor_Element.ToLinkReference(context));
members.Add("_editIconPosition", _editIconPosition_Element.ToLinkReference(context));
members.Add("_editIconScale", _editIconScale_Element.ToLinkReference(context));
}

}
}
