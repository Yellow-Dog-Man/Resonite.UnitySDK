
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LabelContentDriver
// Generated on: čtvrtek 26. února 2026 12:28:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LabelContentDriver")]
public partial class LabelContentDriver : global::FrooxEngine.Component

{
    public global::System.Boolean AutoUpdate { get => AutoUpdate_Element.Data; set => AutoUpdate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AutoUpdate_Element = new();
public UnityEngine.Vector2 Padding { get => Padding_Element.Data; set => Padding_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> Padding_Element = new();
public global::System.Single BaseWidth { get => BaseWidth_Element.Data; set => BaseWidth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BaseWidth_Element = new();
public global::FrooxEngine.RootSpace ContentOrientSpace = new();
public global::System.Boolean OrientAtLocalUser { get => OrientAtLocalUser_Element.Data; set => OrientAtLocalUser_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OrientAtLocalUser_Element = new();
public global::FrooxEngine.Slot _contentRoot { get => _contentRoot_Element.Data; set => _contentRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _contentRoot_Element = new();
public global::FrooxEngine.Slot _targetPoint { get => _targetPoint_Element.Data; set => _targetPoint_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _targetPoint_Element = new();
public UnityEngine.Quaternion _contentRotation { get => _contentRotation_Element.Data; set => _contentRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> _contentRotation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _contentRotationDrive { get => _contentRotationDrive_Element.Data; set => _contentRotationDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _contentRotationDrive_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _labelPosition { get => _labelPosition_Element.Data; set => _labelPosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _labelPosition_Element = new();
public global::FrooxEngine.IField<global::System.Single> _labelWidth { get => _labelWidth_Element.Data; set => _labelWidth_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _labelWidth_Element = new();
public global::FrooxEngine.IField<global::System.Single> _lineWidth { get => _lineWidth_Element.Data; set => _lineWidth_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _lineWidth_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _labelRotation { get => _labelRotation_Element.Data; set => _labelRotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _labelRotation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _pointPosition { get => _pointPosition_Element.Data; set => _pointPosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _pointPosition_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AutoUpdate", AutoUpdate_Element.ToLinkField(context));
members.Add("Padding", Padding_Element.ToLinkField(context));
members.Add("BaseWidth", BaseWidth_Element.ToLinkField(context));
members.Add("ContentOrientSpace", ContentOrientSpace.ToLinkSyncObject(context));
members.Add("OrientAtLocalUser", OrientAtLocalUser_Element.ToLinkField(context));
members.Add("_contentRoot", _contentRoot_Element.ToLinkReference(context));
members.Add("_targetPoint", _targetPoint_Element.ToLinkReference(context));
members.Add("_contentRotation", _contentRotation_Element.ToLinkField(context));
members.Add("_contentRotationDrive", _contentRotationDrive_Element.ToLinkReference(context));
members.Add("_labelPosition", _labelPosition_Element.ToLinkReference(context));
members.Add("_labelWidth", _labelWidth_Element.ToLinkReference(context));
members.Add("_lineWidth", _lineWidth_Element.ToLinkReference(context));
members.Add("_labelRotation", _labelRotation_Element.ToLinkReference(context));
members.Add("_pointPosition", _pointPosition_Element.ToLinkReference(context));
}

}
}
