
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_StencilMaterial
// Generated on: středa 25. února 2026 16:13:03
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_StencilMaterial")]
public abstract partial class PBS_StencilMaterial : global::FrooxEngine.MaterialProvider, global::FrooxEngine.IUIX_Material

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
public global::FrooxEngine.ColorMask ColorMask;
public global::FrooxEngine.StencilComparison StencilComparison;
public global::FrooxEngine.StencilOperation StencilOperation;
public global::System.Byte StencilID;
public global::System.Byte StencilWriteMask;
public global::System.Byte StencilReadMask;
public global::System.Single OffsetFactor;
public global::System.Single OffsetUnits;
public global::System.Int32 RenderQueue;
public UnityEngine.Rect __rectDummy;
public global::System.Boolean __rectClipDummy;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TextureScale", TextureScale.ToResoniteLinkField());
members.Add("TextureOffset", TextureOffset.ToResoniteLinkField());
members.Add("AlbedoColor", AlbedoColor.ToResoniteLinkField());
members.Add("AlbedoTexture", AlbedoTexture.ToResoniteReference(context));
members.Add("EmissiveColor", EmissiveColor.ToResoniteLinkField());
members.Add("EmissiveMap", EmissiveMap.ToResoniteReference(context));
members.Add("NormalMap", NormalMap.ToResoniteReference(context));
members.Add("NormalScale", NormalScale.ToResoniteLinkField());
members.Add("OcclusionMap", OcclusionMap.ToResoniteReference(context));
members.Add("ColorMask", ColorMask.ToResoniteLinkField());
members.Add("StencilComparison", StencilComparison.ToResoniteLinkField());
members.Add("StencilOperation", StencilOperation.ToResoniteLinkField());
members.Add("StencilID", StencilID.ToResoniteLinkField());
members.Add("StencilWriteMask", StencilWriteMask.ToResoniteLinkField());
members.Add("StencilReadMask", StencilReadMask.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
members.Add("__rectDummy", __rectDummy.ToResoniteLinkField());
members.Add("__rectClipDummy", __rectClipDummy.ToResoniteLinkField());
}

}
}
