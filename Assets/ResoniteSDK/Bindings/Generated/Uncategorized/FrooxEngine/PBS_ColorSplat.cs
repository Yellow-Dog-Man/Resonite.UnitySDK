
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_ColorSplat
// Generated on: sobota 14. února 2026 8:56:56
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_ColorSplat")]
public abstract partial class PBS_ColorSplat : global::FrooxEngine.SingleShaderMaterialProvider

{
    public global::System.Boolean MultiValue;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> ColorMap;
public UnityEngine.Vector2 ColorMapScale;
public UnityEngine.Vector2 ColorMapOffset;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> PackedHeightMap;
public global::System.Single HeightTransitionRange;
public UnityEngine.Vector2 TextureScale;
public UnityEngine.Vector2 TextureOffset;
public UnityEngine.ColorX AlbedoColor0;
public UnityEngine.ColorX AlbedoColor1;
public UnityEngine.ColorX AlbedoColor2;
public UnityEngine.ColorX AlbedoColor3;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture0;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture1;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture2;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture3;
public UnityEngine.ColorX EmissiveColor0;
public UnityEngine.ColorX EmissiveColor1;
public UnityEngine.ColorX EmissiveColor2;
public UnityEngine.ColorX EmissiveColor3;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap0;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap1;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap2;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap3;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> PackedEmissionMap;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> PackedNormalMap01;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> PackedNormalMap23;
public global::System.Single NormalScale0;
public global::System.Single NormalScale1;
public global::System.Single NormalScale2;
public global::System.Single NormalScale3;
public global::System.Single AlphaClip;
public global::System.Single OffsetFactor;
public global::System.Single OffsetUnits;
public global::System.Int32 RenderQueue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MultiValue", MultiValue.ToResoniteLinkField());
members.Add("ColorMap", ColorMap.ToResoniteReference(context));
members.Add("ColorMapScale", ColorMapScale.ToResoniteLinkField());
members.Add("ColorMapOffset", ColorMapOffset.ToResoniteLinkField());
members.Add("PackedHeightMap", PackedHeightMap.ToResoniteReference(context));
members.Add("HeightTransitionRange", HeightTransitionRange.ToResoniteLinkField());
members.Add("TextureScale", TextureScale.ToResoniteLinkField());
members.Add("TextureOffset", TextureOffset.ToResoniteLinkField());
members.Add("AlbedoColor0", AlbedoColor0.ToResoniteLinkField());
members.Add("AlbedoColor1", AlbedoColor1.ToResoniteLinkField());
members.Add("AlbedoColor2", AlbedoColor2.ToResoniteLinkField());
members.Add("AlbedoColor3", AlbedoColor3.ToResoniteLinkField());
members.Add("AlbedoTexture0", AlbedoTexture0.ToResoniteReference(context));
members.Add("AlbedoTexture1", AlbedoTexture1.ToResoniteReference(context));
members.Add("AlbedoTexture2", AlbedoTexture2.ToResoniteReference(context));
members.Add("AlbedoTexture3", AlbedoTexture3.ToResoniteReference(context));
members.Add("EmissiveColor0", EmissiveColor0.ToResoniteLinkField());
members.Add("EmissiveColor1", EmissiveColor1.ToResoniteLinkField());
members.Add("EmissiveColor2", EmissiveColor2.ToResoniteLinkField());
members.Add("EmissiveColor3", EmissiveColor3.ToResoniteLinkField());
members.Add("EmissiveMap0", EmissiveMap0.ToResoniteReference(context));
members.Add("EmissiveMap1", EmissiveMap1.ToResoniteReference(context));
members.Add("EmissiveMap2", EmissiveMap2.ToResoniteReference(context));
members.Add("EmissiveMap3", EmissiveMap3.ToResoniteReference(context));
members.Add("PackedEmissionMap", PackedEmissionMap.ToResoniteReference(context));
members.Add("PackedNormalMap01", PackedNormalMap01.ToResoniteReference(context));
members.Add("PackedNormalMap23", PackedNormalMap23.ToResoniteReference(context));
members.Add("NormalScale0", NormalScale0.ToResoniteLinkField());
members.Add("NormalScale1", NormalScale1.ToResoniteLinkField());
members.Add("NormalScale2", NormalScale2.ToResoniteLinkField());
members.Add("NormalScale3", NormalScale3.ToResoniteLinkField());
members.Add("AlphaClip", AlphaClip.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
}

}
}
