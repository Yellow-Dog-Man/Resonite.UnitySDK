
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VectorGizmo
// Generated on: čtvrtek 19. února 2026 8:00:27
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("VectorSpace", new ResoniteLink.SyncObject() { Members = VectorSpace.CollectMembers(context) });
members.Add("TargetVector", TargetVector.ToResoniteReference(context));
members.Add("TargetRotation", TargetRotation.ToResoniteReference(context));
members.Add("FixMagnitude", FixMagnitude.ToResoniteLinkField());
members.Add("FixedMagnitude", FixedMagnitude.ToResoniteLinkField());
members.Add("VisualMagnitudeScale", VisualMagnitudeScale.ToResoniteLinkField());
members.Add("VisualThickness", VisualThickness.ToResoniteLinkField());
members.Add("_colliderRotation", _colliderRotation.ToResoniteReference(context));
members.Add("_collider", _collider.ToResoniteReference(context));
members.Add("_mesh", _mesh.ToResoniteReference(context));
}

}
}
