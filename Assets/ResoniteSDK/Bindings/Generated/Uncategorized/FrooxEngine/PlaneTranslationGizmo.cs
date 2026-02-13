
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PlaneTranslationGizmo
// Generated on: pátek 13. února 2026 5:52:35
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PlaneTranslationGizmo")]
public partial class PlaneTranslationGizmo : global::FrooxEngine.Gizmo

{
    public global::FrooxEngine.RootSpace PointSpace;
public global::FrooxEngine.IField<UnityEngine.Vector3> TargetPoint;
public UnityEngine.Vector3 Normal;
public global::FrooxEngine.RootSpace NormalSpace;
public global::System.Boolean UseCustomVisual;
public global::FrooxEngine.Slot _customVisualRoot;
public UnityEngine.Vector2 HandleSize;
public UnityEngine.Vector2 HandleOffset;
public global::System.Boolean CreateUndoSteps;
public global::FrooxEngine.Slot _visualRoot;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _visualRotation;
public global::FrooxEngine.IField<UnityEngine.Vector3> _visualPosition;
public global::FrooxEngine.IField<UnityEngine.Vector3> _boxSize;
public global::FrooxEngine.Slot _linesRoot;
public global::FrooxEngine.SegmentMesh _line0;
public global::FrooxEngine.SegmentMesh _line1;
public global::FrooxEngine.BoxCollider _collider;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("PointSpace", new ResoniteLink.SyncObject() { Members = PointSpace.CollectMembers() });
members.Add("TargetPoint", new ResoniteLink.Reference() { });
members.Add("Normal", Normal.ToResoniteLinkField());
members.Add("NormalSpace", new ResoniteLink.SyncObject() { Members = NormalSpace.CollectMembers() });
members.Add("UseCustomVisual", UseCustomVisual.ToResoniteLinkField());
members.Add("_customVisualRoot", new ResoniteLink.Reference() { });
members.Add("HandleSize", HandleSize.ToResoniteLinkField());
members.Add("HandleOffset", HandleOffset.ToResoniteLinkField());
members.Add("CreateUndoSteps", CreateUndoSteps.ToResoniteLinkField());
members.Add("_visualRoot", new ResoniteLink.Reference() { });
members.Add("_visualRotation", new ResoniteLink.Reference() { });
members.Add("_visualPosition", new ResoniteLink.Reference() { });
members.Add("_boxSize", new ResoniteLink.Reference() { });
members.Add("_linesRoot", new ResoniteLink.Reference() { });
members.Add("_line0", new ResoniteLink.Reference() { });
members.Add("_line1", new ResoniteLink.Reference() { });
members.Add("_collider", new ResoniteLink.Reference() { });
}

}
}
