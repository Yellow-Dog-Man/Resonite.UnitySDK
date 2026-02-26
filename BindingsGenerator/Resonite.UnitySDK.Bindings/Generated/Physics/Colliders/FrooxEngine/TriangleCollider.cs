
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TriangleCollider
// Generated on: čtvrtek 26. února 2026 15:08:02
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TriangleCollider")]
public partial class TriangleCollider : global::FrooxEngine.PrimitiveShapeCollider<global::BepuPhysics.Collidables.Triangle>

{
    public UnityEngine.Vector3 A { get => A_Element.Data; set => A_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> A_Element = new();
public UnityEngine.Vector3 B { get => B_Element.Data; set => B_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> B_Element = new();
public UnityEngine.Vector3 C { get => C_Element.Data; set => C_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> C_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("A", A_Element.ToLinkField(context));
members.Add("B", B_Element.ToLinkField(context));
members.Add("C", C_Element.ToLinkField(context));
}

}
}
