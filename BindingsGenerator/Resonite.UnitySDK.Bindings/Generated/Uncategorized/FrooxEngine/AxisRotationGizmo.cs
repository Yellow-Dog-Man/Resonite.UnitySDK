
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AxisRotationGizmo
// Generated on: středa 25. února 2026 16:14:35
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Axis", Axis.ToResoniteLinkField());
members.Add("AxisSpace", new ResoniteLink.SyncObject() { Members = AxisSpace.CollectMembers(context) });
members.Add("RotationSpace", new ResoniteLink.SyncObject() { Members = RotationSpace.CollectMembers(context) });
members.Add("TargetRotation", TargetRotation.ToResoniteReference(context));
members.Add("TargetValue", TargetValue.ToResoniteReference(context));
members.Add("CircleRadius", CircleRadius.ToResoniteLinkField());
members.Add("CircleThickness", CircleThickness.ToResoniteLinkField());
members.Add("_visualRoot", _visualRoot.ToResoniteReference(context));
members.Add("_visualRot", _visualRot.ToResoniteReference(context));
members.Add("_circle", _circle.ToResoniteReference(context));
members.Add("_circleColliderMesh", _circleColliderMesh.ToResoniteReference(context));
members.Add("_referenceLine", _referenceLine.ToResoniteReference(context));
members.Add("_linesRoot", _linesRoot.ToResoniteReference(context));
members.Add("_line0", _line0.ToResoniteReference(context));
members.Add("_line1", _line1.ToResoniteReference(context));
}

}
}
