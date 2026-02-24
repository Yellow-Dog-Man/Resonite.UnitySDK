
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.QuadArrayMesh
// Generated on: úterý 24. února 2026 18:17:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.QuadArrayMesh")]
public partial class QuadArrayMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Vector3[] Points;
public UnityEngine.Vector2[] Sizes;
public UnityEngine.Quaternion[] Rotations;
public UnityEngine.Color[] Colors;
public global::Renderite.Shared.ColorProfile ColorsProfile;
public UnityEngine.Vector4[] UVs;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Points", Points.ToResoniteLinkArray());
members.Add("Sizes", Sizes.ToResoniteLinkArray());
members.Add("Rotations", Rotations.ToResoniteLinkArray());
members.Add("Colors", Colors.ToResoniteLinkArray());
members.Add("ColorsProfile", ColorsProfile.ToResoniteLinkField());
members.Add("UVs", UVs.ToResoniteLinkArray());
}

}
}
