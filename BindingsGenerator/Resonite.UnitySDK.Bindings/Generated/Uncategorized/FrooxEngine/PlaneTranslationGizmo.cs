
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PlaneTranslationGizmo
// Generated on: čtvrtek 26. února 2026 10:04:47
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PlaneTranslationGizmo")]
public partial class PlaneTranslationGizmo : global::FrooxEngine.Gizmo

{
    public global::FrooxEngine.RootSpace PointSpace = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> TargetPoint { get => TargetPoint_Element.Data; set => TargetPoint_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<UnityEngine.Vector3>>, global::FrooxEngine.IField<UnityEngine.Vector3>> TargetPoint_Element = new();
public UnityEngine.Vector3 Normal { get => Normal_Element.Data; set => Normal_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Normal_Element = new();
public global::FrooxEngine.RootSpace NormalSpace = new();
public global::System.Boolean UseCustomVisual { get => UseCustomVisual_Element.Data; set => UseCustomVisual_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseCustomVisual_Element = new();
public global::FrooxEngine.Slot _customVisualRoot { get => _customVisualRoot_Element.Data; set => _customVisualRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _customVisualRoot_Element = new();
public UnityEngine.Vector2 HandleSize { get => HandleSize_Element.Data; set => HandleSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> HandleSize_Element = new();
public UnityEngine.Vector2 HandleOffset { get => HandleOffset_Element.Data; set => HandleOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> HandleOffset_Element = new();
public global::System.Boolean CreateUndoSteps { get => CreateUndoSteps_Element.Data; set => CreateUndoSteps_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CreateUndoSteps_Element = new();
public global::FrooxEngine.Slot _visualRoot { get => _visualRoot_Element.Data; set => _visualRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _visualRoot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _visualRotation { get => _visualRotation_Element.Data; set => _visualRotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _visualRotation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _visualPosition { get => _visualPosition_Element.Data; set => _visualPosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _visualPosition_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _boxSize { get => _boxSize_Element.Data; set => _boxSize_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _boxSize_Element = new();
public global::FrooxEngine.Slot _linesRoot { get => _linesRoot_Element.Data; set => _linesRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _linesRoot_Element = new();
public global::FrooxEngine.SegmentMesh _line0 { get => _line0_Element.Data; set => _line0_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SegmentMesh>, global::FrooxEngine.SegmentMesh> _line0_Element = new();
public global::FrooxEngine.SegmentMesh _line1 { get => _line1_Element.Data; set => _line1_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SegmentMesh>, global::FrooxEngine.SegmentMesh> _line1_Element = new();
public global::FrooxEngine.BoxCollider _collider { get => _collider_Element.Data; set => _collider_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.BoxCollider>, global::FrooxEngine.BoxCollider> _collider_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PointSpace", new ResoniteLink.SyncObject() { Members = PointSpace.CollectMembers(context) });
members.Add("TargetPoint", TargetPoint_Element.Data.ToResoniteReference(context));
members.Add("Normal", Normal_Element.Data.ToResoniteLinkField());
members.Add("NormalSpace", new ResoniteLink.SyncObject() { Members = NormalSpace.CollectMembers(context) });
members.Add("UseCustomVisual", UseCustomVisual_Element.Data.ToResoniteLinkField());
members.Add("_customVisualRoot", _customVisualRoot_Element.Data.ToResoniteReference(context));
members.Add("HandleSize", HandleSize_Element.Data.ToResoniteLinkField());
members.Add("HandleOffset", HandleOffset_Element.Data.ToResoniteLinkField());
members.Add("CreateUndoSteps", CreateUndoSteps_Element.Data.ToResoniteLinkField());
members.Add("_visualRoot", _visualRoot_Element.Data.ToResoniteReference(context));
members.Add("_visualRotation", _visualRotation_Element.Data.ToResoniteReference(context));
members.Add("_visualPosition", _visualPosition_Element.Data.ToResoniteReference(context));
members.Add("_boxSize", _boxSize_Element.Data.ToResoniteReference(context));
members.Add("_linesRoot", _linesRoot_Element.Data.ToResoniteReference(context));
members.Add("_line0", _line0_Element.Data.ToResoniteReference(context));
members.Add("_line1", _line1_Element.Data.ToResoniteReference(context));
members.Add("_collider", _collider_Element.Data.ToResoniteReference(context));
}

}
}
