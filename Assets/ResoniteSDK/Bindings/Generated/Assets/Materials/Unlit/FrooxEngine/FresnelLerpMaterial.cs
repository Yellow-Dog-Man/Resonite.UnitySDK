
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FresnelLerpMaterial
// Generated on: pátek 13. února 2026 5:51:06
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Lerp", Lerp.ToResoniteLinkField());
members.Add("LerpTexture", new ResoniteLink.Reference() { });
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
members.Add("FarTexture0", new ResoniteLink.Reference() { });
members.Add("NearTexture0", new ResoniteLink.Reference() { });
members.Add("FarTexture1", new ResoniteLink.Reference() { });
members.Add("NearTexture1", new ResoniteLink.Reference() { });
members.Add("NormalMap0", new ResoniteLink.Reference() { });
members.Add("NormalMap1", new ResoniteLink.Reference() { });
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("Sidedness", Sidedness.ToResoniteLinkField());
members.Add("ZWrite", ZWrite.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
}

}
}
