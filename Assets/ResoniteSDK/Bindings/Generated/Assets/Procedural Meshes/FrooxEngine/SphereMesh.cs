
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SphereMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SphereMesh")]
public partial class SphereMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Radius;
public global::System.Int32 Segments;
public global::System.Int32 Rings;
public global::Elements.Assets.UVSphereCapsule.Shading Shading;
public UnityEngine.Vector2 UVScale;
public global::System.Boolean DualSided;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("Segments", Segments.ToResoniteLinkField());
members.Add("Rings", Rings.ToResoniteLinkField());
members.Add("Shading", Shading.ToResoniteLinkField());
members.Add("UVScale", UVScale.ToResoniteLinkField());
members.Add("DualSided", DualSided.ToResoniteLinkField());
}

}
}
