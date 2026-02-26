
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LineSegment
// Generated on: čtvrtek 26. února 2026 12:28:12
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LineSegment")]
public partial class LineSegment : global::FrooxEngine.Component

{
    public global::System.Single Radius { get => Radius_Element.Data; set => Radius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Radius_Element = new();
public global::System.Int32 Sides { get => Sides_Element.Data; set => Sides_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Sides_Element = new();
public UnityEngine.Vector3 Point0 { get => Point0_Element.Data; set => Point0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Point0_Element = new();
public UnityEngine.Vector3 Point1 { get => Point1_Element.Data; set => Point1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Point1_Element = new();
public global::FrooxEngine.Slot Anchor0 { get => Anchor0_Element.Data; set => Anchor0_Element.Data = value; }
public Field<global::FrooxEngine.TransformRelayRef, global::FrooxEngine.Slot> Anchor0_Element = new();
public global::FrooxEngine.Slot Anchor1 { get => Anchor1_Element.Data; set => Anchor1_Element.Data = value; }
public Field<global::FrooxEngine.TransformRelayRef, global::FrooxEngine.Slot> Anchor1_Element = new();
public global::FrooxEngine.CylinderMesh _cylinder { get => _cylinder_Element.Data; set => _cylinder_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.CylinderMesh>, global::FrooxEngine.CylinderMesh> _cylinder_Element = new();
public global::FrooxEngine.CylinderCollider _collider { get => _collider_Element.Data; set => _collider_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.CylinderCollider>, global::FrooxEngine.CylinderCollider> _collider_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _offset { get => _offset_Element.Data; set => _offset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _offset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotation { get => _rotation_Element.Data; set => _rotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _rotation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _visualScale { get => _visualScale_Element.Data; set => _visualScale_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _visualScale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius_Element.ToLinkField(context));
members.Add("Sides", Sides_Element.ToLinkField(context));
members.Add("Point0", Point0_Element.ToLinkField(context));
members.Add("Point1", Point1_Element.ToLinkField(context));
members.Add("Anchor0", Anchor0_Element.ToLinkReference(context));
members.Add("Anchor1", Anchor1_Element.ToLinkReference(context));
members.Add("_cylinder", _cylinder_Element.ToLinkReference(context));
members.Add("_collider", _collider_Element.ToLinkReference(context));
members.Add("_offset", _offset_Element.ToLinkReference(context));
members.Add("_rotation", _rotation_Element.ToLinkReference(context));
members.Add("_visualScale", _visualScale_Element.ToLinkReference(context));
}

}
}
