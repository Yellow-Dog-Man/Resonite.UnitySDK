
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AxisTranslationGizmo
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AxisTranslationGizmo")]
public partial class AxisTranslationGizmo : global::FrooxEngine.Gizmo

{
    public UnityEngine.Vector3 Axis { get => Axis_Element.Data; set => Axis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Axis_Element = new();
public global::FrooxEngine.RootSpace AxisSpace = new();
public global::FrooxEngine.RootSpace PointSpace = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> TargetPoint { get => TargetPoint_Element.Data; set => TargetPoint_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<UnityEngine.Vector3>>, global::FrooxEngine.IField<UnityEngine.Vector3>> TargetPoint_Element = new();
public global::FrooxEngine.IField<global::System.Single> TargetValue { get => TargetValue_Element.Data; set => TargetValue_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> TargetValue_Element = new();
public global::System.Boolean UseCustomVisual { get => UseCustomVisual_Element.Data; set => UseCustomVisual_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseCustomVisual_Element = new();
public global::FrooxEngine.Slot _customVisualRoot { get => _customVisualRoot_Element.Data; set => _customVisualRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _customVisualRoot_Element = new();
public global::System.Single ArrowLength { get => ArrowLength_Element.Data; set => ArrowLength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ArrowLength_Element = new();
public global::System.Boolean CreateUndoSteps { get => CreateUndoSteps_Element.Data; set => CreateUndoSteps_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CreateUndoSteps_Element = new();
public global::FrooxEngine.Slot _visualRoot { get => _visualRoot_Element.Data; set => _visualRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _visualRoot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _visualRot { get => _visualRot_Element.Data; set => _visualRot_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _visualRot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _arrowVector { get => _arrowVector_Element.Data; set => _arrowVector_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _arrowVector_Element = new();
public global::FrooxEngine.ArrowMesh _arrow { get => _arrow_Element.Data; set => _arrow_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ArrowMesh>, global::FrooxEngine.ArrowMesh> _arrow_Element = new();
public global::FrooxEngine.CylinderCollider _collider { get => _collider_Element.Data; set => _collider_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.CylinderCollider>, global::FrooxEngine.CylinderCollider> _collider_Element = new();
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
members.Add("PointSpace", PointSpace.ToLinkSyncObject(context));
members.Add("TargetPoint", TargetPoint_Element.ToLinkReference(context));
members.Add("TargetValue", TargetValue_Element.ToLinkReference(context));
members.Add("UseCustomVisual", UseCustomVisual_Element.ToLinkField(context));
members.Add("_customVisualRoot", _customVisualRoot_Element.ToLinkReference(context));
members.Add("ArrowLength", ArrowLength_Element.ToLinkField(context));
members.Add("CreateUndoSteps", CreateUndoSteps_Element.ToLinkField(context));
members.Add("_visualRoot", _visualRoot_Element.ToLinkReference(context));
members.Add("_visualRot", _visualRot_Element.ToLinkReference(context));
members.Add("_arrowVector", _arrowVector_Element.ToLinkReference(context));
members.Add("_arrow", _arrow_Element.ToLinkReference(context));
members.Add("_collider", _collider_Element.ToLinkReference(context));
members.Add("_linesRoot", _linesRoot_Element.ToLinkReference(context));
members.Add("_line0", _line0_Element.ToLinkReference(context));
members.Add("_line1", _line1_Element.ToLinkReference(context));
}

}
}
