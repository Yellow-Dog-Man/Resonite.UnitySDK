
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_Material
// Generated on: pátek 13. února 2026 23:21:32
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_Material")]
public abstract partial class PBS_Material : global::FrooxEngine.SingleShaderMaterialProvider, global::FrooxEngine.ICommonMaterial, global::FrooxEngine.IPBS_Material

{
    public UnityEngine.Vector2 TextureScale;
public UnityEngine.Vector2 TextureOffset;
public UnityEngine.Vector2 DetailTextureScale;
public UnityEngine.Vector2 DetailTextureOffset;
public UnityEngine.ColorX AlbedoColor;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture;
public UnityEngine.ColorX EmissiveColor;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap;
public global::System.Single NormalScale;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> HeightMap;
public global::System.Single HeightScale;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OcclusionMap;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> DetailAlbedoTexture;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> DetailNormalMap;
public global::System.Single DetailNormalScale;
public global::FrooxEngine.BlendMode BlendMode;
public global::System.Single AlphaCutoff;
public global::System.Single OffsetFactor;
public global::System.Single OffsetUnits;
public global::System.Int32 RenderQueue;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TextureScale", TextureScale.ToResoniteLinkField());
members.Add("TextureOffset", TextureOffset.ToResoniteLinkField());
members.Add("DetailTextureScale", DetailTextureScale.ToResoniteLinkField());
members.Add("DetailTextureOffset", DetailTextureOffset.ToResoniteLinkField());
members.Add("AlbedoColor", AlbedoColor.ToResoniteLinkField());
members.Add("AlbedoTexture", new ResoniteLink.Reference() { });
members.Add("EmissiveColor", EmissiveColor.ToResoniteLinkField());
members.Add("EmissiveMap", new ResoniteLink.Reference() { });
members.Add("NormalScale", NormalScale.ToResoniteLinkField());
members.Add("NormalMap", new ResoniteLink.Reference() { });
members.Add("HeightMap", new ResoniteLink.Reference() { });
members.Add("HeightScale", HeightScale.ToResoniteLinkField());
members.Add("OcclusionMap", new ResoniteLink.Reference() { });
members.Add("DetailAlbedoTexture", new ResoniteLink.Reference() { });
members.Add("DetailNormalMap", new ResoniteLink.Reference() { });
members.Add("DetailNormalScale", DetailNormalScale.ToResoniteLinkField());
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("AlphaCutoff", AlphaCutoff.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
}

}
}
