
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugSphereRaycast
// Generated on: sobota 14. února 2026 8:57:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugSphereRaycast")]
public partial class DebugSphereRaycast : global::FrooxEngine.Component

{
    public UnityEngine.Vector3 Direction;
public global::System.Single Radius;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Direction", Direction.ToResoniteLinkField());
members.Add("Radius", Radius.ToResoniteLinkField());
}

}
}
