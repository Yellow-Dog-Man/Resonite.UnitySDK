
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RaycastDriver
// Generated on: pátek 13. února 2026 5:52:26
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RaycastDriver")]
public partial class RaycastDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot IgnoreHierarchy;
public global::System.Single FilterDistance;
public global::FrooxEngine.Slot Origin;
public UnityEngine.Vector3 Offset;
public UnityEngine.Vector3 Direction;
public global::System.Single MaxDistance;
public global::System.Single NoHitDistance;
public global::FrooxEngine.IField<UnityEngine.Vector3> _positionDrive;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotationDrive;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("IgnoreHierarchy", new ResoniteLink.Reference() { });
members.Add("FilterDistance", FilterDistance.ToResoniteLinkField());
members.Add("Origin", new ResoniteLink.Reference() { });
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("Direction", Direction.ToResoniteLinkField());
members.Add("MaxDistance", MaxDistance.ToResoniteLinkField());
members.Add("NoHitDistance", NoHitDistance.ToResoniteLinkField());
members.Add("_positionDrive", new ResoniteLink.Reference() { });
members.Add("_rotationDrive", new ResoniteLink.Reference() { });
}

}
}
