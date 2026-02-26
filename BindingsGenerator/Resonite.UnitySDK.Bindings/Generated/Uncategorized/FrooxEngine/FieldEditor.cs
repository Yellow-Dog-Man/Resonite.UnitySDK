
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FieldEditor
// Generated on: čtvrtek 26. února 2026 10:04:44
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FieldEditor")]
public partial class FieldEditor : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField _targetField { get => _targetField_Element.Data; set => _targetField_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField>, global::FrooxEngine.IField> _targetField_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.TextEditor>, global::FrooxEngine.TextEditor, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.TextEditor>, global::FrooxEngine.TextEditor>> _textEditors = new();
public global::SyncFieldList<global::FrooxEngine.SyncList<global::FrooxEngine.FieldDrive<global::System.String>>, global::FrooxEngine.IField<global::System.String>, Field<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>>> _textDrives = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_targetField", _targetField_Element.Data.ToResoniteReference(context));
members.Add("_textEditors", new ResoniteLink.SyncList()
{
    Elements = _textEditors.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("_textDrives", new ResoniteLink.SyncList()
{
    Elements = _textDrives.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
}

}
}
