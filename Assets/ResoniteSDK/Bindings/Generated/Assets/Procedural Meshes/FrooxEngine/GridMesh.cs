
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GridMesh
// Generated on: pátek 13. února 2026 23:21:35
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GridMesh")]
public partial class GridMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Vector2Int Points;
public UnityEngine.Quaternion Rotation;
public UnityEngine.Vector2 Size;
public global::System.Boolean FlatShading;
public UnityEngine.Vector2 UVScale;
public UnityEngine.Vector2 UVOffset;
public global::System.Single DisplacementMagnitude;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> DisplacementTexture;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Points", Points.ToResoniteLinkField());
members.Add("Rotation", Rotation.ToResoniteLinkField());
members.Add("Size", Size.ToResoniteLinkField());
members.Add("FlatShading", FlatShading.ToResoniteLinkField());
members.Add("UVScale", UVScale.ToResoniteLinkField());
members.Add("UVOffset", UVOffset.ToResoniteLinkField());
members.Add("DisplacementMagnitude", DisplacementMagnitude.ToResoniteLinkField());
members.Add("DisplacementTexture", new ResoniteLink.Reference() { });
}

}
}
