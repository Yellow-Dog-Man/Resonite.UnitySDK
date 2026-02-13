
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SlotGizmo
// Generated on: pátek 13. února 2026 5:52:36
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_isFolded", _isFolded.ToResoniteLinkField());
members.Add("_activeGizmo", new ResoniteLink.Reference() { });
members.Add("_targetSlot", new ResoniteLink.Reference() { });
members.Add("_positionDrive", new ResoniteLink.Reference() { });
members.Add("_scaleDrive", new ResoniteLink.Reference() { });
members.Add("_boundsMesh", new ResoniteLink.Reference() { });
members.Add("_boundsRoot", new ResoniteLink.Reference() { });
members.Add("_boundsRotation", new ResoniteLink.Reference() { });
members.Add("_boundsOffset", new ResoniteLink.Reference() { });
members.Add("_boundsActive", new ResoniteLink.Reference() { });
members.Add("_nameText", new ResoniteLink.Reference() { });
members.Add("_nameOffset", new ResoniteLink.Reference() { });
members.Add("_nameRotation", new ResoniteLink.Reference() { });
members.Add("_nameActive", new ResoniteLink.Reference() { });
members.Add("_xPosSegment", new ResoniteLink.Reference() { });
members.Add("_yPosSegment", new ResoniteLink.Reference() { });
members.Add("_zPosSegment", new ResoniteLink.Reference() { });
members.Add("_boundsAnchorPositions", new ResoniteLink.SyncList()
{
    Elements = _boundsAnchorPositions.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
members.Add("_rootAnchor", new ResoniteLink.Reference() { });
members.Add("_translationGizmo", new ResoniteLink.Reference() { });
members.Add("_rotationGizmo", new ResoniteLink.Reference() { });
members.Add("_scaleGizmo", new ResoniteLink.Reference() { });
members.Add("IsLocalSpace", IsLocalSpace.ToResoniteLinkField());
}

}
}
