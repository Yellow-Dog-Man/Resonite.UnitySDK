
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BlurMaterial
// Generated on: pátek 13. února 2026 23:21:32
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BlurMaterial")]
public partial class BlurMaterial : global::FrooxEngine.UI_StencilMaterial

{
    public global::System.Int32 Iterations;
public UnityEngine.Vector2 Spread;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SpreadMagnitudeTexture;
public global::System.Boolean UsePoissonDisc;
public global::System.Single DepthFadeDivisor;
public UnityEngine.Vector2 SpreadTextureScale;
public UnityEngine.Vector2 SpreadTextureOffset;
public global::System.Boolean Refract;
public global::System.Single RefractionStrength;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap;
public UnityEngine.Vector2 NormalTextureScale;
public UnityEngine.Vector2 NormalTextureOffset;
public global::System.Boolean PerObject;
public global::FrooxEngine.BlendMode BlendMode;
public global::FrooxEngine.Sidedness Sidedness;
public global::FrooxEngine.ZWrite ZWrite;
public global::FrooxEngine.ZTest ZTest;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _global;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _perObject;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Iterations", Iterations.ToResoniteLinkField());
members.Add("Spread", Spread.ToResoniteLinkField());
members.Add("SpreadMagnitudeTexture", new ResoniteLink.Reference() { });
members.Add("UsePoissonDisc", UsePoissonDisc.ToResoniteLinkField());
members.Add("DepthFadeDivisor", DepthFadeDivisor.ToResoniteLinkField());
members.Add("SpreadTextureScale", SpreadTextureScale.ToResoniteLinkField());
members.Add("SpreadTextureOffset", SpreadTextureOffset.ToResoniteLinkField());
members.Add("Refract", Refract.ToResoniteLinkField());
members.Add("RefractionStrength", RefractionStrength.ToResoniteLinkField());
members.Add("NormalMap", new ResoniteLink.Reference() { });
members.Add("NormalTextureScale", NormalTextureScale.ToResoniteLinkField());
members.Add("NormalTextureOffset", NormalTextureOffset.ToResoniteLinkField());
members.Add("PerObject", PerObject.ToResoniteLinkField());
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("Sidedness", Sidedness.ToResoniteLinkField());
members.Add("ZWrite", ZWrite.ToResoniteLinkField());
members.Add("ZTest", ZTest.ToResoniteLinkField());
members.Add("_global", new ResoniteLink.Reference() { });
members.Add("_perObject", new ResoniteLink.Reference() { });
}

}
}
