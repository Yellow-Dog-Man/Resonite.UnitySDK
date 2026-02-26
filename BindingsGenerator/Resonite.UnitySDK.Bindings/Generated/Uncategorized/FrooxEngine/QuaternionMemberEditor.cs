
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.QuaternionMemberEditor
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.QuaternionMemberEditor")]
public partial class QuaternionMemberEditor : global::FrooxEngine.MemberEditor

{
    public global::System.Boolean Vertical { get => Vertical_Element.Data; set => Vertical_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Vertical_Element = new();
public global::FrooxEngine.TextEditor _xEditor { get => _xEditor_Element.Data; set => _xEditor_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.TextEditor>, global::FrooxEngine.TextEditor> _xEditor_Element = new();
public global::FrooxEngine.TextEditor _yEditor { get => _yEditor_Element.Data; set => _yEditor_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.TextEditor>, global::FrooxEngine.TextEditor> _yEditor_Element = new();
public global::FrooxEngine.TextEditor _zEditor { get => _zEditor_Element.Data; set => _zEditor_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.TextEditor>, global::FrooxEngine.TextEditor> _zEditor_Element = new();
public global::FrooxEngine.IField<global::System.String> _xDrive { get => _xDrive_Element.Data; set => _xDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> _xDrive_Element = new();
public global::FrooxEngine.IField<global::System.String> _yDrive { get => _yDrive_Element.Data; set => _yDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> _yDrive_Element = new();
public global::FrooxEngine.IField<global::System.String> _zDrive { get => _zDrive_Element.Data; set => _zDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> _zDrive_Element = new();
public global::FrooxEngine.UIX.Button _xButton { get => _xButton_Element.Data; set => _xButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _xButton_Element = new();
public global::FrooxEngine.UIX.Button _yButton { get => _yButton_Element.Data; set => _yButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _yButton_Element = new();
public global::FrooxEngine.UIX.Button _zButton { get => _zButton_Element.Data; set => _zButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _zButton_Element = new();
public global::System.Nullable<UnityEngine.Vector3Double> _editingValue { get => _editingValue_Element.Data; set => _editingValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector3Double>>, global::System.Nullable<UnityEngine.Vector3Double>> _editingValue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Vertical", Vertical_Element.ToLinkField(context));
members.Add("_xEditor", _xEditor_Element.ToLinkReference(context));
members.Add("_yEditor", _yEditor_Element.ToLinkReference(context));
members.Add("_zEditor", _zEditor_Element.ToLinkReference(context));
members.Add("_xDrive", _xDrive_Element.ToLinkReference(context));
members.Add("_yDrive", _yDrive_Element.ToLinkReference(context));
members.Add("_zDrive", _zDrive_Element.ToLinkReference(context));
members.Add("_xButton", _xButton_Element.ToLinkReference(context));
members.Add("_yButton", _yButton_Element.ToLinkReference(context));
members.Add("_zButton", _zButton_Element.ToLinkReference(context));
members.Add("_editingValue", _editingValue_Element.ToLinkField(context));
}

}
}
