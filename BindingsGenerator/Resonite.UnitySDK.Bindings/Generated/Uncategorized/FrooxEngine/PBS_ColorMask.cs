
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_ColorMask
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_ColorMask")]
public abstract partial class PBS_ColorMask : global::FrooxEngine.SingleShaderMaterialProvider

{
    public UnityEngine.Vector2 TextureScale;
public UnityEngine.Vector2 TextureOffset;
public UnityEngine.Vector2 ColorMaskScale;
public UnityEngine.Vector2 ColorMaskOffset;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> ColorMask;
public UnityEngine.ColorX AlbedoColor0;
public UnityEngine.ColorX AlbedoColor1;
public UnityEngine.ColorX AlbedoColor2;
public UnityEngine.ColorX AlbedoColor3;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture;
public UnityEngine.ColorX EmissiveColor0;
public UnityEngine.ColorX EmissiveColor1;
public UnityEngine.ColorX EmissiveColor2;
public UnityEngine.ColorX EmissiveColor3;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap;
public global::System.Single NormalScale;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OcclusionMap;
public global::System.Boolean Transparent;
public global::System.Boolean ForceZWrite;
public global::System.Single OffsetFactor;
public global::System.Single OffsetUnits;
public global::System.Int32 RenderQueue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TextureScale", TextureScale.ToResoniteLinkField());
members.Add("TextureOffset", TextureOffset.ToResoniteLinkField());
members.Add("ColorMaskScale", ColorMaskScale.ToResoniteLinkField());
members.Add("ColorMaskOffset", ColorMaskOffset.ToResoniteLinkField());
members.Add("ColorMask", ColorMask.ToResoniteReference(context));
members.Add("AlbedoColor0", AlbedoColor0.ToResoniteLinkField());
members.Add("AlbedoColor1", AlbedoColor1.ToResoniteLinkField());
members.Add("AlbedoColor2", AlbedoColor2.ToResoniteLinkField());
members.Add("AlbedoColor3", AlbedoColor3.ToResoniteLinkField());
members.Add("AlbedoTexture", AlbedoTexture.ToResoniteReference(context));
members.Add("EmissiveColor0", EmissiveColor0.ToResoniteLinkField());
members.Add("EmissiveColor1", EmissiveColor1.ToResoniteLinkField());
members.Add("EmissiveColor2", EmissiveColor2.ToResoniteLinkField());
members.Add("EmissiveColor3", EmissiveColor3.ToResoniteLinkField());
members.Add("EmissiveMap", EmissiveMap.ToResoniteReference(context));
members.Add("NormalMap", NormalMap.ToResoniteReference(context));
members.Add("NormalScale", NormalScale.ToResoniteLinkField());
members.Add("OcclusionMap", OcclusionMap.ToResoniteReference(context));
members.Add("Transparent", Transparent.ToResoniteLinkField());
members.Add("ForceZWrite", ForceZWrite.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
}

}
}
