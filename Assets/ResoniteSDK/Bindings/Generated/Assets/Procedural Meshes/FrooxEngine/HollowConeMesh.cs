
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HollowConeMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HollowConeMesh")]
public partial class HollowConeMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Height;
public global::System.Single OuterRadiusBase;
public global::System.Single InnerRadiusBase;
public global::System.Single OuterRadiusTop;
public global::System.Single InnerRadiusTop;
public global::System.Int32 Segments;
public UnityEngine.Vector2 UVScale;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Height", Height.ToResoniteLinkField());
members.Add("OuterRadiusBase", OuterRadiusBase.ToResoniteLinkField());
members.Add("InnerRadiusBase", InnerRadiusBase.ToResoniteLinkField());
members.Add("OuterRadiusTop", OuterRadiusTop.ToResoniteLinkField());
members.Add("InnerRadiusTop", InnerRadiusTop.ToResoniteLinkField());
members.Add("Segments", Segments.ToResoniteLinkField());
members.Add("UVScale", UVScale.ToResoniteLinkField());
}

}
}
