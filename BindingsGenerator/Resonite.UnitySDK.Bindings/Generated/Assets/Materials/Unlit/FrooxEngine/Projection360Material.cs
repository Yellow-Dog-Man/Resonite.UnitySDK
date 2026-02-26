
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Projection360Material
// Generated on: čtvrtek 26. února 2026 10:03:35
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Projection360Material")]
public partial class Projection360Material : global::FrooxEngine.SingleShaderMaterialProvider, global::FrooxEngine.IStereoMaterial, global::FrooxEngine.ISkyboxMaterial, global::FrooxEngine.IUIX_Material

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Texture { get => Texture_Element.Data; set => Texture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> Texture_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SecondaryTexture { get => SecondaryTexture_Element.Data; set => SecondaryTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> SecondaryTexture_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Cubemap> Cubemap { get => Cubemap_Element.Data; set => Cubemap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Cubemap>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Cubemap>> Cubemap_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Cubemap> SecondaryCubemap { get => SecondaryCubemap_Element.Data; set => SecondaryCubemap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Cubemap>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Cubemap>> SecondaryCubemap_Element = new();
public global::System.Nullable<global::System.Single> CubemapLOD { get => CubemapLOD_Element.Data; set => CubemapLOD_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> CubemapLOD_Element = new();
public global::System.Single TextureLerp { get => TextureLerp_Element.Data; set => TextureLerp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TextureLerp_Element = new();
public global::FrooxEngine.Projection360Material.Mode Projection { get => Projection_Element.Data; set => Projection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Projection360Material.Mode>, global::FrooxEngine.Projection360Material.Mode> Projection_Element = new();
public UnityEngine.Vector2 FieldOfView { get => FieldOfView_Element.Data; set => FieldOfView_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> FieldOfView_Element = new();
public UnityEngine.Vector2 AngleOffset { get => AngleOffset_Element.Data; set => AngleOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> AngleOffset_Element = new();
public UnityEngine.Vector2 PerspectiveFieldOfView { get => PerspectiveFieldOfView_Element.Data; set => PerspectiveFieldOfView_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> PerspectiveFieldOfView_Element = new();
public UnityEngine.Vector2 PerspectiveAngleOffset { get => PerspectiveAngleOffset_Element.Data; set => PerspectiveAngleOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> PerspectiveAngleOffset_Element = new();
public UnityEngine.ColorX Tint { get => Tint_Element.Data; set => Tint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Tint_Element = new();
public global::System.Single Exposure { get => Exposure_Element.Data; set => Exposure_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Exposure_Element = new();
public global::System.Single Gamma { get => Gamma_Element.Data; set => Gamma_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Gamma_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> TintTexture { get => TintTexture_Element.Data; set => TintTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> TintTexture_Element = new();
public UnityEngine.Vector2 TintTextureScale { get => TintTextureScale_Element.Data; set => TintTextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TintTextureScale_Element = new();
public UnityEngine.Vector2 TintTextureOffset { get => TintTextureOffset_Element.Data; set => TintTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TintTextureOffset_Element = new();
public global::FrooxEngine.Projection360Material.TintMode TintTextureMode { get => TintTextureMode_Element.Data; set => TintTextureMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Projection360Material.TintMode>, global::FrooxEngine.Projection360Material.TintMode> TintTextureMode_Element = new();
public UnityEngine.ColorX Tint0 { get => Tint0_Element.Data; set => Tint0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Tint0_Element = new();
public UnityEngine.ColorX Tint1 { get => Tint1_Element.Data; set => Tint1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Tint1_Element = new();
public global::FrooxEngine.Projection360Material.Outside OutsideMode { get => OutsideMode_Element.Data; set => OutsideMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Projection360Material.Outside>, global::FrooxEngine.Projection360Material.Outside> OutsideMode_Element = new();
public UnityEngine.ColorX OutsideColor { get => OutsideColor_Element.Data; set => OutsideColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> OutsideColor_Element = new();
public UnityEngine.Vector2 TextureOffset { get => TextureOffset_Element.Data; set => TextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TextureOffset_Element = new();
public UnityEngine.Vector2 TextureScale { get => TextureScale_Element.Data; set => TextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TextureScale_Element = new();
public global::System.Boolean StereoTextureTransform { get => StereoTextureTransform_Element.Data; set => StereoTextureTransform_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> StereoTextureTransform_Element = new();
public UnityEngine.Vector2 RightEyeTextureOffset { get => RightEyeTextureOffset_Element.Data; set => RightEyeTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> RightEyeTextureOffset_Element = new();
public UnityEngine.Vector2 RightEyeTextureScale { get => RightEyeTextureScale_Element.Data; set => RightEyeTextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> RightEyeTextureScale_Element = new();
public global::FrooxEngine.Sidedness Sidedness { get => Sidedness_Element.Data; set => Sidedness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Sidedness>, global::FrooxEngine.Sidedness> Sidedness_Element = new();
public global::FrooxEngine.ZWrite ZWrite { get => ZWrite_Element.Data; set => ZWrite_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZWrite>, global::FrooxEngine.ZWrite> ZWrite_Element = new();
public global::FrooxEngine.ZTest ZTest { get => ZTest_Element.Data; set => ZTest_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZTest>, global::FrooxEngine.ZTest> ZTest_Element = new();
public global::FrooxEngine.BlendMode BlendMode { get => BlendMode_Element.Data; set => BlendMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.BlendMode>, global::FrooxEngine.BlendMode> BlendMode_Element = new();
public global::System.Single OffsetFactor { get => OffsetFactor_Element.Data; set => OffsetFactor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetFactor_Element = new();
public global::System.Single OffsetUnits { get => OffsetUnits_Element.Data; set => OffsetUnits_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetUnits_Element = new();
public global::System.Nullable<global::System.Single> MaxIntensity { get => MaxIntensity_Element.Data; set => MaxIntensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> MaxIntensity_Element = new();
public UnityEngine.Rect Rect { get => Rect_Element.Data; set => Rect_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Rect>, UnityEngine.Rect> Rect_Element = new();
public global::System.Boolean RectClip { get => RectClip_Element.Data; set => RectClip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RectClip_Element = new();
public global::FrooxEngine.ColorMask ColorMask { get => ColorMask_Element.Data; set => ColorMask_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ColorMask>, global::FrooxEngine.ColorMask> ColorMask_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OffsetTexture { get => OffsetTexture_Element.Data; set => OffsetTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> OffsetTexture_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OffsetMask { get => OffsetMask_Element.Data; set => OffsetMask_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> OffsetMask_Element = new();
public UnityEngine.Vector2 OffsetTextureOffset { get => OffsetTextureOffset_Element.Data; set => OffsetTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> OffsetTextureOffset_Element = new();
public UnityEngine.Vector2 OffsetTextureScale { get => OffsetTextureScale_Element.Data; set => OffsetTextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> OffsetTextureScale_Element = new();
public UnityEngine.Vector2 OffsetMagnitude { get => OffsetMagnitude_Element.Data; set => OffsetMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> OffsetMagnitude_Element = new();
public global::FrooxEngine.StencilComparison StencilComparison { get => StencilComparison_Element.Data; set => StencilComparison_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.StencilComparison>, global::FrooxEngine.StencilComparison> StencilComparison_Element = new();
public global::FrooxEngine.StencilOperation StencilOperation { get => StencilOperation_Element.Data; set => StencilOperation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.StencilOperation>, global::FrooxEngine.StencilOperation> StencilOperation_Element = new();
public global::System.Byte StencilID { get => StencilID_Element.Data; set => StencilID_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Byte>, global::System.Byte> StencilID_Element = new();
public global::System.Byte StencilWriteMask { get => StencilWriteMask_Element.Data; set => StencilWriteMask_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Byte>, global::System.Byte> StencilWriteMask_Element = new();
public global::System.Byte StencilReadMask { get => StencilReadMask_Element.Data; set => StencilReadMask_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Byte>, global::System.Byte> StencilReadMask_Element = new();
public global::System.Int32 RenderQueue { get => RenderQueue_Element.Data; set => RenderQueue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> RenderQueue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture_Element.Data.ToResoniteReference(context));
members.Add("SecondaryTexture", SecondaryTexture_Element.Data.ToResoniteReference(context));
members.Add("Cubemap", Cubemap_Element.Data.ToResoniteReference(context));
members.Add("SecondaryCubemap", SecondaryCubemap_Element.Data.ToResoniteReference(context));
members.Add("CubemapLOD", CubemapLOD_Element.Data.ToResoniteLinkField());
members.Add("TextureLerp", TextureLerp_Element.Data.ToResoniteLinkField());
members.Add("Projection", Projection_Element.Data.ToResoniteLinkField());
members.Add("FieldOfView", FieldOfView_Element.Data.ToResoniteLinkField());
members.Add("AngleOffset", AngleOffset_Element.Data.ToResoniteLinkField());
members.Add("PerspectiveFieldOfView", PerspectiveFieldOfView_Element.Data.ToResoniteLinkField());
members.Add("PerspectiveAngleOffset", PerspectiveAngleOffset_Element.Data.ToResoniteLinkField());
members.Add("Tint", Tint_Element.Data.ToResoniteLinkField());
members.Add("Exposure", Exposure_Element.Data.ToResoniteLinkField());
members.Add("Gamma", Gamma_Element.Data.ToResoniteLinkField());
members.Add("TintTexture", TintTexture_Element.Data.ToResoniteReference(context));
members.Add("TintTextureScale", TintTextureScale_Element.Data.ToResoniteLinkField());
members.Add("TintTextureOffset", TintTextureOffset_Element.Data.ToResoniteLinkField());
members.Add("TintTextureMode", TintTextureMode_Element.Data.ToResoniteLinkField());
members.Add("Tint0", Tint0_Element.Data.ToResoniteLinkField());
members.Add("Tint1", Tint1_Element.Data.ToResoniteLinkField());
members.Add("OutsideMode", OutsideMode_Element.Data.ToResoniteLinkField());
members.Add("OutsideColor", OutsideColor_Element.Data.ToResoniteLinkField());
members.Add("TextureOffset", TextureOffset_Element.Data.ToResoniteLinkField());
members.Add("TextureScale", TextureScale_Element.Data.ToResoniteLinkField());
members.Add("StereoTextureTransform", StereoTextureTransform_Element.Data.ToResoniteLinkField());
members.Add("RightEyeTextureOffset", RightEyeTextureOffset_Element.Data.ToResoniteLinkField());
members.Add("RightEyeTextureScale", RightEyeTextureScale_Element.Data.ToResoniteLinkField());
members.Add("Sidedness", Sidedness_Element.Data.ToResoniteLinkField());
members.Add("ZWrite", ZWrite_Element.Data.ToResoniteLinkField());
members.Add("ZTest", ZTest_Element.Data.ToResoniteLinkField());
members.Add("BlendMode", BlendMode_Element.Data.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor_Element.Data.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits_Element.Data.ToResoniteLinkField());
members.Add("MaxIntensity", MaxIntensity_Element.Data.ToResoniteLinkField());
members.Add("Rect", Rect_Element.Data.ToResoniteLinkField());
members.Add("RectClip", RectClip_Element.Data.ToResoniteLinkField());
members.Add("ColorMask", ColorMask_Element.Data.ToResoniteLinkField());
members.Add("OffsetTexture", OffsetTexture_Element.Data.ToResoniteReference(context));
members.Add("OffsetMask", OffsetMask_Element.Data.ToResoniteReference(context));
members.Add("OffsetTextureOffset", OffsetTextureOffset_Element.Data.ToResoniteLinkField());
members.Add("OffsetTextureScale", OffsetTextureScale_Element.Data.ToResoniteLinkField());
members.Add("OffsetMagnitude", OffsetMagnitude_Element.Data.ToResoniteLinkField());
members.Add("StencilComparison", StencilComparison_Element.Data.ToResoniteLinkField());
members.Add("StencilOperation", StencilOperation_Element.Data.ToResoniteLinkField());
members.Add("StencilID", StencilID_Element.Data.ToResoniteLinkField());
members.Add("StencilWriteMask", StencilWriteMask_Element.Data.ToResoniteLinkField());
members.Add("StencilReadMask", StencilReadMask_Element.Data.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue_Element.Data.ToResoniteLinkField());
}

}
}
