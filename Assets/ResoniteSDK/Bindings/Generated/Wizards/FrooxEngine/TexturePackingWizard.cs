
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TexturePackingWizard
// Generated on: čtvrtek 19. února 2026 8:00:34
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TexturePackingWizard")]
public partial class TexturePackingWizard : global::FrooxEngine.Component, global::FrooxEngine.IDeveloperInterface, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> RTexture;
public global::System.Single RFallbackValue;
public global::Elements.Core.ColorChannel RColorChannel;
public global::System.Boolean RInvert;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> GTexture;
public global::System.Single GFallbackValue;
public global::Elements.Core.ColorChannel GColorChannel;
public global::System.Boolean GInvert;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> BTexture;
public global::System.Single BFallbackValue;
public global::Elements.Core.ColorChannel BColorChannel;
public global::System.Boolean BInvert;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> ATexture;
public global::System.Single AFallbackValue;
public global::Elements.Core.ColorChannel AColorChannel;
public global::System.Boolean AInvert;
public global::System.Nullable<UnityEngine.Vector2Int> ResolutionOverride;
public global::FrooxEngine.TexturePackingWizard.ResolutionSizeHandling ResolutionSizing;
public UnityEngine.Vector2Int EmptyFallbackResolution;
public global::System.Boolean GenerateMips;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OutputTexture;
public global::System.Boolean IsProcessing;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RTexture", RTexture.ToResoniteReference(context));
members.Add("RFallbackValue", RFallbackValue.ToResoniteLinkField());
members.Add("RColorChannel", RColorChannel.ToResoniteLinkField());
members.Add("RInvert", RInvert.ToResoniteLinkField());
members.Add("GTexture", GTexture.ToResoniteReference(context));
members.Add("GFallbackValue", GFallbackValue.ToResoniteLinkField());
members.Add("GColorChannel", GColorChannel.ToResoniteLinkField());
members.Add("GInvert", GInvert.ToResoniteLinkField());
members.Add("BTexture", BTexture.ToResoniteReference(context));
members.Add("BFallbackValue", BFallbackValue.ToResoniteLinkField());
members.Add("BColorChannel", BColorChannel.ToResoniteLinkField());
members.Add("BInvert", BInvert.ToResoniteLinkField());
members.Add("ATexture", ATexture.ToResoniteReference(context));
members.Add("AFallbackValue", AFallbackValue.ToResoniteLinkField());
members.Add("AColorChannel", AColorChannel.ToResoniteLinkField());
members.Add("AInvert", AInvert.ToResoniteLinkField());
members.Add("ResolutionOverride", ResolutionOverride.ToResoniteLinkField());
members.Add("ResolutionSizing", ResolutionSizing.ToResoniteLinkField());
members.Add("EmptyFallbackResolution", EmptyFallbackResolution.ToResoniteLinkField());
members.Add("GenerateMips", GenerateMips.ToResoniteLinkField());
members.Add("OutputTexture", OutputTexture.ToResoniteReference(context));
members.Add("IsProcessing", IsProcessing.ToResoniteLinkField());
}

}
}
