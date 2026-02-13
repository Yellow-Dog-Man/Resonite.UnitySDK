
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LineSegment
// Generated on: pátek 13. února 2026 5:52:34
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("Sides", Sides.ToResoniteLinkField());
members.Add("Point0", Point0.ToResoniteLinkField());
members.Add("Point1", Point1.ToResoniteLinkField());
members.Add("Anchor0", new ResoniteLink.Reference() { });
members.Add("Anchor1", new ResoniteLink.Reference() { });
members.Add("_cylinder", new ResoniteLink.Reference() { });
members.Add("_collider", new ResoniteLink.Reference() { });
members.Add("_offset", new ResoniteLink.Reference() { });
members.Add("_rotation", new ResoniteLink.Reference() { });
members.Add("_visualScale", new ResoniteLink.Reference() { });
}

}
}
