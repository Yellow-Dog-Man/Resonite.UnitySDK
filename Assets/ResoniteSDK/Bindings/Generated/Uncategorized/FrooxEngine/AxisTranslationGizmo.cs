
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AxisTranslationGizmo
// Generated on: pátek 13. února 2026 5:52:29
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AxisTranslationGizmo")]
public partial class AxisTranslationGizmo : global::FrooxEngine.Gizmo

{
    public UnityEngine.Vector3 Axis;
public global::FrooxEngine.RootSpace AxisSpace;
public global::FrooxEngine.RootSpace PointSpace;
public global::FrooxEngine.IField<UnityEngine.Vector3> TargetPoint;
public global::FrooxEngine.IField<global::System.Single> TargetValue;
public global::System.Boolean UseCustomVisual;
public global::FrooxEngine.Slot _customVisualRoot;
public global::System.Single ArrowLength;
public global::System.Boolean CreateUndoSteps;
public global::FrooxEngine.Slot _visualRoot;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _visualRot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _arrowVector;
public global::FrooxEngine.ArrowMesh _arrow;
public global::FrooxEngine.CylinderCollider _collider;
public global::FrooxEngine.Slot _linesRoot;
public global::FrooxEngine.SegmentMesh _line0;
public global::FrooxEngine.SegmentMesh _line1;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Axis", Axis.ToResoniteLinkField());
members.Add("AxisSpace", new ResoniteLink.SyncObject() { Members = AxisSpace.CollectMembers() });
members.Add("PointSpace", new ResoniteLink.SyncObject() { Members = PointSpace.CollectMembers() });
members.Add("TargetPoint", new ResoniteLink.Reference() { });
members.Add("TargetValue", new ResoniteLink.Reference() { });
members.Add("UseCustomVisual", UseCustomVisual.ToResoniteLinkField());
members.Add("_customVisualRoot", new ResoniteLink.Reference() { });
members.Add("ArrowLength", ArrowLength.ToResoniteLinkField());
members.Add("CreateUndoSteps", CreateUndoSteps.ToResoniteLinkField());
members.Add("_visualRoot", new ResoniteLink.Reference() { });
members.Add("_visualRot", new ResoniteLink.Reference() { });
members.Add("_arrowVector", new ResoniteLink.Reference() { });
members.Add("_arrow", new ResoniteLink.Reference() { });
members.Add("_collider", new ResoniteLink.Reference() { });
members.Add("_linesRoot", new ResoniteLink.Reference() { });
members.Add("_line0", new ResoniteLink.Reference() { });
members.Add("_line1", new ResoniteLink.Reference() { });
}

}
}
