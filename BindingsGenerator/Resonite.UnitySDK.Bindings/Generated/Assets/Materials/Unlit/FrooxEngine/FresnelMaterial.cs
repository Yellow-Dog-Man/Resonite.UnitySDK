
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FresnelMaterial
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FresnelMaterial")]
public partial class FresnelMaterial : global::FrooxEngine.SingleShaderMaterialProvider

{
    public global::System.Single Exponent;
public global::System.Single GammaCurve;
public UnityEngine.ColorX FarColor;
public UnityEngine.ColorX NearColor;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> FarTexture;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NearTexture;
public UnityEngine.Vector2 FarTextureScale;
public UnityEngine.Vector2 FarTextureOffset;
public UnityEngine.Vector2 NearTextureScale;
public UnityEngine.Vector2 NearTextureOffset;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap;
public global::System.Single NormalScale;
public global::System.Boolean UseVertexColors;
public global::Renderite.Shared.ColorProfile VertexColorInterpolationSpace;
public global::FrooxEngine.BlendMode BlendMode;
public global::System.Single AlphaCutoff;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MaskTexture;
public UnityEngine.Vector2 MaskScale;
public UnityEngine.Vector2 MaskOffset;
public global::FrooxEngine.MaskTextureMode MaskMode;
public global::FrooxEngine.Sidedness Sidedness;
public global::FrooxEngine.ZWrite ZWrite;
public global::FrooxEngine.ZTest ZTest;
public global::System.Single OffsetFactor;
public global::System.Single OffsetUnits;
public global::System.Int32 RenderQueue;
public global::System.Boolean PolarUVmapping;
public global::System.Single PolarPower;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Exponent", Exponent.ToResoniteLinkField());
members.Add("GammaCurve", GammaCurve.ToResoniteLinkField());
members.Add("FarColor", FarColor.ToResoniteLinkField());
members.Add("NearColor", NearColor.ToResoniteLinkField());
members.Add("FarTexture", FarTexture.ToResoniteReference(context));
members.Add("NearTexture", NearTexture.ToResoniteReference(context));
members.Add("FarTextureScale", FarTextureScale.ToResoniteLinkField());
members.Add("FarTextureOffset", FarTextureOffset.ToResoniteLinkField());
members.Add("NearTextureScale", NearTextureScale.ToResoniteLinkField());
members.Add("NearTextureOffset", NearTextureOffset.ToResoniteLinkField());
members.Add("NormalMap", NormalMap.ToResoniteReference(context));
members.Add("NormalScale", NormalScale.ToResoniteLinkField());
members.Add("UseVertexColors", UseVertexColors.ToResoniteLinkField());
members.Add("VertexColorInterpolationSpace", VertexColorInterpolationSpace.ToResoniteLinkField());
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("AlphaCutoff", AlphaCutoff.ToResoniteLinkField());
members.Add("MaskTexture", MaskTexture.ToResoniteReference(context));
members.Add("MaskScale", MaskScale.ToResoniteLinkField());
members.Add("MaskOffset", MaskOffset.ToResoniteLinkField());
members.Add("MaskMode", MaskMode.ToResoniteLinkField());
members.Add("Sidedness", Sidedness.ToResoniteLinkField());
members.Add("ZWrite", ZWrite.ToResoniteLinkField());
members.Add("ZTest", ZTest.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
members.Add("PolarUVmapping", PolarUVmapping.ToResoniteLinkField());
members.Add("PolarPower", PolarPower.ToResoniteLinkField());
}

}
}
