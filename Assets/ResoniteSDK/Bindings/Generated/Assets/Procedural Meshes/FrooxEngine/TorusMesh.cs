
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TorusMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TorusMesh")]
public partial class TorusMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Int32 MinorSegments;
public global::System.Int32 MajorSegments;
public global::System.Single MajorRadius;
public global::System.Single MinorRadius;
public UnityEngine.Vector2 UVScale;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinorSegments", MinorSegments.ToResoniteLinkField());
members.Add("MajorSegments", MajorSegments.ToResoniteLinkField());
members.Add("MajorRadius", MajorRadius.ToResoniteLinkField());
members.Add("MinorRadius", MinorRadius.ToResoniteLinkField());
members.Add("UVScale", UVScale.ToResoniteLinkField());
}

}
}
