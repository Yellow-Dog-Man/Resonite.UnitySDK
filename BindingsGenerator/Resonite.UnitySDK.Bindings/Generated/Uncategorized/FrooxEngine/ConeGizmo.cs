
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ConeGizmo
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ConeGizmo")]
public partial class ConeGizmo : global::FrooxEngine.Gizmo

{
    public global::FrooxEngine.IField<global::System.Single> TargetAngle { get => TargetAngle_Element.Data; set => TargetAngle_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> TargetAngle_Element = new();
public global::FrooxEngine.IField<global::System.Single> TargetRadius { get => TargetRadius_Element.Data; set => TargetRadius_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> TargetRadius_Element = new();
public global::FrooxEngine.IField<global::System.Single> TargetHeight { get => TargetHeight_Element.Data; set => TargetHeight_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> TargetHeight_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> TargetDirection { get => TargetDirection_Element.Data; set => TargetDirection_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<UnityEngine.Vector3>>, global::FrooxEngine.IField<UnityEngine.Vector3>> TargetDirection_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> TargetRotation { get => TargetRotation_Element.Data; set => TargetRotation_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<UnityEngine.Quaternion>>, global::FrooxEngine.IField<UnityEngine.Quaternion>> TargetRotation_Element = new();
public global::FrooxEngine.RootSpace DirectionSpace = new();
public global::System.Single FixedAngle { get => FixedAngle_Element.Data; set => FixedAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FixedAngle_Element = new();
public global::System.Single FixedHeight { get => FixedHeight_Element.Data; set => FixedHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FixedHeight_Element = new();
public UnityEngine.Vector3 FixedDirection { get => FixedDirection_Element.Data; set => FixedDirection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> FixedDirection_Element = new();
public global::System.Single LineThickness { get => LineThickness_Element.Data; set => LineThickness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LineThickness_Element = new();
public global::System.Single MinHeight { get => MinHeight_Element.Data; set => MinHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinHeight_Element = new();
public global::System.Single MaxHeight { get => MaxHeight_Element.Data; set => MaxHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxHeight_Element = new();
public global::System.Single MinAngle { get => MinAngle_Element.Data; set => MinAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinAngle_Element = new();
public global::System.Single MaxAngle { get => MaxAngle_Element.Data; set => MaxAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxAngle_Element = new();
public global::FrooxEngine.Slot _visualRoot { get => _visualRoot_Element.Data; set => _visualRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _visualRoot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _visualRot { get => _visualRot_Element.Data; set => _visualRot_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _visualRot_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.ConeGizmo.Handle>, global::FrooxEngine.ConeGizmo.Handle> _handles = new();
public global::FrooxEngine.SegmentMesh _heightMesh { get => _heightMesh_Element.Data; set => _heightMesh_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.SegmentMesh>, global::FrooxEngine.SegmentMesh> _heightMesh_Element = new();
public global::FrooxEngine.SegmentMesh _coneLineMesh { get => _coneLineMesh_Element.Data; set => _coneLineMesh_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.SegmentMesh>, global::FrooxEngine.SegmentMesh> _coneLineMesh_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetAngle", TargetAngle_Element.Data.ToResoniteReference(context));
members.Add("TargetRadius", TargetRadius_Element.Data.ToResoniteReference(context));
members.Add("TargetHeight", TargetHeight_Element.Data.ToResoniteReference(context));
members.Add("TargetDirection", TargetDirection_Element.Data.ToResoniteReference(context));
members.Add("TargetRotation", TargetRotation_Element.Data.ToResoniteReference(context));
members.Add("DirectionSpace", new ResoniteLink.SyncObject() { Members = DirectionSpace.CollectMembers(context) });
members.Add("FixedAngle", FixedAngle_Element.Data.ToResoniteLinkField());
members.Add("FixedHeight", FixedHeight_Element.Data.ToResoniteLinkField());
members.Add("FixedDirection", FixedDirection_Element.Data.ToResoniteLinkField());
members.Add("LineThickness", LineThickness_Element.Data.ToResoniteLinkField());
members.Add("MinHeight", MinHeight_Element.Data.ToResoniteLinkField());
members.Add("MaxHeight", MaxHeight_Element.Data.ToResoniteLinkField());
members.Add("MinAngle", MinAngle_Element.Data.ToResoniteLinkField());
members.Add("MaxAngle", MaxAngle_Element.Data.ToResoniteLinkField());
members.Add("_visualRoot", _visualRoot_Element.Data.ToResoniteReference(context));
members.Add("_visualRot", _visualRot_Element.Data.ToResoniteReference(context));
members.Add("_handles", new ResoniteLink.SyncList()
{
    Elements = _handles.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("_heightMesh", _heightMesh_Element.Data.ToResoniteReference(context));
members.Add("_coneLineMesh", _coneLineMesh_Element.Data.ToResoniteReference(context));
}

}
}
