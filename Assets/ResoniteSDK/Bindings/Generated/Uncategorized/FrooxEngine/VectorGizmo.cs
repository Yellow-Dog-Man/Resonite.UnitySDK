
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VectorGizmo
// Generated on: pátek 13. února 2026 5:52:31
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VectorGizmo")]
public partial class VectorGizmo : global::FrooxEngine.Gizmo

{
    public global::FrooxEngine.RootSpace VectorSpace;
public global::FrooxEngine.IField<UnityEngine.Vector3> TargetVector;
public global::FrooxEngine.IField<UnityEngine.Quaternion> TargetRotation;
public global::System.Boolean FixMagnitude;
public global::System.Single FixedMagnitude;
public global::System.Single VisualMagnitudeScale;
public global::System.Single VisualThickness;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _colliderRotation;
public global::FrooxEngine.CylinderCollider _collider;
public global::FrooxEngine.ArrowMesh _mesh;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("VectorSpace", new ResoniteLink.SyncObject() { Members = VectorSpace.CollectMembers() });
members.Add("TargetVector", new ResoniteLink.Reference() { });
members.Add("TargetRotation", new ResoniteLink.Reference() { });
members.Add("FixMagnitude", FixMagnitude.ToResoniteLinkField());
members.Add("FixedMagnitude", FixedMagnitude.ToResoniteLinkField());
members.Add("VisualMagnitudeScale", VisualMagnitudeScale.ToResoniteLinkField());
members.Add("VisualThickness", VisualThickness.ToResoniteLinkField());
members.Add("_colliderRotation", new ResoniteLink.Reference() { });
members.Add("_collider", new ResoniteLink.Reference() { });
members.Add("_mesh", new ResoniteLink.Reference() { });
}

}
}
