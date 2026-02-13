
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_MultiUV_Material
// Generated on: pátek 13. února 2026 23:21:33
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_MultiUV_Material")]
public abstract partial class PBS_MultiUV_Material : global::FrooxEngine.SingleShaderMaterialProvider, global::FrooxEngine.IPBS_Material, global::FrooxEngine.ICullingMaterial

{
    public UnityEngine.Vector2 AlbedoScale;
public UnityEngine.Vector2 AlbedoOffset;
public global::System.Int32 AlbedoUV;
public UnityEngine.Vector2 EmissionMapScale;
public UnityEngine.Vector2 EmissionMapOffset;
public global::System.Int32 EmissionMapUV;
public UnityEngine.Vector2 NormalMapScale;
public UnityEngine.Vector2 NormalMapOffset;
public global::System.Int32 NormalMapUV;
public UnityEngine.Vector2 OcclusionMapScale;
public UnityEngine.Vector2 OcclusionMapOffset;
public global::System.Int32 OcclusionMapUV;
public UnityEngine.Vector2 SecondaryAlbedoScale;
public UnityEngine.Vector2 SecondaryAlbedoOffset;
public global::System.Int32 SecondaryAlbedoUV;
public UnityEngine.Vector2 SecondaryEmissionMapScale;
public UnityEngine.Vector2 SecondaryEmissionMapOffset;
public global::System.Int32 SecondaryEmissionMapUV;
public UnityEngine.ColorX AlbedoColor;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture;
public UnityEngine.ColorX EmissiveColor;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap;
public global::System.Single NormalScale;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OcclusionMap;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SecondaryAlbedoTexture;
public UnityEngine.ColorX SecondaryEmissiveColor;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SecondaryEmissiveMap;
public global::FrooxEngine.Culling Culling;
public global::FrooxEngine.AlphaHandling AlphaHandling;
public global::System.Single AlphaClip;
public global::System.Single OffsetFactor;
public global::System.Single OffsetUnits;
public global::System.Int32 RenderQueue;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("AlbedoScale", AlbedoScale.ToResoniteLinkField());
members.Add("AlbedoOffset", AlbedoOffset.ToResoniteLinkField());
members.Add("AlbedoUV", AlbedoUV.ToResoniteLinkField());
members.Add("EmissionMapScale", EmissionMapScale.ToResoniteLinkField());
members.Add("EmissionMapOffset", EmissionMapOffset.ToResoniteLinkField());
members.Add("EmissionMapUV", EmissionMapUV.ToResoniteLinkField());
members.Add("NormalMapScale", NormalMapScale.ToResoniteLinkField());
members.Add("NormalMapOffset", NormalMapOffset.ToResoniteLinkField());
members.Add("NormalMapUV", NormalMapUV.ToResoniteLinkField());
members.Add("OcclusionMapScale", OcclusionMapScale.ToResoniteLinkField());
members.Add("OcclusionMapOffset", OcclusionMapOffset.ToResoniteLinkField());
members.Add("OcclusionMapUV", OcclusionMapUV.ToResoniteLinkField());
members.Add("SecondaryAlbedoScale", SecondaryAlbedoScale.ToResoniteLinkField());
members.Add("SecondaryAlbedoOffset", SecondaryAlbedoOffset.ToResoniteLinkField());
members.Add("SecondaryAlbedoUV", SecondaryAlbedoUV.ToResoniteLinkField());
members.Add("SecondaryEmissionMapScale", SecondaryEmissionMapScale.ToResoniteLinkField());
members.Add("SecondaryEmissionMapOffset", SecondaryEmissionMapOffset.ToResoniteLinkField());
members.Add("SecondaryEmissionMapUV", SecondaryEmissionMapUV.ToResoniteLinkField());
members.Add("AlbedoColor", AlbedoColor.ToResoniteLinkField());
members.Add("AlbedoTexture", new ResoniteLink.Reference() { });
members.Add("EmissiveColor", EmissiveColor.ToResoniteLinkField());
members.Add("EmissiveMap", new ResoniteLink.Reference() { });
members.Add("NormalMap", new ResoniteLink.Reference() { });
members.Add("NormalScale", NormalScale.ToResoniteLinkField());
members.Add("OcclusionMap", new ResoniteLink.Reference() { });
members.Add("SecondaryAlbedoTexture", new ResoniteLink.Reference() { });
members.Add("SecondaryEmissiveColor", SecondaryEmissiveColor.ToResoniteLinkField());
members.Add("SecondaryEmissiveMap", new ResoniteLink.Reference() { });
members.Add("Culling", Culling.ToResoniteLinkField());
members.Add("AlphaHandling", AlphaHandling.ToResoniteLinkField());
members.Add("AlphaClip", AlphaClip.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
}

}
}
