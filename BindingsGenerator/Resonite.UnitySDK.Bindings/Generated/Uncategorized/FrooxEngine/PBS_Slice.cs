
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_Slice
// Generated on: čtvrtek 26. února 2026 15:07:53
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_Slice")]
public abstract partial class PBS_Slice : global::FrooxEngine.MaterialProvider, global::FrooxEngine.IPBS_Material, global::FrooxEngine.ICullingMaterial

{
    public UnityEngine.Vector2 TextureScale { get => TextureScale_Element.Data; set => TextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TextureScale_Element = new();
public UnityEngine.Vector2 TextureOffset { get => TextureOffset_Element.Data; set => TextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TextureOffset_Element = new();
public UnityEngine.ColorX AlbedoColor { get => AlbedoColor_Element.Data; set => AlbedoColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> AlbedoColor_Element = new();
public UnityEngine.ColorX EdgeColor { get => EdgeColor_Element.Data; set => EdgeColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EdgeColor_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture { get => AlbedoTexture_Element.Data; set => AlbedoTexture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> AlbedoTexture_Element = new();
public UnityEngine.ColorX EmissiveColor { get => EmissiveColor_Element.Data; set => EmissiveColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EmissiveColor_Element = new();
public UnityEngine.ColorX EdgeEmissiveColor { get => EdgeEmissiveColor_Element.Data; set => EdgeEmissiveColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EdgeEmissiveColor_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap { get => EmissiveMap_Element.Data; set => EmissiveMap_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> EmissiveMap_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap { get => NormalMap_Element.Data; set => NormalMap_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> NormalMap_Element = new();
public global::System.Single NormalScale { get => NormalScale_Element.Data; set => NormalScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalScale_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OcclusionMap { get => OcclusionMap_Element.Data; set => OcclusionMap_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> OcclusionMap_Element = new();
public UnityEngine.Vector2 DetailTextureScale { get => DetailTextureScale_Element.Data; set => DetailTextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> DetailTextureScale_Element = new();
public UnityEngine.Vector2 DetailTextureOffset { get => DetailTextureOffset_Element.Data; set => DetailTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> DetailTextureOffset_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> DetailAlbedoTexture { get => DetailAlbedoTexture_Element.Data; set => DetailAlbedoTexture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> DetailAlbedoTexture_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> DetailNormalMap { get => DetailNormalMap_Element.Data; set => DetailNormalMap_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> DetailNormalMap_Element = new();
public global::System.Single DetailNormalScale { get => DetailNormalScale_Element.Data; set => DetailNormalScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DetailNormalScale_Element = new();
public global::FrooxEngine.Culling Culling { get => Culling_Element.Data; set => Culling_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Culling>, global::FrooxEngine.Culling> Culling_Element = new();
public global::System.Boolean HideSlicers { get => HideSlicers_Element.Data; set => HideSlicers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> HideSlicers_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.PBS_Slice.Slicer>, global::FrooxEngine.PBS_Slice.Slicer> Slicers = new();
public global::System.Boolean LocalSpace { get => LocalSpace_Element.Data; set => LocalSpace_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> LocalSpace_Element = new();
public global::System.Single EdgeTransitionStart { get => EdgeTransitionStart_Element.Data; set => EdgeTransitionStart_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EdgeTransitionStart_Element = new();
public global::System.Single EdgeTransitionEnd { get => EdgeTransitionEnd_Element.Data; set => EdgeTransitionEnd_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EdgeTransitionEnd_Element = new();
public global::FrooxEngine.AlphaHandling AlphaHandling { get => AlphaHandling_Element.Data; set => AlphaHandling_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.AlphaHandling>, global::FrooxEngine.AlphaHandling> AlphaHandling_Element = new();
public global::System.Boolean _useAlphaClip { get => _useAlphaClip_Element.Data; set => _useAlphaClip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _useAlphaClip_Element = new();
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
members.Add("EdgeColor", EdgeColor_Element.ToLinkField(context));
members.Add("AlbedoTexture", AlbedoTexture_Element.ToLinkReference(context));
members.Add("EmissiveColor", EmissiveColor_Element.ToLinkField(context));
members.Add("EdgeEmissiveColor", EdgeEmissiveColor_Element.ToLinkField(context));
members.Add("EmissiveMap", EmissiveMap_Element.ToLinkReference(context));
members.Add("NormalMap", NormalMap_Element.ToLinkReference(context));
members.Add("NormalScale", NormalScale_Element.ToLinkField(context));
members.Add("OcclusionMap", OcclusionMap_Element.ToLinkReference(context));
members.Add("DetailTextureScale", DetailTextureScale_Element.ToLinkField(context));
members.Add("DetailTextureOffset", DetailTextureOffset_Element.ToLinkField(context));
members.Add("DetailAlbedoTexture", DetailAlbedoTexture_Element.ToLinkReference(context));
members.Add("DetailNormalMap", DetailNormalMap_Element.ToLinkReference(context));
members.Add("DetailNormalScale", DetailNormalScale_Element.ToLinkField(context));
members.Add("Culling", Culling_Element.ToLinkField(context));
members.Add("HideSlicers", HideSlicers_Element.ToLinkField(context));
members.Add("Slicers", Slicers.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("LocalSpace", LocalSpace_Element.ToLinkField(context));
members.Add("EdgeTransitionStart", EdgeTransitionStart_Element.ToLinkField(context));
members.Add("EdgeTransitionEnd", EdgeTransitionEnd_Element.ToLinkField(context));
members.Add("AlphaHandling", AlphaHandling_Element.ToLinkField(context));
members.Add("_useAlphaClip", _useAlphaClip_Element.ToLinkField(context));
members.Add("AlphaClip", AlphaClip_Element.ToLinkField(context));
members.Add("OffsetFactor", OffsetFactor_Element.ToLinkField(context));
members.Add("OffsetUnits", OffsetUnits_Element.ToLinkField(context));
members.Add("RenderQueue", RenderQueue_Element.ToLinkField(context));
}

}
}
