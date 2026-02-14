
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UnlitMaterial
// Generated on: sobota 14. února 2026 8:56:57
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UnlitMaterial")]
public partial class UnlitMaterial : global::FrooxEngine.MaterialProvider, global::FrooxEngine.ICommonMaterial, global::FrooxEngine.IStereoMaterial, global::FrooxEngine.IBillboardMaterial, global::FrooxEngine.IBlendModeMaterial, global::FrooxEngine.ICullingMaterial

{
    public UnityEngine.ColorX TintColor;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Texture;
public UnityEngine.Vector2 TextureScale;
public UnityEngine.Vector2 TextureOffset;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MaskTexture;
public UnityEngine.Vector2 MaskScale;
public UnityEngine.Vector2 MaskOffset;
public global::FrooxEngine.MaskTextureMode MaskMode;
public global::FrooxEngine.BlendMode BlendMode;
public global::System.Single AlphaCutoff;
public global::System.Boolean UseVertexColors;
public global::Renderite.Shared.ColorProfile VertexColorInterpolationSpace;
public global::FrooxEngine.Sidedness Sidedness;
public global::FrooxEngine.ZWrite ZWrite;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OffsetTexture;
public UnityEngine.Vector2 OffsetMagnitude;
public UnityEngine.Vector2 OffsetTextureScale;
public UnityEngine.Vector2 OffsetTextureOffset;
public global::System.Boolean PolarUVmapping;
public global::System.Single PolarPower;
public global::System.Boolean StereoTextureTransform;
public UnityEngine.Vector2 RightEyeTextureScale;
public UnityEngine.Vector2 RightEyeTextureOffset;
public global::System.Boolean DecodeAsNormalMap;
public global::System.Boolean UseBillboardGeometry;
public global::System.Boolean UsePerBillboardScale;
public global::System.Boolean UsePerBillboardRotation;
public global::System.Boolean UsePerBillboardUV;
public UnityEngine.Vector2 BillboardSize;
public global::System.Single OffsetFactor;
public global::System.Single OffsetUnits;
public global::System.Int32 RenderQueue;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _unlit;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _unlitBillboard;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TintColor", TintColor.ToResoniteLinkField());
members.Add("Texture", Texture.ToResoniteReference(context));
members.Add("TextureScale", TextureScale.ToResoniteLinkField());
members.Add("TextureOffset", TextureOffset.ToResoniteLinkField());
members.Add("MaskTexture", MaskTexture.ToResoniteReference(context));
members.Add("MaskScale", MaskScale.ToResoniteLinkField());
members.Add("MaskOffset", MaskOffset.ToResoniteLinkField());
members.Add("MaskMode", MaskMode.ToResoniteLinkField());
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("AlphaCutoff", AlphaCutoff.ToResoniteLinkField());
members.Add("UseVertexColors", UseVertexColors.ToResoniteLinkField());
members.Add("VertexColorInterpolationSpace", VertexColorInterpolationSpace.ToResoniteLinkField());
members.Add("Sidedness", Sidedness.ToResoniteLinkField());
members.Add("ZWrite", ZWrite.ToResoniteLinkField());
members.Add("OffsetTexture", OffsetTexture.ToResoniteReference(context));
members.Add("OffsetMagnitude", OffsetMagnitude.ToResoniteLinkField());
members.Add("OffsetTextureScale", OffsetTextureScale.ToResoniteLinkField());
members.Add("OffsetTextureOffset", OffsetTextureOffset.ToResoniteLinkField());
members.Add("PolarUVmapping", PolarUVmapping.ToResoniteLinkField());
members.Add("PolarPower", PolarPower.ToResoniteLinkField());
members.Add("StereoTextureTransform", StereoTextureTransform.ToResoniteLinkField());
members.Add("RightEyeTextureScale", RightEyeTextureScale.ToResoniteLinkField());
members.Add("RightEyeTextureOffset", RightEyeTextureOffset.ToResoniteLinkField());
members.Add("DecodeAsNormalMap", DecodeAsNormalMap.ToResoniteLinkField());
members.Add("UseBillboardGeometry", UseBillboardGeometry.ToResoniteLinkField());
members.Add("UsePerBillboardScale", UsePerBillboardScale.ToResoniteLinkField());
members.Add("UsePerBillboardRotation", UsePerBillboardRotation.ToResoniteLinkField());
members.Add("UsePerBillboardUV", UsePerBillboardUV.ToResoniteLinkField());
members.Add("BillboardSize", BillboardSize.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
members.Add("_unlit", _unlit.ToResoniteReference(context));
members.Add("_unlitBillboard", _unlitBillboard.ToResoniteReference(context));
}

}
}
