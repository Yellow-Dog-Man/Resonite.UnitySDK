
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AxisRotationGizmo
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AxisRotationGizmo")]
public partial class AxisRotationGizmo : global::FrooxEngine.Gizmo

{
    public UnityEngine.Vector3 Axis { get => Axis_Element.Data; set => Axis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Axis_Element = new();
public global::FrooxEngine.RootSpace AxisSpace = new();
public global::FrooxEngine.RootSpace RotationSpace = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> TargetRotation { get => TargetRotation_Element.Data; set => TargetRotation_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<UnityEngine.Quaternion>>, global::FrooxEngine.IField<UnityEngine.Quaternion>> TargetRotation_Element = new();
public global::FrooxEngine.IField<global::System.Single> TargetValue { get => TargetValue_Element.Data; set => TargetValue_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> TargetValue_Element = new();
public global::System.Single CircleRadius { get => CircleRadius_Element.Data; set => CircleRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CircleRadius_Element = new();
public global::System.Single CircleThickness { get => CircleThickness_Element.Data; set => CircleThickness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CircleThickness_Element = new();
public global::FrooxEngine.Slot _visualRoot { get => _visualRoot_Element.Data; set => _visualRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _visualRoot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _visualRot { get => _visualRot_Element.Data; set => _visualRot_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _visualRot_Element = new();
public global::FrooxEngine.TorusMesh _circle { get => _circle_Element.Data; set => _circle_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.TorusMesh>, global::FrooxEngine.TorusMesh> _circle_Element = new();
public global::FrooxEngine.TorusMesh _circleColliderMesh { get => _circleColliderMesh_Element.Data; set => _circleColliderMesh_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.TorusMesh>, global::FrooxEngine.TorusMesh> _circleColliderMesh_Element = new();
public global::FrooxEngine.SegmentMesh _referenceLine { get => _referenceLine_Element.Data; set => _referenceLine_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.SegmentMesh>, global::FrooxEngine.SegmentMesh> _referenceLine_Element = new();
public global::FrooxEngine.Slot _linesRoot { get => _linesRoot_Element.Data; set => _linesRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _linesRoot_Element = new();
public global::FrooxEngine.SegmentMesh _line0 { get => _line0_Element.Data; set => _line0_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SegmentMesh>, global::FrooxEngine.SegmentMesh> _line0_Element = new();
public global::FrooxEngine.SegmentMesh _line1 { get => _line1_Element.Data; set => _line1_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SegmentMesh>, global::FrooxEngine.SegmentMesh> _line1_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Axis", Axis_Element.ToLinkField(context));
members.Add("AxisSpace", AxisSpace.ToLinkSyncObject(context));
members.Add("RotationSpace", RotationSpace.ToLinkSyncObject(context));
members.Add("TargetRotation", TargetRotation_Element.ToLinkReference(context));
members.Add("TargetValue", TargetValue_Element.ToLinkReference(context));
members.Add("CircleRadius", CircleRadius_Element.ToLinkField(context));
members.Add("CircleThickness", CircleThickness_Element.ToLinkField(context));
members.Add("_visualRoot", _visualRoot_Element.ToLinkReference(context));
members.Add("_visualRot", _visualRot_Element.ToLinkReference(context));
members.Add("_circle", _circle_Element.ToLinkReference(context));
members.Add("_circleColliderMesh", _circleColliderMesh_Element.ToLinkReference(context));
members.Add("_referenceLine", _referenceLine_Element.ToLinkReference(context));
members.Add("_linesRoot", _linesRoot_Element.ToLinkReference(context));
members.Add("_line0", _line0_Element.ToLinkReference(context));
members.Add("_line1", _line1_Element.ToLinkReference(context));
}

}
}
