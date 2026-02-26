
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GridMesh
// Generated on: čtvrtek 26. února 2026 15:07:55
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GridMesh")]
public partial class GridMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Vector2Int Points { get => Points_Element.Data; set => Points_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> Points_Element = new();
public UnityEngine.Quaternion Rotation { get => Rotation_Element.Data; set => Rotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> Rotation_Element = new();
public UnityEngine.Vector2 Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> Size_Element = new();
public global::System.Boolean FlatShading { get => FlatShading_Element.Data; set => FlatShading_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FlatShading_Element = new();
public UnityEngine.Vector2 UVScale { get => UVScale_Element.Data; set => UVScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UVScale_Element = new();
public UnityEngine.Vector2 UVOffset { get => UVOffset_Element.Data; set => UVOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UVOffset_Element = new();
public global::System.Single DisplacementMagnitude { get => DisplacementMagnitude_Element.Data; set => DisplacementMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DisplacementMagnitude_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> DisplacementTexture { get => DisplacementTexture_Element.Data; set => DisplacementTexture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D>> DisplacementTexture_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Points", Points_Element.ToLinkField(context));
members.Add("Rotation", Rotation_Element.ToLinkField(context));
members.Add("Size", Size_Element.ToLinkField(context));
members.Add("FlatShading", FlatShading_Element.ToLinkField(context));
members.Add("UVScale", UVScale_Element.ToLinkField(context));
members.Add("UVOffset", UVOffset_Element.ToLinkField(context));
members.Add("DisplacementMagnitude", DisplacementMagnitude_Element.ToLinkField(context));
members.Add("DisplacementTexture", DisplacementTexture_Element.ToLinkReference(context));
}

}
}
