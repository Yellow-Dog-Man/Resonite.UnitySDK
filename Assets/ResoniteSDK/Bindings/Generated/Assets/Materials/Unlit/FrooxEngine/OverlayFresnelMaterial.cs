
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OverlayFresnelMaterial
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Exponent", Exponent.ToResoniteLinkField());
members.Add("GammaCurve", GammaCurve.ToResoniteLinkField());
members.Add("BehindFarColor", BehindFarColor.ToResoniteLinkField());
members.Add("BehindNearColor", BehindNearColor.ToResoniteLinkField());
members.Add("FrontFarColor", FrontFarColor.ToResoniteLinkField());
members.Add("FrontNearColor", FrontNearColor.ToResoniteLinkField());
members.Add("BehindFarTexture", new ResoniteLink.Reference() { });
members.Add("BehindNearTexture", new ResoniteLink.Reference() { });
members.Add("FrontFarTexture", new ResoniteLink.Reference() { });
members.Add("FrontNearTexture", new ResoniteLink.Reference() { });
members.Add("BehindFarTextureScale", BehindFarTextureScale.ToResoniteLinkField());
members.Add("BehindFarTextureOffset", BehindFarTextureOffset.ToResoniteLinkField());
members.Add("BehindNearTextureScale", BehindNearTextureScale.ToResoniteLinkField());
members.Add("BehindNearTextureOffset", BehindNearTextureOffset.ToResoniteLinkField());
members.Add("FrontFarTextureScale", FrontFarTextureScale.ToResoniteLinkField());
members.Add("FrontFarTextureOffset", FrontFarTextureOffset.ToResoniteLinkField());
members.Add("FrontNearTextureScale", FrontNearTextureScale.ToResoniteLinkField());
members.Add("FrontNearTextureOffset", FrontNearTextureOffset.ToResoniteLinkField());
members.Add("NormalMap", new ResoniteLink.Reference() { });
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
