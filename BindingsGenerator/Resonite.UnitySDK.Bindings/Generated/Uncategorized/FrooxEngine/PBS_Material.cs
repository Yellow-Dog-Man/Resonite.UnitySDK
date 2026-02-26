
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_Material
// Generated on: čtvrtek 26. února 2026 12:26:47
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_Material")]
public abstract partial class PBS_Material : global::FrooxEngine.SingleShaderMaterialProvider, global::FrooxEngine.ICommonMaterial, global::FrooxEngine.IPBS_Material

{
    public UnityEngine.Vector2 TextureScale { get => TextureScale_Element.Data; set => TextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TextureScale_Element = new();
public UnityEngine.Vector2 TextureOffset { get => TextureOffset_Element.Data; set => TextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TextureOffset_Element = new();
public UnityEngine.Vector2 DetailTextureScale { get => DetailTextureScale_Element.Data; set => DetailTextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> DetailTextureScale_Element = new();
public UnityEngine.Vector2 DetailTextureOffset { get => DetailTextureOffset_Element.Data; set => DetailTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> DetailTextureOffset_Element = new();
public UnityEngine.ColorX AlbedoColor { get => AlbedoColor_Element.Data; set => AlbedoColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> AlbedoColor_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture { get => AlbedoTexture_Element.Data; set => AlbedoTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> AlbedoTexture_Element = new();
public UnityEngine.ColorX EmissiveColor { get => EmissiveColor_Element.Data; set => EmissiveColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EmissiveColor_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap { get => EmissiveMap_Element.Data; set => EmissiveMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> EmissiveMap_Element = new();
public global::System.Single NormalScale { get => NormalScale_Element.Data; set => NormalScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalScale_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap { get => NormalMap_Element.Data; set => NormalMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> NormalMap_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> HeightMap { get => HeightMap_Element.Data; set => HeightMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> HeightMap_Element = new();
public global::System.Single HeightScale { get => HeightScale_Element.Data; set => HeightScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeightScale_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OcclusionMap { get => OcclusionMap_Element.Data; set => OcclusionMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> OcclusionMap_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> DetailAlbedoTexture { get => DetailAlbedoTexture_Element.Data; set => DetailAlbedoTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> DetailAlbedoTexture_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> DetailNormalMap { get => DetailNormalMap_Element.Data; set => DetailNormalMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> DetailNormalMap_Element = new();
public global::System.Single DetailNormalScale { get => DetailNormalScale_Element.Data; set => DetailNormalScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DetailNormalScale_Element = new();
public global::FrooxEngine.BlendMode BlendMode { get => BlendMode_Element.Data; set => BlendMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.BlendMode>, global::FrooxEngine.BlendMode> BlendMode_Element = new();
public global::System.Single AlphaCutoff { get => AlphaCutoff_Element.Data; set => AlphaCutoff_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AlphaCutoff_Element = new();
public global::System.Single OffsetFactor { get => OffsetFactor_Element.Data; set => OffsetFactor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetFactor_Element = new();
public global::System.Single OffsetUnits { get => OffsetUnits_Element.Data; set => OffsetUnits_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetUnits_Element = new();
public global::System.Int32 RenderQueue { get => RenderQueue_Element.Data; set => RenderQueue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> RenderQueue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TextureScale", TextureScale_Element.ToLinkField(context));
members.Add("TextureOffset", TextureOffset_Element.ToLinkField(context));
members.Add("DetailTextureScale", DetailTextureScale_Element.ToLinkField(context));
members.Add("DetailTextureOffset", DetailTextureOffset_Element.ToLinkField(context));
members.Add("AlbedoColor", AlbedoColor_Element.ToLinkField(context));
members.Add("AlbedoTexture", AlbedoTexture_Element.ToLinkReference(context));
members.Add("EmissiveColor", EmissiveColor_Element.ToLinkField(context));
members.Add("EmissiveMap", EmissiveMap_Element.ToLinkReference(context));
members.Add("NormalScale", NormalScale_Element.ToLinkField(context));
members.Add("NormalMap", NormalMap_Element.ToLinkReference(context));
members.Add("HeightMap", HeightMap_Element.ToLinkReference(context));
members.Add("HeightScale", HeightScale_Element.ToLinkField(context));
members.Add("OcclusionMap", OcclusionMap_Element.ToLinkReference(context));
members.Add("DetailAlbedoTexture", DetailAlbedoTexture_Element.ToLinkReference(context));
members.Add("DetailNormalMap", DetailNormalMap_Element.ToLinkReference(context));
members.Add("DetailNormalScale", DetailNormalScale_Element.ToLinkField(context));
members.Add("BlendMode", BlendMode_Element.ToLinkField(context));
members.Add("AlphaCutoff", AlphaCutoff_Element.ToLinkField(context));
members.Add("OffsetFactor", OffsetFactor_Element.ToLinkField(context));
members.Add("OffsetUnits", OffsetUnits_Element.ToLinkField(context));
members.Add("RenderQueue", RenderQueue_Element.ToLinkField(context));
}

}
}
