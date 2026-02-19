
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PlaneTranslationGizmo
// Generated on: čtvrtek 19. února 2026 8:00:29
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PointSpace", new ResoniteLink.SyncObject() { Members = PointSpace.CollectMembers(context) });
members.Add("TargetPoint", TargetPoint.ToResoniteReference(context));
members.Add("Normal", Normal.ToResoniteLinkField());
members.Add("NormalSpace", new ResoniteLink.SyncObject() { Members = NormalSpace.CollectMembers(context) });
members.Add("UseCustomVisual", UseCustomVisual.ToResoniteLinkField());
members.Add("_customVisualRoot", _customVisualRoot.ToResoniteReference(context));
members.Add("HandleSize", HandleSize.ToResoniteLinkField());
members.Add("HandleOffset", HandleOffset.ToResoniteLinkField());
members.Add("CreateUndoSteps", CreateUndoSteps.ToResoniteLinkField());
members.Add("_visualRoot", _visualRoot.ToResoniteReference(context));
members.Add("_visualRotation", _visualRotation.ToResoniteReference(context));
members.Add("_visualPosition", _visualPosition.ToResoniteReference(context));
members.Add("_boxSize", _boxSize.ToResoniteReference(context));
members.Add("_linesRoot", _linesRoot.ToResoniteReference(context));
members.Add("_line0", _line0.ToResoniteReference(context));
members.Add("_line1", _line1.ToResoniteReference(context));
members.Add("_collider", _collider.ToResoniteReference(context));
}

}
}
