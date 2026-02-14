
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LineSegment
// Generated on: sobota 14. února 2026 8:58:45
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LineSegment")]
public partial class LineSegment : global::FrooxEngine.Component

{
    public global::System.Single Radius;
public global::System.Int32 Sides;
public UnityEngine.Vector3 Point0;
public UnityEngine.Vector3 Point1;
public global::FrooxEngine.Slot Anchor0;
public global::FrooxEngine.Slot Anchor1;
public global::FrooxEngine.CylinderMesh _cylinder;
public global::FrooxEngine.CylinderCollider _collider;
public global::FrooxEngine.IField<UnityEngine.Vector3> _offset;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotation;
public global::FrooxEngine.IField<UnityEngine.Vector3> _visualScale;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("Sides", Sides.ToResoniteLinkField());
members.Add("Point0", Point0.ToResoniteLinkField());
members.Add("Point1", Point1.ToResoniteLinkField());
members.Add("Anchor0", Anchor0.ToResoniteReference(context));
members.Add("Anchor1", Anchor1.ToResoniteReference(context));
members.Add("_cylinder", _cylinder.ToResoniteReference(context));
members.Add("_collider", _collider.ToResoniteReference(context));
members.Add("_offset", _offset.ToResoniteReference(context));
members.Add("_rotation", _rotation.ToResoniteReference(context));
members.Add("_visualScale", _visualScale.ToResoniteReference(context));
}

}
}
