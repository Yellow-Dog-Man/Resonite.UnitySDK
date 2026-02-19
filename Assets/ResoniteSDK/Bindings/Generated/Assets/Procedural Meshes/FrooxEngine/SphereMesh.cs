
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SphereMesh
// Generated on: čtvrtek 19. února 2026 7:58:53
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SphereMesh")]
public partial class SphereMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Radius;
public global::System.Int32 Segments;
public global::System.Int32 Rings;
public global::Elements.Assets.UVSphereCapsule.Shading Shading;
public UnityEngine.Vector2 UVScale;
public global::System.Boolean DualSided;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("Segments", Segments.ToResoniteLinkField());
members.Add("Rings", Rings.ToResoniteLinkField());
members.Add("Shading", Shading.ToResoniteLinkField());
members.Add("UVScale", UVScale.ToResoniteLinkField());
members.Add("DualSided", DualSided.ToResoniteLinkField());
}

}
}
