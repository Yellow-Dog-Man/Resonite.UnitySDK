
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.XiexeToonMaterial
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.XiexeToonMaterial")]
public partial class XiexeToonMaterial : global::FrooxEngine.MaterialProvider, global::FrooxEngine.ICommonMaterial, global::FrooxEngine.ICullingMaterial

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MainTexture { get => MainTexture_Element.Data; set => MainTexture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> MainTexture_Element = new();
public UnityEngine.ColorX Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color_Element = new();
public global::System.Boolean UseVertexColors { get => UseVertexColors_Element.Data; set => UseVertexColors_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseVertexColors_Element = new();
public global::Renderite.Shared.ColorProfile VertexColorInterpolationSpace { get => VertexColorInterpolationSpace_Element.Data; set => VertexColorInterpolationSpace_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.ColorProfile>, global::Renderite.Shared.ColorProfile> VertexColorInterpolationSpace_Element = new();
public global::FrooxEngine.BlendMode BlendMode { get => BlendMode_Element.Data; set => BlendMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.BlendMode>, global::FrooxEngine.BlendMode> BlendMode_Element = new();
public global::FrooxEngine.ZWrite ZWrite { get => ZWrite_Element.Data; set => ZWrite_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZWrite>, global::FrooxEngine.ZWrite> ZWrite_Element = new();
public global::System.Single AlphaClip { get => AlphaClip_Element.Data; set => AlphaClip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AlphaClip_Element = new();
public UnityEngine.Vector2 MainTextureScale { get => MainTextureScale_Element.Data; set => MainTextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> MainTextureScale_Element = new();
public UnityEngine.Vector2 MainTextureOffset { get => MainTextureOffset_Element.Data; set => MainTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> MainTextureOffset_Element = new();
public global::System.Single Saturation { get => Saturation_Element.Data; set => Saturation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Saturation_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap { get => NormalMap_Element.Data; set => NormalMap_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> NormalMap_Element = new();
public UnityEngine.Vector2 NormalMapScale { get => NormalMapScale_Element.Data; set => NormalMapScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> NormalMapScale_Element = new();
public UnityEngine.Vector2 NormalMapOffset { get => NormalMapOffset_Element.Data; set => NormalMapOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> NormalMapOffset_Element = new();
public global::System.Single NormalScale { get => NormalScale_Element.Data; set => NormalScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalScale_Element = new();
public global::System.Single Metallic { get => Metallic_Element.Data; set => Metallic_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Metallic_Element = new();
public global::System.Single Glossiness { get => Glossiness_Element.Data; set => Glossiness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Glossiness_Element = new();
public global::System.Single Reflectivity { get => Reflectivity_Element.Data; set => Reflectivity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Reflectivity_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MetallicGlossMap { get => MetallicGlossMap_Element.Data; set => MetallicGlossMap_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> MetallicGlossMap_Element = new();
public UnityEngine.Vector2 MetallicGlossMapScale { get => MetallicGlossMapScale_Element.Data; set => MetallicGlossMapScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> MetallicGlossMapScale_Element = new();
public UnityEngine.Vector2 MetallicGlossMapOffset { get => MetallicGlossMapOffset_Element.Data; set => MetallicGlossMapOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> MetallicGlossMapOffset_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissionMap { get => EmissionMap_Element.Data; set => EmissionMap_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> EmissionMap_Element = new();
public UnityEngine.ColorX EmissionColor { get => EmissionColor_Element.Data; set => EmissionColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EmissionColor_Element = new();
public UnityEngine.Vector2 EmissionMapScale { get => EmissionMapScale_Element.Data; set => EmissionMapScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> EmissionMapScale_Element = new();
public UnityEngine.Vector2 EmissionMapOffset { get => EmissionMapOffset_Element.Data; set => EmissionMapOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> EmissionMapOffset_Element = new();
public UnityEngine.ColorX RimColor { get => RimColor_Element.Data; set => RimColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> RimColor_Element = new();
public global::System.Single RimAlbedoTint { get => RimAlbedoTint_Element.Data; set => RimAlbedoTint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RimAlbedoTint_Element = new();
public global::System.Single RimAttenuationEffect { get => RimAttenuationEffect_Element.Data; set => RimAttenuationEffect_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RimAttenuationEffect_Element = new();
public global::System.Single RimIntensity { get => RimIntensity_Element.Data; set => RimIntensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RimIntensity_Element = new();
public global::System.Single RimRange { get => RimRange_Element.Data; set => RimRange_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RimRange_Element = new();
public global::System.Single RimThreshold { get => RimThreshold_Element.Data; set => RimThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RimThreshold_Element = new();
public global::System.Single RimSharpness { get => RimSharpness_Element.Data; set => RimSharpness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RimSharpness_Element = new();
public global::System.Single SpecularIntensity { get => SpecularIntensity_Element.Data; set => SpecularIntensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SpecularIntensity_Element = new();
public global::System.Single SpecularArea { get => SpecularArea_Element.Data; set => SpecularArea_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SpecularArea_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Matcap { get => Matcap_Element.Data; set => Matcap_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> Matcap_Element = new();
public UnityEngine.ColorX MatcapTint { get => MatcapTint_Element.Data; set => MatcapTint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> MatcapTint_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OcclusionMap { get => OcclusionMap_Element.Data; set => OcclusionMap_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> OcclusionMap_Element = new();
public UnityEngine.Vector2 OcclusionMapScale { get => OcclusionMapScale_Element.Data; set => OcclusionMapScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> OcclusionMapScale_Element = new();
public UnityEngine.Vector2 OcclusionMapOffset { get => OcclusionMapOffset_Element.Data; set => OcclusionMapOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> OcclusionMapOffset_Element = new();
public UnityEngine.ColorX OcclusionColor { get => OcclusionColor_Element.Data; set => OcclusionColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> OcclusionColor_Element = new();
public global::FrooxEngine.XiexeToonMaterial.OutlineStyle Outline { get => Outline_Element.Data; set => Outline_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.XiexeToonMaterial.OutlineStyle>, global::FrooxEngine.XiexeToonMaterial.OutlineStyle> Outline_Element = new();
public global::System.Single OutlineWidth { get => OutlineWidth_Element.Data; set => OutlineWidth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OutlineWidth_Element = new();
public UnityEngine.ColorX OutlineColor { get => OutlineColor_Element.Data; set => OutlineColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> OutlineColor_Element = new();
public global::System.Boolean OutlineAlbedoTint { get => OutlineAlbedoTint_Element.Data; set => OutlineAlbedoTint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OutlineAlbedoTint_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OutlineMask { get => OutlineMask_Element.Data; set => OutlineMask_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> OutlineMask_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> ShadowRamp { get => ShadowRamp_Element.Data; set => ShadowRamp_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> ShadowRamp_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> ShadowRampMask { get => ShadowRampMask_Element.Data; set => ShadowRampMask_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> ShadowRampMask_Element = new();
public UnityEngine.Vector2 ShadowRampMaskScale { get => ShadowRampMaskScale_Element.Data; set => ShadowRampMaskScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> ShadowRampMaskScale_Element = new();
public UnityEngine.Vector2 ShadowRampMaskOffset { get => ShadowRampMaskOffset_Element.Data; set => ShadowRampMaskOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> ShadowRampMaskOffset_Element = new();
public UnityEngine.ColorX ShadowRim { get => ShadowRim_Element.Data; set => ShadowRim_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> ShadowRim_Element = new();
public global::System.Single ShadowSharpness { get => ShadowSharpness_Element.Data; set => ShadowSharpness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ShadowSharpness_Element = new();
public global::System.Single ShadowRimRange { get => ShadowRimRange_Element.Data; set => ShadowRimRange_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ShadowRimRange_Element = new();
public global::System.Single ShadowRimThreshold { get => ShadowRimThreshold_Element.Data; set => ShadowRimThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ShadowRimThreshold_Element = new();
public global::System.Single ShadowRimSharpness { get => ShadowRimSharpness_Element.Data; set => ShadowRimSharpness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ShadowRimSharpness_Element = new();
public global::System.Single ShadowRimAlbedoTint { get => ShadowRimAlbedoTint_Element.Data; set => ShadowRimAlbedoTint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ShadowRimAlbedoTint_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> ThicknessMap { get => ThicknessMap_Element.Data; set => ThicknessMap_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> ThicknessMap_Element = new();
public UnityEngine.Vector2 ThicknessMapScale { get => ThicknessMapScale_Element.Data; set => ThicknessMapScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> ThicknessMapScale_Element = new();
public UnityEngine.Vector2 ThicknessMapOffset { get => ThicknessMapOffset_Element.Data; set => ThicknessMapOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> ThicknessMapOffset_Element = new();
public UnityEngine.ColorX SubsurfaceColor { get => SubsurfaceColor_Element.Data; set => SubsurfaceColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> SubsurfaceColor_Element = new();
public global::System.Single SubsurfaceDistortion { get => SubsurfaceDistortion_Element.Data; set => SubsurfaceDistortion_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SubsurfaceDistortion_Element = new();
public global::System.Single SubsurfacePower { get => SubsurfacePower_Element.Data; set => SubsurfacePower_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SubsurfacePower_Element = new();
public global::System.Single SubsurfaceScale { get => SubsurfaceScale_Element.Data; set => SubsurfaceScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SubsurfaceScale_Element = new();
public global::System.Single OffsetFactor { get => OffsetFactor_Element.Data; set => OffsetFactor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetFactor_Element = new();
public global::System.Single OffsetUnits { get => OffsetUnits_Element.Data; set => OffsetUnits_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetUnits_Element = new();
public global::FrooxEngine.Culling Culling { get => Culling_Element.Data; set => Culling_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Culling>, global::FrooxEngine.Culling> Culling_Element = new();
public global::FrooxEngine.ColorMask ColorMask { get => ColorMask_Element.Data; set => ColorMask_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ColorMask>, global::FrooxEngine.ColorMask> ColorMask_Element = new();
public global::System.Int32 AlbedoUV { get => AlbedoUV_Element.Data; set => AlbedoUV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> AlbedoUV_Element = new();
public global::System.Int32 NormalUV { get => NormalUV_Element.Data; set => NormalUV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> NormalUV_Element = new();
public global::System.Int32 MetallicUV { get => MetallicUV_Element.Data; set => MetallicUV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MetallicUV_Element = new();
public global::System.Int32 ThicknessUV { get => ThicknessUV_Element.Data; set => ThicknessUV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> ThicknessUV_Element = new();
public global::System.Int32 OcclusionUV { get => OcclusionUV_Element.Data; set => OcclusionUV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> OcclusionUV_Element = new();
public global::System.Int32 EmissionUV { get => EmissionUV_Element.Data; set => EmissionUV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> EmissionUV_Element = new();
public global::System.Int32 RenderQueue { get => RenderQueue_Element.Data; set => RenderQueue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> RenderQueue_Element = new();
public global::System.Boolean __legacyCutout { get => __legacyCutout_Element.Data; set => __legacyCutout_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> __legacyCutout_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _regular { get => _regular_Element.Data; set => _regular_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Shader>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader>> _regular_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _outline { get => _outline_Element.Data; set => _outline_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Shader>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader>> _outline_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MainTexture", MainTexture_Element.ToLinkReference(context));
members.Add("Color", Color_Element.ToLinkField(context));
members.Add("UseVertexColors", UseVertexColors_Element.ToLinkField(context));
members.Add("VertexColorInterpolationSpace", VertexColorInterpolationSpace_Element.ToLinkField(context));
members.Add("BlendMode", BlendMode_Element.ToLinkField(context));
members.Add("ZWrite", ZWrite_Element.ToLinkField(context));
members.Add("AlphaClip", AlphaClip_Element.ToLinkField(context));
members.Add("MainTextureScale", MainTextureScale_Element.ToLinkField(context));
members.Add("MainTextureOffset", MainTextureOffset_Element.ToLinkField(context));
members.Add("Saturation", Saturation_Element.ToLinkField(context));
members.Add("NormalMap", NormalMap_Element.ToLinkReference(context));
members.Add("NormalMapScale", NormalMapScale_Element.ToLinkField(context));
members.Add("NormalMapOffset", NormalMapOffset_Element.ToLinkField(context));
members.Add("NormalScale", NormalScale_Element.ToLinkField(context));
members.Add("Metallic", Metallic_Element.ToLinkField(context));
members.Add("Glossiness", Glossiness_Element.ToLinkField(context));
members.Add("Reflectivity", Reflectivity_Element.ToLinkField(context));
members.Add("MetallicGlossMap", MetallicGlossMap_Element.ToLinkReference(context));
members.Add("MetallicGlossMapScale", MetallicGlossMapScale_Element.ToLinkField(context));
members.Add("MetallicGlossMapOffset", MetallicGlossMapOffset_Element.ToLinkField(context));
members.Add("EmissionMap", EmissionMap_Element.ToLinkReference(context));
members.Add("EmissionColor", EmissionColor_Element.ToLinkField(context));
members.Add("EmissionMapScale", EmissionMapScale_Element.ToLinkField(context));
members.Add("EmissionMapOffset", EmissionMapOffset_Element.ToLinkField(context));
members.Add("RimColor", RimColor_Element.ToLinkField(context));
members.Add("RimAlbedoTint", RimAlbedoTint_Element.ToLinkField(context));
members.Add("RimAttenuationEffect", RimAttenuationEffect_Element.ToLinkField(context));
members.Add("RimIntensity", RimIntensity_Element.ToLinkField(context));
members.Add("RimRange", RimRange_Element.ToLinkField(context));
members.Add("RimThreshold", RimThreshold_Element.ToLinkField(context));
members.Add("RimSharpness", RimSharpness_Element.ToLinkField(context));
members.Add("SpecularIntensity", SpecularIntensity_Element.ToLinkField(context));
members.Add("SpecularArea", SpecularArea_Element.ToLinkField(context));
members.Add("Matcap", Matcap_Element.ToLinkReference(context));
members.Add("MatcapTint", MatcapTint_Element.ToLinkField(context));
members.Add("OcclusionMap", OcclusionMap_Element.ToLinkReference(context));
members.Add("OcclusionMapScale", OcclusionMapScale_Element.ToLinkField(context));
members.Add("OcclusionMapOffset", OcclusionMapOffset_Element.ToLinkField(context));
members.Add("OcclusionColor", OcclusionColor_Element.ToLinkField(context));
members.Add("Outline", Outline_Element.ToLinkField(context));
members.Add("OutlineWidth", OutlineWidth_Element.ToLinkField(context));
members.Add("OutlineColor", OutlineColor_Element.ToLinkField(context));
members.Add("OutlineAlbedoTint", OutlineAlbedoTint_Element.ToLinkField(context));
members.Add("OutlineMask", OutlineMask_Element.ToLinkReference(context));
members.Add("ShadowRamp", ShadowRamp_Element.ToLinkReference(context));
members.Add("ShadowRampMask", ShadowRampMask_Element.ToLinkReference(context));
members.Add("ShadowRampMaskScale", ShadowRampMaskScale_Element.ToLinkField(context));
members.Add("ShadowRampMaskOffset", ShadowRampMaskOffset_Element.ToLinkField(context));
members.Add("ShadowRim", ShadowRim_Element.ToLinkField(context));
members.Add("ShadowSharpness", ShadowSharpness_Element.ToLinkField(context));
members.Add("ShadowRimRange", ShadowRimRange_Element.ToLinkField(context));
members.Add("ShadowRimThreshold", ShadowRimThreshold_Element.ToLinkField(context));
members.Add("ShadowRimSharpness", ShadowRimSharpness_Element.ToLinkField(context));
members.Add("ShadowRimAlbedoTint", ShadowRimAlbedoTint_Element.ToLinkField(context));
members.Add("ThicknessMap", ThicknessMap_Element.ToLinkReference(context));
members.Add("ThicknessMapScale", ThicknessMapScale_Element.ToLinkField(context));
members.Add("ThicknessMapOffset", ThicknessMapOffset_Element.ToLinkField(context));
members.Add("SubsurfaceColor", SubsurfaceColor_Element.ToLinkField(context));
members.Add("SubsurfaceDistortion", SubsurfaceDistortion_Element.ToLinkField(context));
members.Add("SubsurfacePower", SubsurfacePower_Element.ToLinkField(context));
members.Add("SubsurfaceScale", SubsurfaceScale_Element.ToLinkField(context));
members.Add("OffsetFactor", OffsetFactor_Element.ToLinkField(context));
members.Add("OffsetUnits", OffsetUnits_Element.ToLinkField(context));
members.Add("Culling", Culling_Element.ToLinkField(context));
members.Add("ColorMask", ColorMask_Element.ToLinkField(context));
members.Add("AlbedoUV", AlbedoUV_Element.ToLinkField(context));
members.Add("NormalUV", NormalUV_Element.ToLinkField(context));
members.Add("MetallicUV", MetallicUV_Element.ToLinkField(context));
members.Add("ThicknessUV", ThicknessUV_Element.ToLinkField(context));
members.Add("OcclusionUV", OcclusionUV_Element.ToLinkField(context));
members.Add("EmissionUV", EmissionUV_Element.ToLinkField(context));
members.Add("RenderQueue", RenderQueue_Element.ToLinkField(context));
members.Add("__legacyCutout", __legacyCutout_Element.ToLinkField(context));
members.Add("_regular", _regular_Element.ToLinkReference(context));
members.Add("_outline", _outline_Element.ToLinkReference(context));
}

}
}
