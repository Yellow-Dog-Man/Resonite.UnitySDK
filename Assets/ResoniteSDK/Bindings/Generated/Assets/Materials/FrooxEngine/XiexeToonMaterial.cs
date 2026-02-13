
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.XiexeToonMaterial
// Generated on: pátek 13. února 2026 5:51:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.XiexeToonMaterial")]
public partial class XiexeToonMaterial : global::FrooxEngine.MaterialProvider, global::FrooxEngine.ICommonMaterial, global::FrooxEngine.ICullingMaterial

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MainTexture;
public UnityEngine.ColorX Color;
public global::System.Boolean UseVertexColors;
public global::Renderite.Shared.ColorProfile VertexColorInterpolationSpace;
public global::FrooxEngine.BlendMode BlendMode;
public global::FrooxEngine.ZWrite ZWrite;
public global::System.Single AlphaClip;
public UnityEngine.Vector2 MainTextureScale;
public UnityEngine.Vector2 MainTextureOffset;
public global::System.Single Saturation;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap;
public UnityEngine.Vector2 NormalMapScale;
public UnityEngine.Vector2 NormalMapOffset;
public global::System.Single NormalScale;
public global::System.Single Metallic;
public global::System.Single Glossiness;
public global::System.Single Reflectivity;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MetallicGlossMap;
public UnityEngine.Vector2 MetallicGlossMapScale;
public UnityEngine.Vector2 MetallicGlossMapOffset;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissionMap;
public UnityEngine.ColorX EmissionColor;
public UnityEngine.Vector2 EmissionMapScale;
public UnityEngine.Vector2 EmissionMapOffset;
public UnityEngine.ColorX RimColor;
public global::System.Single RimAlbedoTint;
public global::System.Single RimAttenuationEffect;
public global::System.Single RimIntensity;
public global::System.Single RimRange;
public global::System.Single RimThreshold;
public global::System.Single RimSharpness;
public global::System.Single SpecularIntensity;
public global::System.Single SpecularArea;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Matcap;
public UnityEngine.ColorX MatcapTint;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OcclusionMap;
public UnityEngine.Vector2 OcclusionMapScale;
public UnityEngine.Vector2 OcclusionMapOffset;
public UnityEngine.ColorX OcclusionColor;
public global::FrooxEngine.XiexeToonMaterial.OutlineStyle Outline;
public global::System.Single OutlineWidth;
public UnityEngine.ColorX OutlineColor;
public global::System.Boolean OutlineAlbedoTint;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OutlineMask;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> ShadowRamp;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> ShadowRampMask;
public UnityEngine.Vector2 ShadowRampMaskScale;
public UnityEngine.Vector2 ShadowRampMaskOffset;
public UnityEngine.ColorX ShadowRim;
public global::System.Single ShadowSharpness;
public global::System.Single ShadowRimRange;
public global::System.Single ShadowRimThreshold;
public global::System.Single ShadowRimSharpness;
public global::System.Single ShadowRimAlbedoTint;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> ThicknessMap;
public UnityEngine.Vector2 ThicknessMapScale;
public UnityEngine.Vector2 ThicknessMapOffset;
public UnityEngine.ColorX SubsurfaceColor;
public global::System.Single SubsurfaceDistortion;
public global::System.Single SubsurfacePower;
public global::System.Single SubsurfaceScale;
public global::System.Single OffsetFactor;
public global::System.Single OffsetUnits;
public global::FrooxEngine.Culling Culling;
public global::FrooxEngine.ColorMask ColorMask;
public global::System.Int32 AlbedoUV;
public global::System.Int32 NormalUV;
public global::System.Int32 MetallicUV;
public global::System.Int32 ThicknessUV;
public global::System.Int32 OcclusionUV;
public global::System.Int32 EmissionUV;
public global::System.Int32 RenderQueue;
public global::System.Boolean __legacyCutout;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _regular;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _outline;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("MainTexture", new ResoniteLink.Reference() { });
members.Add("Color", Color.ToResoniteLinkField());
members.Add("UseVertexColors", UseVertexColors.ToResoniteLinkField());
members.Add("VertexColorInterpolationSpace", VertexColorInterpolationSpace.ToResoniteLinkField());
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("ZWrite", ZWrite.ToResoniteLinkField());
members.Add("AlphaClip", AlphaClip.ToResoniteLinkField());
members.Add("MainTextureScale", MainTextureScale.ToResoniteLinkField());
members.Add("MainTextureOffset", MainTextureOffset.ToResoniteLinkField());
members.Add("Saturation", Saturation.ToResoniteLinkField());
members.Add("NormalMap", new ResoniteLink.Reference() { });
members.Add("NormalMapScale", NormalMapScale.ToResoniteLinkField());
members.Add("NormalMapOffset", NormalMapOffset.ToResoniteLinkField());
members.Add("NormalScale", NormalScale.ToResoniteLinkField());
members.Add("Metallic", Metallic.ToResoniteLinkField());
members.Add("Glossiness", Glossiness.ToResoniteLinkField());
members.Add("Reflectivity", Reflectivity.ToResoniteLinkField());
members.Add("MetallicGlossMap", new ResoniteLink.Reference() { });
members.Add("MetallicGlossMapScale", MetallicGlossMapScale.ToResoniteLinkField());
members.Add("MetallicGlossMapOffset", MetallicGlossMapOffset.ToResoniteLinkField());
members.Add("EmissionMap", new ResoniteLink.Reference() { });
members.Add("EmissionColor", EmissionColor.ToResoniteLinkField());
members.Add("EmissionMapScale", EmissionMapScale.ToResoniteLinkField());
members.Add("EmissionMapOffset", EmissionMapOffset.ToResoniteLinkField());
members.Add("RimColor", RimColor.ToResoniteLinkField());
members.Add("RimAlbedoTint", RimAlbedoTint.ToResoniteLinkField());
members.Add("RimAttenuationEffect", RimAttenuationEffect.ToResoniteLinkField());
members.Add("RimIntensity", RimIntensity.ToResoniteLinkField());
members.Add("RimRange", RimRange.ToResoniteLinkField());
members.Add("RimThreshold", RimThreshold.ToResoniteLinkField());
members.Add("RimSharpness", RimSharpness.ToResoniteLinkField());
members.Add("SpecularIntensity", SpecularIntensity.ToResoniteLinkField());
members.Add("SpecularArea", SpecularArea.ToResoniteLinkField());
members.Add("Matcap", new ResoniteLink.Reference() { });
members.Add("MatcapTint", MatcapTint.ToResoniteLinkField());
members.Add("OcclusionMap", new ResoniteLink.Reference() { });
members.Add("OcclusionMapScale", OcclusionMapScale.ToResoniteLinkField());
members.Add("OcclusionMapOffset", OcclusionMapOffset.ToResoniteLinkField());
members.Add("OcclusionColor", OcclusionColor.ToResoniteLinkField());
members.Add("Outline", Outline.ToResoniteLinkField());
members.Add("OutlineWidth", OutlineWidth.ToResoniteLinkField());
members.Add("OutlineColor", OutlineColor.ToResoniteLinkField());
members.Add("OutlineAlbedoTint", OutlineAlbedoTint.ToResoniteLinkField());
members.Add("OutlineMask", new ResoniteLink.Reference() { });
members.Add("ShadowRamp", new ResoniteLink.Reference() { });
members.Add("ShadowRampMask", new ResoniteLink.Reference() { });
members.Add("ShadowRampMaskScale", ShadowRampMaskScale.ToResoniteLinkField());
members.Add("ShadowRampMaskOffset", ShadowRampMaskOffset.ToResoniteLinkField());
members.Add("ShadowRim", ShadowRim.ToResoniteLinkField());
members.Add("ShadowSharpness", ShadowSharpness.ToResoniteLinkField());
members.Add("ShadowRimRange", ShadowRimRange.ToResoniteLinkField());
members.Add("ShadowRimThreshold", ShadowRimThreshold.ToResoniteLinkField());
members.Add("ShadowRimSharpness", ShadowRimSharpness.ToResoniteLinkField());
members.Add("ShadowRimAlbedoTint", ShadowRimAlbedoTint.ToResoniteLinkField());
members.Add("ThicknessMap", new ResoniteLink.Reference() { });
members.Add("ThicknessMapScale", ThicknessMapScale.ToResoniteLinkField());
members.Add("ThicknessMapOffset", ThicknessMapOffset.ToResoniteLinkField());
members.Add("SubsurfaceColor", SubsurfaceColor.ToResoniteLinkField());
members.Add("SubsurfaceDistortion", SubsurfaceDistortion.ToResoniteLinkField());
members.Add("SubsurfacePower", SubsurfacePower.ToResoniteLinkField());
members.Add("SubsurfaceScale", SubsurfaceScale.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
members.Add("Culling", Culling.ToResoniteLinkField());
members.Add("ColorMask", ColorMask.ToResoniteLinkField());
members.Add("AlbedoUV", AlbedoUV.ToResoniteLinkField());
members.Add("NormalUV", NormalUV.ToResoniteLinkField());
members.Add("MetallicUV", MetallicUV.ToResoniteLinkField());
members.Add("ThicknessUV", ThicknessUV.ToResoniteLinkField());
members.Add("OcclusionUV", OcclusionUV.ToResoniteLinkField());
members.Add("EmissionUV", EmissionUV.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
members.Add("__legacyCutout", __legacyCutout.ToResoniteLinkField());
members.Add("_regular", new ResoniteLink.Reference() { });
members.Add("_outline", new ResoniteLink.Reference() { });
}

}
}
