
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VectorGizmo
// Generated on: čtvrtek 26. února 2026 15:09:11
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.RootSpace VectorSpace = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> TargetVector { get => TargetVector_Element.Data; set => TargetVector_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<UnityEngine.Vector3>>, global::FrooxEngine.IField<UnityEngine.Vector3>> TargetVector_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> TargetRotation { get => TargetRotation_Element.Data; set => TargetRotation_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<UnityEngine.Quaternion>>, global::FrooxEngine.IField<UnityEngine.Quaternion>> TargetRotation_Element = new();
public global::System.Boolean FixMagnitude { get => FixMagnitude_Element.Data; set => FixMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FixMagnitude_Element = new();
public global::System.Single FixedMagnitude { get => FixedMagnitude_Element.Data; set => FixedMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FixedMagnitude_Element = new();
public global::System.Single VisualMagnitudeScale { get => VisualMagnitudeScale_Element.Data; set => VisualMagnitudeScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VisualMagnitudeScale_Element = new();
public global::System.Single VisualThickness { get => VisualThickness_Element.Data; set => VisualThickness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VisualThickness_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _colliderRotation { get => _colliderRotation_Element.Data; set => _colliderRotation_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _colliderRotation_Element = new();
public global::FrooxEngine.CylinderCollider _collider { get => _collider_Element.Data; set => _collider_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.CylinderCollider>, global::FrooxEngine.CylinderCollider> _collider_Element = new();
public global::FrooxEngine.ArrowMesh _mesh { get => _mesh_Element.Data; set => _mesh_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.ArrowMesh>, global::FrooxEngine.ArrowMesh> _mesh_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("VectorSpace", VectorSpace.ToLinkSyncObject(context));
members.Add("TargetVector", TargetVector_Element.ToLinkReference(context));
members.Add("TargetRotation", TargetRotation_Element.ToLinkReference(context));
members.Add("FixMagnitude", FixMagnitude_Element.ToLinkField(context));
members.Add("FixedMagnitude", FixedMagnitude_Element.ToLinkField(context));
members.Add("VisualMagnitudeScale", VisualMagnitudeScale_Element.ToLinkField(context));
members.Add("VisualThickness", VisualThickness_Element.ToLinkField(context));
members.Add("_colliderRotation", _colliderRotation_Element.ToLinkReference(context));
members.Add("_collider", _collider_Element.ToLinkReference(context));
members.Add("_mesh", _mesh_Element.ToLinkReference(context));
}

}
}
