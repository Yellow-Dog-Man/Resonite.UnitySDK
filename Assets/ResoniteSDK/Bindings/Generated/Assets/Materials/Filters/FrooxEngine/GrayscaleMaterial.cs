
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrayscaleMaterial
// Generated on: čtvrtek 19. února 2026 7:58:50
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GrayscaleMaterial")]
public partial class GrayscaleMaterial : global::FrooxEngine.SingleShaderUI_StencilMaterial

{
    public global::System.Single RatioRed;
public global::System.Single RatioGreen;
public global::System.Single RatioBlue;
public global::System.Single Lerp;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Gradient;
public global::FrooxEngine.BlendMode BlendMode;
public global::FrooxEngine.Sidedness Sidedness;
public global::FrooxEngine.ZWrite ZWrite;
public global::FrooxEngine.ZTest ZTest;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RatioRed", RatioRed.ToResoniteLinkField());
members.Add("RatioGreen", RatioGreen.ToResoniteLinkField());
members.Add("RatioBlue", RatioBlue.ToResoniteLinkField());
members.Add("Lerp", Lerp.ToResoniteLinkField());
members.Add("Gradient", Gradient.ToResoniteReference(context));
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("Sidedness", Sidedness.ToResoniteLinkField());
members.Add("ZWrite", ZWrite.ToResoniteLinkField());
members.Add("ZTest", ZTest.ToResoniteLinkField());
}

}
}
