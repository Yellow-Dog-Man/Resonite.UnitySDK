
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OverlayFresnelMaterial
// Generated on: úterý 24. února 2026 18:17:37
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.OverlayFresnelMaterial")]
public partial class OverlayFresnelMaterial : global::FrooxEngine.SingleShaderMaterialProvider

{
    public global::System.Single Exponent;
public global::System.Single GammaCurve;
public UnityEngine.ColorX BehindFarColor;
public UnityEngine.ColorX BehindNearColor;
public UnityEngine.ColorX FrontFarColor;
public UnityEngine.ColorX FrontNearColor;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> BehindFarTexture;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> BehindNearTexture;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> FrontFarTexture;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> FrontNearTexture;
public UnityEngine.Vector2 BehindFarTextureScale;
public UnityEngine.Vector2 BehindFarTextureOffset;
public UnityEngine.Vector2 BehindNearTextureScale;
public UnityEngine.Vector2 BehindNearTextureOffset;
public UnityEngine.Vector2 FrontFarTextureScale;
public UnityEngine.Vector2 FrontFarTextureOffset;
public UnityEngine.Vector2 FrontNearTextureScale;
public UnityEngine.Vector2 FrontNearTextureOffset;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap;
public global::FrooxEngine.BlendMode BlendMode;
public global::FrooxEngine.Sidedness Sidedness;
public global::FrooxEngine.ZWrite ZWrite;
public global::System.Int32 RenderQueue;
public global::System.Single OffsetFactor;
public global::System.Single OffsetUnits;
public global::System.Boolean PolarUVmapping;
public global::System.Single PolarPower;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Exponent", Exponent.ToResoniteLinkField());
members.Add("GammaCurve", GammaCurve.ToResoniteLinkField());
members.Add("BehindFarColor", BehindFarColor.ToResoniteLinkField());
members.Add("BehindNearColor", BehindNearColor.ToResoniteLinkField());
members.Add("FrontFarColor", FrontFarColor.ToResoniteLinkField());
members.Add("FrontNearColor", FrontNearColor.ToResoniteLinkField());
members.Add("BehindFarTexture", BehindFarTexture.ToResoniteReference(context));
members.Add("BehindNearTexture", BehindNearTexture.ToResoniteReference(context));
members.Add("FrontFarTexture", FrontFarTexture.ToResoniteReference(context));
members.Add("FrontNearTexture", FrontNearTexture.ToResoniteReference(context));
members.Add("BehindFarTextureScale", BehindFarTextureScale.ToResoniteLinkField());
members.Add("BehindFarTextureOffset", BehindFarTextureOffset.ToResoniteLinkField());
members.Add("BehindNearTextureScale", BehindNearTextureScale.ToResoniteLinkField());
members.Add("BehindNearTextureOffset", BehindNearTextureOffset.ToResoniteLinkField());
members.Add("FrontFarTextureScale", FrontFarTextureScale.ToResoniteLinkField());
members.Add("FrontFarTextureOffset", FrontFarTextureOffset.ToResoniteLinkField());
members.Add("FrontNearTextureScale", FrontNearTextureScale.ToResoniteLinkField());
members.Add("FrontNearTextureOffset", FrontNearTextureOffset.ToResoniteLinkField());
members.Add("NormalMap", NormalMap.ToResoniteReference(context));
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("Sidedness", Sidedness.ToResoniteLinkField());
members.Add("ZWrite", ZWrite.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
members.Add("PolarUVmapping", PolarUVmapping.ToResoniteLinkField());
members.Add("PolarPower", PolarPower.ToResoniteLinkField());
}

}
}
