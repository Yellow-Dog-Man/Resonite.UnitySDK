
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TriangleCollider
// Generated on: středa 25. února 2026 16:13:11
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TriangleCollider")]
public partial class TriangleCollider : global::FrooxEngine.PrimitiveShapeCollider<global::BepuPhysics.Collidables.Triangle>

{
    public UnityEngine.Vector3 A;
public UnityEngine.Vector3 B;
public UnityEngine.Vector3 C;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("A", A.ToResoniteLinkField());
members.Add("B", B.ToResoniteLinkField());
members.Add("C", C.ToResoniteLinkField());
}

}
}
