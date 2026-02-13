
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_Slice
// Generated on: pátek 13. února 2026 5:51:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_Slice")]
public abstract partial class PBS_Slice : global::FrooxEngine.MaterialProvider, global::FrooxEngine.IPBS_Material, global::FrooxEngine.ICullingMaterial

{
    public UnityEngine.Vector2 TextureScale;
public UnityEngine.Vector2 TextureOffset;
public UnityEngine.ColorX AlbedoColor;
public UnityEngine.ColorX EdgeColor;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture;
public UnityEngine.ColorX EmissiveColor;
public UnityEngine.ColorX EdgeEmissiveColor;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap;
public global::System.Single NormalScale;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OcclusionMap;
public UnityEngine.Vector2 DetailTextureScale;
public UnityEngine.Vector2 DetailTextureOffset;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> DetailAlbedoTexture;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> DetailNormalMap;
public global::System.Single DetailNormalScale;
public global::FrooxEngine.Culling Culling;
public global::System.Boolean HideSlicers;
public System.Collections.Generic.List<global::FrooxEngine.PBS_Slice.Slicer> Slicers;
public global::System.Boolean LocalSpace;
public global::System.Single EdgeTransitionStart;
public global::System.Single EdgeTransitionEnd;
public global::FrooxEngine.AlphaHandling AlphaHandling;
public global::System.Boolean _useAlphaClip;
public global::System.Single AlphaClip;
public global::System.Single OffsetFactor;
public global::System.Single OffsetUnits;
public global::System.Int32 RenderQueue;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TextureScale", TextureScale.ToResoniteLinkField());
members.Add("TextureOffset", TextureOffset.ToResoniteLinkField());
members.Add("AlbedoColor", AlbedoColor.ToResoniteLinkField());
members.Add("EdgeColor", EdgeColor.ToResoniteLinkField());
members.Add("AlbedoTexture", new ResoniteLink.Reference() { });
members.Add("EmissiveColor", EmissiveColor.ToResoniteLinkField());
members.Add("EdgeEmissiveColor", EdgeEmissiveColor.ToResoniteLinkField());
members.Add("EmissiveMap", new ResoniteLink.Reference() { });
members.Add("NormalMap", new ResoniteLink.Reference() { });
members.Add("NormalScale", NormalScale.ToResoniteLinkField());
members.Add("OcclusionMap", new ResoniteLink.Reference() { });
members.Add("DetailTextureScale", DetailTextureScale.ToResoniteLinkField());
members.Add("DetailTextureOffset", DetailTextureOffset.ToResoniteLinkField());
members.Add("DetailAlbedoTexture", new ResoniteLink.Reference() { });
members.Add("DetailNormalMap", new ResoniteLink.Reference() { });
members.Add("DetailNormalScale", DetailNormalScale.ToResoniteLinkField());
members.Add("Culling", Culling.ToResoniteLinkField());
members.Add("HideSlicers", HideSlicers.ToResoniteLinkField());
members.Add("Slicers", new ResoniteLink.SyncList()
{
    Elements = Slicers.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
members.Add("LocalSpace", LocalSpace.ToResoniteLinkField());
members.Add("EdgeTransitionStart", EdgeTransitionStart.ToResoniteLinkField());
members.Add("EdgeTransitionEnd", EdgeTransitionEnd.ToResoniteLinkField());
members.Add("AlphaHandling", AlphaHandling.ToResoniteLinkField());
members.Add("_useAlphaClip", _useAlphaClip.ToResoniteLinkField());
members.Add("AlphaClip", AlphaClip.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
}

}
}
