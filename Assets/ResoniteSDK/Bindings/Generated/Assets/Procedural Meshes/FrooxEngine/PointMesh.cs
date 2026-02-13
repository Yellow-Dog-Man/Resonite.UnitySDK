
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PointMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PointMesh")]
public partial class PointMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Vector3[] Points;
public UnityEngine.Vector2[] Sizes;
public global::System.Single[] Rotations;
public UnityEngine.Color[] Colors;
public global::Renderite.Shared.ColorProfile ColorsProfile;
public UnityEngine.Vector4[] UVs;
public global::System.Boolean Sort;
public UnityEngine.Vector3 SortPoint;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Points", Points.ToResoniteLinkArray());
members.Add("Sizes", Sizes.ToResoniteLinkArray());
members.Add("Rotations", Rotations.ToResoniteLinkArray());
members.Add("Colors", Colors.ToResoniteLinkArray());
members.Add("ColorsProfile", ColorsProfile.ToResoniteLinkField());
members.Add("UVs", UVs.ToResoniteLinkArray());
members.Add("Sort", Sort.ToResoniteLinkField());
members.Add("SortPoint", SortPoint.ToResoniteLinkField());
}

}
}
