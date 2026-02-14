
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AxisTranslationGizmo
// Generated on: sobota 14. února 2026 8:58:42
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Axis", Axis.ToResoniteLinkField());
members.Add("AxisSpace", new ResoniteLink.SyncObject() { Members = AxisSpace.CollectMembers(context) });
members.Add("PointSpace", new ResoniteLink.SyncObject() { Members = PointSpace.CollectMembers(context) });
members.Add("TargetPoint", TargetPoint.ToResoniteReference(context));
members.Add("TargetValue", TargetValue.ToResoniteReference(context));
members.Add("UseCustomVisual", UseCustomVisual.ToResoniteLinkField());
members.Add("_customVisualRoot", _customVisualRoot.ToResoniteReference(context));
members.Add("ArrowLength", ArrowLength.ToResoniteLinkField());
members.Add("CreateUndoSteps", CreateUndoSteps.ToResoniteLinkField());
members.Add("_visualRoot", _visualRoot.ToResoniteReference(context));
members.Add("_visualRot", _visualRot.ToResoniteReference(context));
members.Add("_arrowVector", _arrowVector.ToResoniteReference(context));
members.Add("_arrow", _arrow.ToResoniteReference(context));
members.Add("_collider", _collider.ToResoniteReference(context));
members.Add("_linesRoot", _linesRoot.ToResoniteReference(context));
members.Add("_line0", _line0.ToResoniteReference(context));
members.Add("_line1", _line1.ToResoniteReference(context));
}

}
}
