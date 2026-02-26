
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_MultiUV_Material
// Generated on: čtvrtek 26. února 2026 10:03:34
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_MultiUV_Material")]
public abstract partial class PBS_MultiUV_Material : global::FrooxEngine.SingleShaderMaterialProvider, global::FrooxEngine.IPBS_Material, global::FrooxEngine.ICullingMaterial

{
    public UnityEngine.Vector2 AlbedoScale { get => AlbedoScale_Element.Data; set => AlbedoScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> AlbedoScale_Element = new();
public UnityEngine.Vector2 AlbedoOffset { get => AlbedoOffset_Element.Data; set => AlbedoOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> AlbedoOffset_Element = new();
public global::System.Int32 AlbedoUV { get => AlbedoUV_Element.Data; set => AlbedoUV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> AlbedoUV_Element = new();
public UnityEngine.Vector2 EmissionMapScale { get => EmissionMapScale_Element.Data; set => EmissionMapScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> EmissionMapScale_Element = new();
public UnityEngine.Vector2 EmissionMapOffset { get => EmissionMapOffset_Element.Data; set => EmissionMapOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> EmissionMapOffset_Element = new();
public global::System.Int32 EmissionMapUV { get => EmissionMapUV_Element.Data; set => EmissionMapUV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> EmissionMapUV_Element = new();
public UnityEngine.Vector2 NormalMapScale { get => NormalMapScale_Element.Data; set => NormalMapScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> NormalMapScale_Element = new();
public UnityEngine.Vector2 NormalMapOffset { get => NormalMapOffset_Element.Data; set => NormalMapOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> NormalMapOffset_Element = new();
public global::System.Int32 NormalMapUV { get => NormalMapUV_Element.Data; set => NormalMapUV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> NormalMapUV_Element = new();
public UnityEngine.Vector2 OcclusionMapScale { get => OcclusionMapScale_Element.Data; set => OcclusionMapScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> OcclusionMapScale_Element = new();
public UnityEngine.Vector2 OcclusionMapOffset { get => OcclusionMapOffset_Element.Data; set => OcclusionMapOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> OcclusionMapOffset_Element = new();
public global::System.Int32 OcclusionMapUV { get => OcclusionMapUV_Element.Data; set => OcclusionMapUV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> OcclusionMapUV_Element = new();
public UnityEngine.Vector2 SecondaryAlbedoScale { get => SecondaryAlbedoScale_Element.Data; set => SecondaryAlbedoScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> SecondaryAlbedoScale_Element = new();
public UnityEngine.Vector2 SecondaryAlbedoOffset { get => SecondaryAlbedoOffset_Element.Data; set => SecondaryAlbedoOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> SecondaryAlbedoOffset_Element = new();
public global::System.Int32 SecondaryAlbedoUV { get => SecondaryAlbedoUV_Element.Data; set => SecondaryAlbedoUV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> SecondaryAlbedoUV_Element = new();
public UnityEngine.Vector2 SecondaryEmissionMapScale { get => SecondaryEmissionMapScale_Element.Data; set => SecondaryEmissionMapScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> SecondaryEmissionMapScale_Element = new();
public UnityEngine.Vector2 SecondaryEmissionMapOffset { get => SecondaryEmissionMapOffset_Element.Data; set => SecondaryEmissionMapOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> SecondaryEmissionMapOffset_Element = new();
public global::System.Int32 SecondaryEmissionMapUV { get => SecondaryEmissionMapUV_Element.Data; set => SecondaryEmissionMapUV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> SecondaryEmissionMapUV_Element = new();
public UnityEngine.ColorX AlbedoColor { get => AlbedoColor_Element.Data; set => AlbedoColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> AlbedoColor_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture { get => AlbedoTexture_Element.Data; set => AlbedoTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> AlbedoTexture_Element = new();
public UnityEngine.ColorX EmissiveColor { get => EmissiveColor_Element.Data; set => EmissiveColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EmissiveColor_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap { get => EmissiveMap_Element.Data; set => EmissiveMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> EmissiveMap_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap { get => NormalMap_Element.Data; set => NormalMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> NormalMap_Element = new();
public global::System.Single NormalScale { get => NormalScale_Element.Data; set => NormalScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalScale_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OcclusionMap { get => OcclusionMap_Element.Data; set => OcclusionMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> OcclusionMap_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SecondaryAlbedoTexture { get => SecondaryAlbedoTexture_Element.Data; set => SecondaryAlbedoTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> SecondaryAlbedoTexture_Element = new();
public UnityEngine.ColorX SecondaryEmissiveColor { get => SecondaryEmissiveColor_Element.Data; set => SecondaryEmissiveColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> SecondaryEmissiveColor_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SecondaryEmissiveMap { get => SecondaryEmissiveMap_Element.Data; set => SecondaryEmissiveMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> SecondaryEmissiveMap_Element = new();
public global::FrooxEngine.Culling Culling { get => Culling_Element.Data; set => Culling_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Culling>, global::FrooxEngine.Culling> Culling_Element = new();
public global::FrooxEngine.AlphaHandling AlphaHandling { get => AlphaHandling_Element.Data; set => AlphaHandling_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.AlphaHandling>, global::FrooxEngine.AlphaHandling> AlphaHandling_Element = new();
public global::System.Single AlphaClip { get => AlphaClip_Element.Data; set => AlphaClip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AlphaClip_Element = new();
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
members.Add("AlbedoScale", AlbedoScale_Element.Data.ToResoniteLinkField());
members.Add("AlbedoOffset", AlbedoOffset_Element.Data.ToResoniteLinkField());
members.Add("AlbedoUV", AlbedoUV_Element.Data.ToResoniteLinkField());
members.Add("EmissionMapScale", EmissionMapScale_Element.Data.ToResoniteLinkField());
members.Add("EmissionMapOffset", EmissionMapOffset_Element.Data.ToResoniteLinkField());
members.Add("EmissionMapUV", EmissionMapUV_Element.Data.ToResoniteLinkField());
members.Add("NormalMapScale", NormalMapScale_Element.Data.ToResoniteLinkField());
members.Add("NormalMapOffset", NormalMapOffset_Element.Data.ToResoniteLinkField());
members.Add("NormalMapUV", NormalMapUV_Element.Data.ToResoniteLinkField());
members.Add("OcclusionMapScale", OcclusionMapScale_Element.Data.ToResoniteLinkField());
members.Add("OcclusionMapOffset", OcclusionMapOffset_Element.Data.ToResoniteLinkField());
members.Add("OcclusionMapUV", OcclusionMapUV_Element.Data.ToResoniteLinkField());
members.Add("SecondaryAlbedoScale", SecondaryAlbedoScale_Element.Data.ToResoniteLinkField());
members.Add("SecondaryAlbedoOffset", SecondaryAlbedoOffset_Element.Data.ToResoniteLinkField());
members.Add("SecondaryAlbedoUV", SecondaryAlbedoUV_Element.Data.ToResoniteLinkField());
members.Add("SecondaryEmissionMapScale", SecondaryEmissionMapScale_Element.Data.ToResoniteLinkField());
members.Add("SecondaryEmissionMapOffset", SecondaryEmissionMapOffset_Element.Data.ToResoniteLinkField());
members.Add("SecondaryEmissionMapUV", SecondaryEmissionMapUV_Element.Data.ToResoniteLinkField());
members.Add("AlbedoColor", AlbedoColor_Element.Data.ToResoniteLinkField());
members.Add("AlbedoTexture", AlbedoTexture_Element.Data.ToResoniteReference(context));
members.Add("EmissiveColor", EmissiveColor_Element.Data.ToResoniteLinkField());
members.Add("EmissiveMap", EmissiveMap_Element.Data.ToResoniteReference(context));
members.Add("NormalMap", NormalMap_Element.Data.ToResoniteReference(context));
members.Add("NormalScale", NormalScale_Element.Data.ToResoniteLinkField());
members.Add("OcclusionMap", OcclusionMap_Element.Data.ToResoniteReference(context));
members.Add("SecondaryAlbedoTexture", SecondaryAlbedoTexture_Element.Data.ToResoniteReference(context));
members.Add("SecondaryEmissiveColor", SecondaryEmissiveColor_Element.Data.ToResoniteLinkField());
members.Add("SecondaryEmissiveMap", SecondaryEmissiveMap_Element.Data.ToResoniteReference(context));
members.Add("Culling", Culling_Element.Data.ToResoniteLinkField());
members.Add("AlphaHandling", AlphaHandling_Element.Data.ToResoniteLinkField());
members.Add("AlphaClip", AlphaClip_Element.Data.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor_Element.Data.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits_Element.Data.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue_Element.Data.ToResoniteLinkField());
}

}
}
