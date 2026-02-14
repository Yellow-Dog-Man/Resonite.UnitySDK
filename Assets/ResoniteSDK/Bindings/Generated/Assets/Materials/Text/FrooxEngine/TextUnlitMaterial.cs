
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextUnlitMaterial
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextUnlitMaterial")]
public partial class TextUnlitMaterial : global::FrooxEngine.SingleShaderMaterialProvider, global::FrooxEngine.ITextMaterial

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> FontAtlas;
public UnityEngine.ColorX TintColor;
public UnityEngine.ColorX OutlineColor;
public UnityEngine.ColorX BackgroundColor;
public global::System.Boolean AutoBackgroundColor;
public global::Elements.Assets.GlyphRenderMethod GlyphRenderMethod;
public global::System.Single PixelRange;
public global::System.Single FaceDilate;
public global::System.Single OutlineThickness;
public global::System.Single FaceSoftness;
public global::FrooxEngine.BlendMode BlendMode;
public global::FrooxEngine.Sidedness Sidedness;
public global::FrooxEngine.ZWrite ZWrite;
public global::FrooxEngine.ZTest ZTest;
public global::System.Single OffsetFactor;
public global::System.Single OffsetUnits;
public global::System.Int32 RenderQueue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FontAtlas", FontAtlas.ToResoniteReference(context));
members.Add("TintColor", TintColor.ToResoniteLinkField());
members.Add("OutlineColor", OutlineColor.ToResoniteLinkField());
members.Add("BackgroundColor", BackgroundColor.ToResoniteLinkField());
members.Add("AutoBackgroundColor", AutoBackgroundColor.ToResoniteLinkField());
members.Add("GlyphRenderMethod", GlyphRenderMethod.ToResoniteLinkField());
members.Add("PixelRange", PixelRange.ToResoniteLinkField());
members.Add("FaceDilate", FaceDilate.ToResoniteLinkField());
members.Add("OutlineThickness", OutlineThickness.ToResoniteLinkField());
members.Add("FaceSoftness", FaceSoftness.ToResoniteLinkField());
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("Sidedness", Sidedness.ToResoniteLinkField());
members.Add("ZWrite", ZWrite.ToResoniteLinkField());
members.Add("ZTest", ZTest.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
}

}
}
