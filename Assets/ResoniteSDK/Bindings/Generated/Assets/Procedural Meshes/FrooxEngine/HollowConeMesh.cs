
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HollowConeMesh
// Generated on: pátek 13. února 2026 5:51:08
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
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
