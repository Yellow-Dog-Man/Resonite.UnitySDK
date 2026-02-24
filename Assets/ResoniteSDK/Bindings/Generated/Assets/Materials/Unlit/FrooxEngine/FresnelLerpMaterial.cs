
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FresnelLerpMaterial
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FresnelLerpMaterial")]
public partial class FresnelLerpMaterial : global::FrooxEngine.SingleShaderMaterialProvider

{
    public global::System.Single Lerp;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> LerpTexture;
public UnityEngine.Vector2 LerpTextureScale;
public UnityEngine.Vector2 LerpTextureOffset;
public global::System.Boolean LerpTexturePolarUV;
public global::System.Single LerpTexturePolarPower;
public global::System.Single Exponent0;
public global::System.Single Exponent1;
public global::System.Single GammaCurve;
public UnityEngine.ColorX FarColor0;
public UnityEngine.ColorX NearColor0;
public UnityEngine.ColorX FarColor1;
public UnityEngine.ColorX NearColor1;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> FarTexture0;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NearTexture0;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> FarTexture1;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NearTexture1;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap0;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap1;
public global::FrooxEngine.BlendMode BlendMode;
public global::FrooxEngine.Sidedness Sidedness;
public global::FrooxEngine.ZWrite ZWrite;
public global::System.Single OffsetFactor;
public global::System.Single OffsetUnits;
public global::System.Int32 RenderQueue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Lerp", Lerp.ToResoniteLinkField());
members.Add("LerpTexture", LerpTexture.ToResoniteReference(context));
members.Add("LerpTextureScale", LerpTextureScale.ToResoniteLinkField());
members.Add("LerpTextureOffset", LerpTextureOffset.ToResoniteLinkField());
members.Add("LerpTexturePolarUV", LerpTexturePolarUV.ToResoniteLinkField());
members.Add("LerpTexturePolarPower", LerpTexturePolarPower.ToResoniteLinkField());
members.Add("Exponent0", Exponent0.ToResoniteLinkField());
members.Add("Exponent1", Exponent1.ToResoniteLinkField());
members.Add("GammaCurve", GammaCurve.ToResoniteLinkField());
members.Add("FarColor0", FarColor0.ToResoniteLinkField());
members.Add("NearColor0", NearColor0.ToResoniteLinkField());
members.Add("FarColor1", FarColor1.ToResoniteLinkField());
members.Add("NearColor1", NearColor1.ToResoniteLinkField());
members.Add("FarTexture0", FarTexture0.ToResoniteReference(context));
members.Add("NearTexture0", NearTexture0.ToResoniteReference(context));
members.Add("FarTexture1", FarTexture1.ToResoniteReference(context));
members.Add("NearTexture1", NearTexture1.ToResoniteReference(context));
members.Add("NormalMap0", NormalMap0.ToResoniteReference(context));
members.Add("NormalMap1", NormalMap1.ToResoniteReference(context));
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("Sidedness", Sidedness.ToResoniteLinkField());
members.Add("ZWrite", ZWrite.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
}

}
}
