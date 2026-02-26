
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_DisplaceMaterial
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_DisplaceMaterial")]
public abstract partial class PBS_DisplaceMaterial : global::FrooxEngine.MaterialProvider, global::FrooxEngine.IPBS_Material, global::FrooxEngine.ICullingMaterial

{
    public UnityEngine.Vector2 TextureScale { get => TextureScale_Element.Data; set => TextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TextureScale_Element = new();
public UnityEngine.Vector2 TextureOffset { get => TextureOffset_Element.Data; set => TextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TextureOffset_Element = new();
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
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> VertexDisplaceMap { get => VertexDisplaceMap_Element.Data; set => VertexDisplaceMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> VertexDisplaceMap_Element = new();
public global::System.Single VertexDisplaceMagnitude { get => VertexDisplaceMagnitude_Element.Data; set => VertexDisplaceMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VertexDisplaceMagnitude_Element = new();
public global::System.Single VertexDisplaceBias { get => VertexDisplaceBias_Element.Data; set => VertexDisplaceBias_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VertexDisplaceBias_Element = new();
public UnityEngine.Vector2 VertexDisplaceMapScale { get => VertexDisplaceMapScale_Element.Data; set => VertexDisplaceMapScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> VertexDisplaceMapScale_Element = new();
public UnityEngine.Vector2 VertexDisplaceMapOffset { get => VertexDisplaceMapOffset_Element.Data; set => VertexDisplaceMapOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> VertexDisplaceMapOffset_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> UVDisplaceMap { get => UVDisplaceMap_Element.Data; set => UVDisplaceMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> UVDisplaceMap_Element = new();
public global::System.Single UVDisplaceMagnitude { get => UVDisplaceMagnitude_Element.Data; set => UVDisplaceMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> UVDisplaceMagnitude_Element = new();
public global::System.Single UVDisplaceBias { get => UVDisplaceBias_Element.Data; set => UVDisplaceBias_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> UVDisplaceBias_Element = new();
public UnityEngine.Vector2 UVDisplaceMapScale { get => UVDisplaceMapScale_Element.Data; set => UVDisplaceMapScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UVDisplaceMapScale_Element = new();
public UnityEngine.Vector2 UVDisplaceMapOffset { get => UVDisplaceMapOffset_Element.Data; set => UVDisplaceMapOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UVDisplaceMapOffset_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> WorldspaceVertexOffsetMap { get => WorldspaceVertexOffsetMap_Element.Data; set => WorldspaceVertexOffsetMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> WorldspaceVertexOffsetMap_Element = new();
public UnityEngine.Vector2 WorldspaceOffsetMagnitude { get => WorldspaceOffsetMagnitude_Element.Data; set => WorldspaceOffsetMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> WorldspaceOffsetMagnitude_Element = new();
public UnityEngine.Vector2 WorldspaceVertexOffsetMapScale { get => WorldspaceVertexOffsetMapScale_Element.Data; set => WorldspaceVertexOffsetMapScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> WorldspaceVertexOffsetMapScale_Element = new();
public UnityEngine.Vector2 WorldspaceVertexOffsetMapOffset { get => WorldspaceVertexOffsetMapOffset_Element.Data; set => WorldspaceVertexOffsetMapOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> WorldspaceVertexOffsetMapOffset_Element = new();
public global::System.Boolean WorldspaceOffsetPerVertex { get => WorldspaceOffsetPerVertex_Element.Data; set => WorldspaceOffsetPerVertex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> WorldspaceOffsetPerVertex_Element = new();
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
members.Add("TextureScale", TextureScale_Element.ToLinkField(context));
members.Add("TextureOffset", TextureOffset_Element.ToLinkField(context));
members.Add("AlbedoColor", AlbedoColor_Element.ToLinkField(context));
members.Add("AlbedoTexture", AlbedoTexture_Element.ToLinkReference(context));
members.Add("EmissiveColor", EmissiveColor_Element.ToLinkField(context));
members.Add("EmissiveMap", EmissiveMap_Element.ToLinkReference(context));
members.Add("NormalMap", NormalMap_Element.ToLinkReference(context));
members.Add("NormalScale", NormalScale_Element.ToLinkField(context));
members.Add("OcclusionMap", OcclusionMap_Element.ToLinkReference(context));
members.Add("VertexDisplaceMap", VertexDisplaceMap_Element.ToLinkReference(context));
members.Add("VertexDisplaceMagnitude", VertexDisplaceMagnitude_Element.ToLinkField(context));
members.Add("VertexDisplaceBias", VertexDisplaceBias_Element.ToLinkField(context));
members.Add("VertexDisplaceMapScale", VertexDisplaceMapScale_Element.ToLinkField(context));
members.Add("VertexDisplaceMapOffset", VertexDisplaceMapOffset_Element.ToLinkField(context));
members.Add("UVDisplaceMap", UVDisplaceMap_Element.ToLinkReference(context));
members.Add("UVDisplaceMagnitude", UVDisplaceMagnitude_Element.ToLinkField(context));
members.Add("UVDisplaceBias", UVDisplaceBias_Element.ToLinkField(context));
members.Add("UVDisplaceMapScale", UVDisplaceMapScale_Element.ToLinkField(context));
members.Add("UVDisplaceMapOffset", UVDisplaceMapOffset_Element.ToLinkField(context));
members.Add("WorldspaceVertexOffsetMap", WorldspaceVertexOffsetMap_Element.ToLinkReference(context));
members.Add("WorldspaceOffsetMagnitude", WorldspaceOffsetMagnitude_Element.ToLinkField(context));
members.Add("WorldspaceVertexOffsetMapScale", WorldspaceVertexOffsetMapScale_Element.ToLinkField(context));
members.Add("WorldspaceVertexOffsetMapOffset", WorldspaceVertexOffsetMapOffset_Element.ToLinkField(context));
members.Add("WorldspaceOffsetPerVertex", WorldspaceOffsetPerVertex_Element.ToLinkField(context));
members.Add("Culling", Culling_Element.ToLinkField(context));
members.Add("AlphaHandling", AlphaHandling_Element.ToLinkField(context));
members.Add("AlphaClip", AlphaClip_Element.ToLinkField(context));
members.Add("OffsetFactor", OffsetFactor_Element.ToLinkField(context));
members.Add("OffsetUnits", OffsetUnits_Element.ToLinkField(context));
members.Add("RenderQueue", RenderQueue_Element.ToLinkField(context));
}

}
}
