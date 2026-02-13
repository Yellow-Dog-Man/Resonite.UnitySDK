
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_VertexColor
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_VertexColor")]
public abstract partial class PBS_VertexColor : global::FrooxEngine.MaterialProvider, global::FrooxEngine.IPBS_Material, global::FrooxEngine.ICullingMaterial

{
    public UnityEngine.Vector2 TextureScale;
public UnityEngine.Vector2 TextureOffset;
public UnityEngine.ColorX AlbedoColor;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture;
public UnityEngine.ColorX EmissiveColor;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap;
public global::System.Single NormalScale;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OcclusionMap;
public global::Renderite.Shared.ColorProfile VertexColorInterpolationSpace;
public global::FrooxEngine.Culling Culling;
public global::FrooxEngine.AlphaHandling AlphaHandling;
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
members.Add("AlbedoTexture", new ResoniteLink.Reference() { });
members.Add("EmissiveColor", EmissiveColor.ToResoniteLinkField());
members.Add("EmissiveMap", new ResoniteLink.Reference() { });
members.Add("NormalMap", new ResoniteLink.Reference() { });
members.Add("NormalScale", NormalScale.ToResoniteLinkField());
members.Add("OcclusionMap", new ResoniteLink.Reference() { });
members.Add("VertexColorInterpolationSpace", VertexColorInterpolationSpace.ToResoniteLinkField());
members.Add("Culling", Culling.ToResoniteLinkField());
members.Add("AlphaHandling", AlphaHandling.ToResoniteLinkField());
members.Add("AlphaClip", AlphaClip.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
}

}
}
