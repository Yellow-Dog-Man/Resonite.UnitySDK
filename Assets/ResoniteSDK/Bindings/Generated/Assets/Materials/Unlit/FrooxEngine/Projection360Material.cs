
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Projection360Material
// Generated on: pátek 13. února 2026 23:21:34
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Projection360Material")]
public partial class Projection360Material : global::FrooxEngine.SingleShaderMaterialProvider, global::FrooxEngine.IStereoMaterial, global::FrooxEngine.ISkyboxMaterial, global::FrooxEngine.IUIX_Material

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Texture;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SecondaryTexture;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Cubemap> Cubemap;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Cubemap> SecondaryCubemap;
public global::System.Nullable<global::System.Single> CubemapLOD;
public global::System.Single TextureLerp;
public global::FrooxEngine.Projection360Material.Mode Projection;
public UnityEngine.Vector2 FieldOfView;
public UnityEngine.Vector2 AngleOffset;
public UnityEngine.Vector2 PerspectiveFieldOfView;
public UnityEngine.Vector2 PerspectiveAngleOffset;
public UnityEngine.ColorX Tint;
public global::System.Single Exposure;
public global::System.Single Gamma;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> TintTexture;
public UnityEngine.Vector2 TintTextureScale;
public UnityEngine.Vector2 TintTextureOffset;
public global::FrooxEngine.Projection360Material.TintMode TintTextureMode;
public UnityEngine.ColorX Tint0;
public UnityEngine.ColorX Tint1;
public global::FrooxEngine.Projection360Material.Outside OutsideMode;
public UnityEngine.ColorX OutsideColor;
public UnityEngine.Vector2 TextureOffset;
public UnityEngine.Vector2 TextureScale;
public global::System.Boolean StereoTextureTransform;
public UnityEngine.Vector2 RightEyeTextureOffset;
public UnityEngine.Vector2 RightEyeTextureScale;
public global::FrooxEngine.Sidedness Sidedness;
public global::FrooxEngine.ZWrite ZWrite;
public global::FrooxEngine.ZTest ZTest;
public global::FrooxEngine.BlendMode BlendMode;
public global::System.Single OffsetFactor;
public global::System.Single OffsetUnits;
public global::System.Nullable<global::System.Single> MaxIntensity;
public UnityEngine.Rect Rect;
public global::System.Boolean RectClip;
public global::FrooxEngine.ColorMask ColorMask;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OffsetTexture;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OffsetMask;
public UnityEngine.Vector2 OffsetTextureOffset;
public UnityEngine.Vector2 OffsetTextureScale;
public UnityEngine.Vector2 OffsetMagnitude;
public global::FrooxEngine.StencilComparison StencilComparison;
public global::FrooxEngine.StencilOperation StencilOperation;
public global::System.Byte StencilID;
public global::System.Byte StencilWriteMask;
public global::System.Byte StencilReadMask;
public global::System.Int32 RenderQueue;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Texture", new ResoniteLink.Reference() { });
members.Add("SecondaryTexture", new ResoniteLink.Reference() { });
members.Add("Cubemap", new ResoniteLink.Reference() { });
members.Add("SecondaryCubemap", new ResoniteLink.Reference() { });
members.Add("CubemapLOD", CubemapLOD.ToResoniteLinkField());
members.Add("TextureLerp", TextureLerp.ToResoniteLinkField());
members.Add("Projection", Projection.ToResoniteLinkField());
members.Add("FieldOfView", FieldOfView.ToResoniteLinkField());
members.Add("AngleOffset", AngleOffset.ToResoniteLinkField());
members.Add("PerspectiveFieldOfView", PerspectiveFieldOfView.ToResoniteLinkField());
members.Add("PerspectiveAngleOffset", PerspectiveAngleOffset.ToResoniteLinkField());
members.Add("Tint", Tint.ToResoniteLinkField());
members.Add("Exposure", Exposure.ToResoniteLinkField());
members.Add("Gamma", Gamma.ToResoniteLinkField());
members.Add("TintTexture", new ResoniteLink.Reference() { });
members.Add("TintTextureScale", TintTextureScale.ToResoniteLinkField());
members.Add("TintTextureOffset", TintTextureOffset.ToResoniteLinkField());
members.Add("TintTextureMode", TintTextureMode.ToResoniteLinkField());
members.Add("Tint0", Tint0.ToResoniteLinkField());
members.Add("Tint1", Tint1.ToResoniteLinkField());
members.Add("OutsideMode", OutsideMode.ToResoniteLinkField());
members.Add("OutsideColor", OutsideColor.ToResoniteLinkField());
members.Add("TextureOffset", TextureOffset.ToResoniteLinkField());
members.Add("TextureScale", TextureScale.ToResoniteLinkField());
members.Add("StereoTextureTransform", StereoTextureTransform.ToResoniteLinkField());
members.Add("RightEyeTextureOffset", RightEyeTextureOffset.ToResoniteLinkField());
members.Add("RightEyeTextureScale", RightEyeTextureScale.ToResoniteLinkField());
members.Add("Sidedness", Sidedness.ToResoniteLinkField());
members.Add("ZWrite", ZWrite.ToResoniteLinkField());
members.Add("ZTest", ZTest.ToResoniteLinkField());
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
members.Add("MaxIntensity", MaxIntensity.ToResoniteLinkField());
members.Add("Rect", Rect.ToResoniteLinkField());
members.Add("RectClip", RectClip.ToResoniteLinkField());
members.Add("ColorMask", ColorMask.ToResoniteLinkField());
members.Add("OffsetTexture", new ResoniteLink.Reference() { });
members.Add("OffsetMask", new ResoniteLink.Reference() { });
members.Add("OffsetTextureOffset", OffsetTextureOffset.ToResoniteLinkField());
members.Add("OffsetTextureScale", OffsetTextureScale.ToResoniteLinkField());
members.Add("OffsetMagnitude", OffsetMagnitude.ToResoniteLinkField());
members.Add("StencilComparison", StencilComparison.ToResoniteLinkField());
members.Add("StencilOperation", StencilOperation.ToResoniteLinkField());
members.Add("StencilID", StencilID.ToResoniteLinkField());
members.Add("StencilWriteMask", StencilWriteMask.ToResoniteLinkField());
members.Add("StencilReadMask", StencilReadMask.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
}

}
}
