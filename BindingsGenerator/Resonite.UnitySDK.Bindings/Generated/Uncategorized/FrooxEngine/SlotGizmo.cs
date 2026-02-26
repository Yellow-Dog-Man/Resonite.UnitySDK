
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SlotGizmo
// Generated on: čtvrtek 26. února 2026 10:04:48
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SlotGizmo")]
public partial class SlotGizmo : global::FrooxEngine.Component, global::FrooxEngine.IComponentGizmo

{
    public global::System.Boolean _isFolded { get => _isFolded_Element.Data; set => _isFolded_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _isFolded_Element = new();
public global::FrooxEngine.Worker _activeGizmo { get => _activeGizmo_Element.Data; set => _activeGizmo_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Worker>, global::FrooxEngine.Worker> _activeGizmo_Element = new();
public global::FrooxEngine.Slot _targetSlot { get => _targetSlot_Element.Data; set => _targetSlot_Element.Data = value; }
public Field<global::FrooxEngine.TransformRelayRef, global::FrooxEngine.Slot> _targetSlot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _positionDrive { get => _positionDrive_Element.Data; set => _positionDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _positionDrive_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _scaleDrive { get => _scaleDrive_Element.Data; set => _scaleDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _scaleDrive_Element = new();
public global::FrooxEngine.TubeBoxMesh _boundsMesh { get => _boundsMesh_Element.Data; set => _boundsMesh_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.TubeBoxMesh>, global::FrooxEngine.TubeBoxMesh> _boundsMesh_Element = new();
public global::FrooxEngine.Slot _boundsRoot { get => _boundsRoot_Element.Data; set => _boundsRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _boundsRoot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _boundsRotation { get => _boundsRotation_Element.Data; set => _boundsRotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _boundsRotation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _boundsOffset { get => _boundsOffset_Element.Data; set => _boundsOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _boundsOffset_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _boundsActive { get => _boundsActive_Element.Data; set => _boundsActive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _boundsActive_Element = new();
public global::FrooxEngine.IField<global::System.String> _nameText { get => _nameText_Element.Data; set => _nameText_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> _nameText_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _nameOffset { get => _nameOffset_Element.Data; set => _nameOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _nameOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _nameRotation { get => _nameRotation_Element.Data; set => _nameRotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _nameRotation_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _nameActive { get => _nameActive_Element.Data; set => _nameActive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _nameActive_Element = new();
public global::FrooxEngine.SegmentMesh _xPosSegment { get => _xPosSegment_Element.Data; set => _xPosSegment_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.SegmentMesh>, global::FrooxEngine.SegmentMesh> _xPosSegment_Element = new();
public global::FrooxEngine.SegmentMesh _yPosSegment { get => _yPosSegment_Element.Data; set => _yPosSegment_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.SegmentMesh>, global::FrooxEngine.SegmentMesh> _yPosSegment_Element = new();
public global::FrooxEngine.SegmentMesh _zPosSegment { get => _zPosSegment_Element.Data; set => _zPosSegment_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.SegmentMesh>, global::FrooxEngine.SegmentMesh> _zPosSegment_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.SlotGizmo.AnchorInfo>, global::FrooxEngine.SlotGizmo.AnchorInfo> _boundsAnchorPositions = new();
public global::FrooxEngine.PointAnchor _rootAnchor { get => _rootAnchor_Element.Data; set => _rootAnchor_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.PointAnchor>, global::FrooxEngine.PointAnchor> _rootAnchor_Element = new();
public global::FrooxEngine.TranslationGizmo _translationGizmo { get => _translationGizmo_Element.Data; set => _translationGizmo_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.TranslationGizmo>, global::FrooxEngine.TranslationGizmo> _translationGizmo_Element = new();
public global::FrooxEngine.RotationGizmo _rotationGizmo { get => _rotationGizmo_Element.Data; set => _rotationGizmo_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.RotationGizmo>, global::FrooxEngine.RotationGizmo> _rotationGizmo_Element = new();
public global::FrooxEngine.ScaleGizmo _scaleGizmo { get => _scaleGizmo_Element.Data; set => _scaleGizmo_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ScaleGizmo>, global::FrooxEngine.ScaleGizmo> _scaleGizmo_Element = new();
public global::System.Boolean IsLocalSpace { get => IsLocalSpace_Element.Data; set => IsLocalSpace_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsLocalSpace_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_isFolded", _isFolded_Element.Data.ToResoniteLinkField());
members.Add("_activeGizmo", _activeGizmo_Element.Data.ToResoniteReference(context));
members.Add("_targetSlot", _targetSlot_Element.Data.ToResoniteReference(context));
members.Add("_positionDrive", _positionDrive_Element.Data.ToResoniteReference(context));
members.Add("_scaleDrive", _scaleDrive_Element.Data.ToResoniteReference(context));
members.Add("_boundsMesh", _boundsMesh_Element.Data.ToResoniteReference(context));
members.Add("_boundsRoot", _boundsRoot_Element.Data.ToResoniteReference(context));
members.Add("_boundsRotation", _boundsRotation_Element.Data.ToResoniteReference(context));
members.Add("_boundsOffset", _boundsOffset_Element.Data.ToResoniteReference(context));
members.Add("_boundsActive", _boundsActive_Element.Data.ToResoniteReference(context));
members.Add("_nameText", _nameText_Element.Data.ToResoniteReference(context));
members.Add("_nameOffset", _nameOffset_Element.Data.ToResoniteReference(context));
members.Add("_nameRotation", _nameRotation_Element.Data.ToResoniteReference(context));
members.Add("_nameActive", _nameActive_Element.Data.ToResoniteReference(context));
members.Add("_xPosSegment", _xPosSegment_Element.Data.ToResoniteReference(context));
members.Add("_yPosSegment", _yPosSegment_Element.Data.ToResoniteReference(context));
members.Add("_zPosSegment", _zPosSegment_Element.Data.ToResoniteReference(context));
members.Add("_boundsAnchorPositions", new ResoniteLink.SyncList()
{
    Elements = _boundsAnchorPositions.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("_rootAnchor", _rootAnchor_Element.Data.ToResoniteReference(context));
members.Add("_translationGizmo", _translationGizmo_Element.Data.ToResoniteReference(context));
members.Add("_rotationGizmo", _rotationGizmo_Element.Data.ToResoniteReference(context));
members.Add("_scaleGizmo", _scaleGizmo_Element.Data.ToResoniteReference(context));
members.Add("IsLocalSpace", IsLocalSpace_Element.Data.ToResoniteLinkField());
}

}
}
