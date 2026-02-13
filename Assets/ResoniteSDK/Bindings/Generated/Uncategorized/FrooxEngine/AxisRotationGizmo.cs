
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AxisRotationGizmo
// Generated on: pátek 13. února 2026 23:23:12
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AxisRotationGizmo")]
public partial class AxisRotationGizmo : global::FrooxEngine.Gizmo

{
    public UnityEngine.Vector3 Axis;
public global::FrooxEngine.RootSpace AxisSpace;
public global::FrooxEngine.RootSpace RotationSpace;
public global::FrooxEngine.IField<UnityEngine.Quaternion> TargetRotation;
public global::FrooxEngine.IField<global::System.Single> TargetValue;
public global::System.Single CircleRadius;
public global::System.Single CircleThickness;
public global::FrooxEngine.Slot _visualRoot;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _visualRot;
public global::FrooxEngine.TorusMesh _circle;
public global::FrooxEngine.TorusMesh _circleColliderMesh;
public global::FrooxEngine.SegmentMesh _referenceLine;
public global::FrooxEngine.Slot _linesRoot;
public global::FrooxEngine.SegmentMesh _line0;
public global::FrooxEngine.SegmentMesh _line1;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Axis", Axis.ToResoniteLinkField());
members.Add("AxisSpace", new ResoniteLink.SyncObject() { Members = AxisSpace.CollectMembers() });
members.Add("RotationSpace", new ResoniteLink.SyncObject() { Members = RotationSpace.CollectMembers() });
members.Add("TargetRotation", new ResoniteLink.Reference() { });
members.Add("TargetValue", new ResoniteLink.Reference() { });
members.Add("CircleRadius", CircleRadius.ToResoniteLinkField());
members.Add("CircleThickness", CircleThickness.ToResoniteLinkField());
members.Add("_visualRoot", new ResoniteLink.Reference() { });
members.Add("_visualRot", new ResoniteLink.Reference() { });
members.Add("_circle", new ResoniteLink.Reference() { });
members.Add("_circleColliderMesh", new ResoniteLink.Reference() { });
members.Add("_referenceLine", new ResoniteLink.Reference() { });
members.Add("_linesRoot", new ResoniteLink.Reference() { });
members.Add("_line0", new ResoniteLink.Reference() { });
members.Add("_line1", new ResoniteLink.Reference() { });
}

}
}
