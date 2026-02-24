
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RayDriver
// Generated on: úterý 24. února 2026 18:20:14
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RayDriver")]
public partial class RayDriver : global::FrooxEngine.Component

{
    public global::System.Single MaxDistance;
public global::FrooxEngine.Sync<UnityEngine.Vector3> PointA;
public global::FrooxEngine.Sync<UnityEngine.Vector3> PointB;
public UnityEngine.Vector3 LocalOrigin;
public UnityEngine.Vector3 LocalDirection;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxDistance", MaxDistance.ToResoniteLinkField());
members.Add("PointA", PointA.ToResoniteReference(context));
members.Add("PointB", PointB.ToResoniteReference(context));
members.Add("LocalOrigin", LocalOrigin.ToResoniteLinkField());
members.Add("LocalDirection", LocalDirection.ToResoniteLinkField());
}

}
}
