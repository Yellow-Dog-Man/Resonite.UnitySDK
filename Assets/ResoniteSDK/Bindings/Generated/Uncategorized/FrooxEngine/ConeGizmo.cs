
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ConeGizmo
// Generated on: pátek 13. února 2026 23:23:13
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetAngle", new ResoniteLink.Reference() { });
members.Add("TargetRadius", new ResoniteLink.Reference() { });
members.Add("TargetHeight", new ResoniteLink.Reference() { });
members.Add("TargetDirection", new ResoniteLink.Reference() { });
members.Add("TargetRotation", new ResoniteLink.Reference() { });
members.Add("DirectionSpace", new ResoniteLink.SyncObject() { Members = DirectionSpace.CollectMembers() });
members.Add("FixedAngle", FixedAngle.ToResoniteLinkField());
members.Add("FixedHeight", FixedHeight.ToResoniteLinkField());
members.Add("FixedDirection", FixedDirection.ToResoniteLinkField());
members.Add("LineThickness", LineThickness.ToResoniteLinkField());
members.Add("MinHeight", MinHeight.ToResoniteLinkField());
members.Add("MaxHeight", MaxHeight.ToResoniteLinkField());
members.Add("MinAngle", MinAngle.ToResoniteLinkField());
members.Add("MaxAngle", MaxAngle.ToResoniteLinkField());
members.Add("_visualRoot", new ResoniteLink.Reference() { });
members.Add("_visualRot", new ResoniteLink.Reference() { });
members.Add("_handles", new ResoniteLink.SyncList()
{
    Elements = _handles.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
members.Add("_heightMesh", new ResoniteLink.Reference() { });
members.Add("_coneLineMesh", new ResoniteLink.Reference() { });
}

}
}
