
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SlotGizmo
// Generated on: středa 25. února 2026 16:14:43
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
    public global::System.Boolean _isFolded;
public global::FrooxEngine.Worker _activeGizmo;
public global::FrooxEngine.Slot _targetSlot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _positionDrive;
public global::FrooxEngine.IField<UnityEngine.Vector3> _scaleDrive;
public global::FrooxEngine.TubeBoxMesh _boundsMesh;
public global::FrooxEngine.Slot _boundsRoot;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _boundsRotation;
public global::FrooxEngine.IField<UnityEngine.Vector3> _boundsOffset;
public global::FrooxEngine.IField<global::System.Boolean> _boundsActive;
public global::FrooxEngine.IField<global::System.String> _nameText;
public global::FrooxEngine.IField<UnityEngine.Vector3> _nameOffset;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _nameRotation;
public global::FrooxEngine.IField<global::System.Boolean> _nameActive;
public global::FrooxEngine.SegmentMesh _xPosSegment;
public global::FrooxEngine.SegmentMesh _yPosSegment;
public global::FrooxEngine.SegmentMesh _zPosSegment;
public System.Collections.Generic.List<global::FrooxEngine.SlotGizmo.AnchorInfo> _boundsAnchorPositions;
public global::FrooxEngine.PointAnchor _rootAnchor;
public global::FrooxEngine.TranslationGizmo _translationGizmo;
public global::FrooxEngine.RotationGizmo _rotationGizmo;
public global::FrooxEngine.ScaleGizmo _scaleGizmo;
public global::System.Boolean IsLocalSpace;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_isFolded", _isFolded.ToResoniteLinkField());
members.Add("_activeGizmo", _activeGizmo.ToResoniteReference(context));
members.Add("_targetSlot", _targetSlot.ToResoniteReference(context));
members.Add("_positionDrive", _positionDrive.ToResoniteReference(context));
members.Add("_scaleDrive", _scaleDrive.ToResoniteReference(context));
members.Add("_boundsMesh", _boundsMesh.ToResoniteReference(context));
members.Add("_boundsRoot", _boundsRoot.ToResoniteReference(context));
members.Add("_boundsRotation", _boundsRotation.ToResoniteReference(context));
members.Add("_boundsOffset", _boundsOffset.ToResoniteReference(context));
members.Add("_boundsActive", _boundsActive.ToResoniteReference(context));
members.Add("_nameText", _nameText.ToResoniteReference(context));
members.Add("_nameOffset", _nameOffset.ToResoniteReference(context));
members.Add("_nameRotation", _nameRotation.ToResoniteReference(context));
members.Add("_nameActive", _nameActive.ToResoniteReference(context));
members.Add("_xPosSegment", _xPosSegment.ToResoniteReference(context));
members.Add("_yPosSegment", _yPosSegment.ToResoniteReference(context));
members.Add("_zPosSegment", _zPosSegment.ToResoniteReference(context));
members.Add("_boundsAnchorPositions", new ResoniteLink.SyncList()
{
    Elements = _boundsAnchorPositions.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("_rootAnchor", _rootAnchor.ToResoniteReference(context));
members.Add("_translationGizmo", _translationGizmo.ToResoniteReference(context));
members.Add("_rotationGizmo", _rotationGizmo.ToResoniteReference(context));
members.Add("_scaleGizmo", _scaleGizmo.ToResoniteReference(context));
members.Add("IsLocalSpace", IsLocalSpace.ToResoniteLinkField());
}

}
}
