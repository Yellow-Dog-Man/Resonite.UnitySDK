
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ConeGizmo
// Generated on: středa 25. února 2026 16:14:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ConeGizmo")]
public partial class ConeGizmo : global::FrooxEngine.Gizmo

{
    public global::FrooxEngine.IField<global::System.Single> TargetAngle;
public global::FrooxEngine.IField<global::System.Single> TargetRadius;
public global::FrooxEngine.IField<global::System.Single> TargetHeight;
public global::FrooxEngine.IField<UnityEngine.Vector3> TargetDirection;
public global::FrooxEngine.IField<UnityEngine.Quaternion> TargetRotation;
public global::FrooxEngine.RootSpace DirectionSpace;
public global::System.Single FixedAngle;
public global::System.Single FixedHeight;
public UnityEngine.Vector3 FixedDirection;
public global::System.Single LineThickness;
public global::System.Single MinHeight;
public global::System.Single MaxHeight;
public global::System.Single MinAngle;
public global::System.Single MaxAngle;
public global::FrooxEngine.Slot _visualRoot;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _visualRot;
public System.Collections.Generic.List<global::FrooxEngine.ConeGizmo.Handle> _handles;
public global::FrooxEngine.SegmentMesh _heightMesh;
public global::FrooxEngine.SegmentMesh _coneLineMesh;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetAngle", TargetAngle.ToResoniteReference(context));
members.Add("TargetRadius", TargetRadius.ToResoniteReference(context));
members.Add("TargetHeight", TargetHeight.ToResoniteReference(context));
members.Add("TargetDirection", TargetDirection.ToResoniteReference(context));
members.Add("TargetRotation", TargetRotation.ToResoniteReference(context));
members.Add("DirectionSpace", new ResoniteLink.SyncObject() { Members = DirectionSpace.CollectMembers(context) });
members.Add("FixedAngle", FixedAngle.ToResoniteLinkField());
members.Add("FixedHeight", FixedHeight.ToResoniteLinkField());
members.Add("FixedDirection", FixedDirection.ToResoniteLinkField());
members.Add("LineThickness", LineThickness.ToResoniteLinkField());
members.Add("MinHeight", MinHeight.ToResoniteLinkField());
members.Add("MaxHeight", MaxHeight.ToResoniteLinkField());
members.Add("MinAngle", MinAngle.ToResoniteLinkField());
members.Add("MaxAngle", MaxAngle.ToResoniteLinkField());
members.Add("_visualRoot", _visualRoot.ToResoniteReference(context));
members.Add("_visualRot", _visualRot.ToResoniteReference(context));
members.Add("_handles", new ResoniteLink.SyncList()
{
    Elements = _handles.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("_heightMesh", _heightMesh.ToResoniteReference(context));
members.Add("_coneLineMesh", _coneLineMesh.ToResoniteReference(context));
}

}
}
