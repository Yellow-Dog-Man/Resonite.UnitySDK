
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextUnlitMaterial
// Generated on: čtvrtek 26. února 2026 15:07:54
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> FontAtlas { get => FontAtlas_Element.Data; set => FontAtlas_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> FontAtlas_Element = new();
public UnityEngine.ColorX TintColor { get => TintColor_Element.Data; set => TintColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> TintColor_Element = new();
public UnityEngine.ColorX OutlineColor { get => OutlineColor_Element.Data; set => OutlineColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> OutlineColor_Element = new();
public UnityEngine.ColorX BackgroundColor { get => BackgroundColor_Element.Data; set => BackgroundColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> BackgroundColor_Element = new();
public global::System.Boolean AutoBackgroundColor { get => AutoBackgroundColor_Element.Data; set => AutoBackgroundColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AutoBackgroundColor_Element = new();
public global::Elements.Assets.GlyphRenderMethod GlyphRenderMethod { get => GlyphRenderMethod_Element.Data; set => GlyphRenderMethod_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.GlyphRenderMethod>, global::Elements.Assets.GlyphRenderMethod> GlyphRenderMethod_Element = new();
public global::System.Single PixelRange { get => PixelRange_Element.Data; set => PixelRange_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PixelRange_Element = new();
public global::System.Single FaceDilate { get => FaceDilate_Element.Data; set => FaceDilate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FaceDilate_Element = new();
public global::System.Single OutlineThickness { get => OutlineThickness_Element.Data; set => OutlineThickness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OutlineThickness_Element = new();
public global::System.Single FaceSoftness { get => FaceSoftness_Element.Data; set => FaceSoftness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FaceSoftness_Element = new();
public global::FrooxEngine.BlendMode BlendMode { get => BlendMode_Element.Data; set => BlendMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.BlendMode>, global::FrooxEngine.BlendMode> BlendMode_Element = new();
public global::FrooxEngine.Sidedness Sidedness { get => Sidedness_Element.Data; set => Sidedness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Sidedness>, global::FrooxEngine.Sidedness> Sidedness_Element = new();
public global::FrooxEngine.ZWrite ZWrite { get => ZWrite_Element.Data; set => ZWrite_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZWrite>, global::FrooxEngine.ZWrite> ZWrite_Element = new();
public global::FrooxEngine.ZTest ZTest { get => ZTest_Element.Data; set => ZTest_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZTest>, global::FrooxEngine.ZTest> ZTest_Element = new();
public global::System.Single OffsetFactor { get => OffsetFactor_Element.Data; set => OffsetFactor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetFactor_Element = new();
public global::System.Single OffsetUnits { get => OffsetUnits_Element.Data; set => OffsetUnits_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetUnits_Element = new();
public global::System.Int32 RenderQueue { get => RenderQueue_Element.Data; set => RenderQueue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> RenderQueue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FontAtlas", FontAtlas_Element.ToLinkReference(context));
members.Add("TintColor", TintColor_Element.ToLinkField(context));
members.Add("OutlineColor", OutlineColor_Element.ToLinkField(context));
members.Add("BackgroundColor", BackgroundColor_Element.ToLinkField(context));
members.Add("AutoBackgroundColor", AutoBackgroundColor_Element.ToLinkField(context));
members.Add("GlyphRenderMethod", GlyphRenderMethod_Element.ToLinkField(context));
members.Add("PixelRange", PixelRange_Element.ToLinkField(context));
members.Add("FaceDilate", FaceDilate_Element.ToLinkField(context));
members.Add("OutlineThickness", OutlineThickness_Element.ToLinkField(context));
members.Add("FaceSoftness", FaceSoftness_Element.ToLinkField(context));
members.Add("BlendMode", BlendMode_Element.ToLinkField(context));
members.Add("Sidedness", Sidedness_Element.ToLinkField(context));
members.Add("ZWrite", ZWrite_Element.ToLinkField(context));
members.Add("ZTest", ZTest_Element.ToLinkField(context));
members.Add("OffsetFactor", OffsetFactor_Element.ToLinkField(context));
members.Add("OffsetUnits", OffsetUnits_Element.ToLinkField(context));
members.Add("RenderQueue", RenderQueue_Element.ToLinkField(context));
}

}
}
