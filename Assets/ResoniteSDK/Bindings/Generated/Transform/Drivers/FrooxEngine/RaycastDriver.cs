
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RaycastDriver
// Generated on: čtvrtek 19. února 2026 8:00:24
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IgnoreHierarchy", IgnoreHierarchy.ToResoniteReference(context));
members.Add("FilterDistance", FilterDistance.ToResoniteLinkField());
members.Add("Origin", Origin.ToResoniteReference(context));
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("Direction", Direction.ToResoniteLinkField());
members.Add("MaxDistance", MaxDistance.ToResoniteLinkField());
members.Add("NoHitDistance", NoHitDistance.ToResoniteLinkField());
members.Add("_positionDrive", _positionDrive.ToResoniteReference(context));
members.Add("_rotationDrive", _rotationDrive.ToResoniteReference(context));
}

}
}
