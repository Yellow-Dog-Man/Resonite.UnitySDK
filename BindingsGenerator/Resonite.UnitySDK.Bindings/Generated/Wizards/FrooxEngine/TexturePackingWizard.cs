
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TexturePackingWizard
// Generated on: čtvrtek 26. února 2026 15:09:17
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TexturePackingWizard")]
public partial class TexturePackingWizard : global::FrooxEngine.Component, global::FrooxEngine.IDeveloperInterface, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> RTexture { get => RTexture_Element.Data; set => RTexture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> RTexture_Element = new();
public global::System.Single RFallbackValue { get => RFallbackValue_Element.Data; set => RFallbackValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RFallbackValue_Element = new();
public global::Elements.Core.ColorChannel RColorChannel { get => RColorChannel_Element.Data; set => RColorChannel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Core.ColorChannel>, global::Elements.Core.ColorChannel> RColorChannel_Element = new();
public global::System.Boolean RInvert { get => RInvert_Element.Data; set => RInvert_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RInvert_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> GTexture { get => GTexture_Element.Data; set => GTexture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> GTexture_Element = new();
public global::System.Single GFallbackValue { get => GFallbackValue_Element.Data; set => GFallbackValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GFallbackValue_Element = new();
public global::Elements.Core.ColorChannel GColorChannel { get => GColorChannel_Element.Data; set => GColorChannel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Core.ColorChannel>, global::Elements.Core.ColorChannel> GColorChannel_Element = new();
public global::System.Boolean GInvert { get => GInvert_Element.Data; set => GInvert_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> GInvert_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> BTexture { get => BTexture_Element.Data; set => BTexture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> BTexture_Element = new();
public global::System.Single BFallbackValue { get => BFallbackValue_Element.Data; set => BFallbackValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BFallbackValue_Element = new();
public global::Elements.Core.ColorChannel BColorChannel { get => BColorChannel_Element.Data; set => BColorChannel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Core.ColorChannel>, global::Elements.Core.ColorChannel> BColorChannel_Element = new();
public global::System.Boolean BInvert { get => BInvert_Element.Data; set => BInvert_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> BInvert_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> ATexture { get => ATexture_Element.Data; set => ATexture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> ATexture_Element = new();
public global::System.Single AFallbackValue { get => AFallbackValue_Element.Data; set => AFallbackValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AFallbackValue_Element = new();
public global::Elements.Core.ColorChannel AColorChannel { get => AColorChannel_Element.Data; set => AColorChannel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Core.ColorChannel>, global::Elements.Core.ColorChannel> AColorChannel_Element = new();
public global::System.Boolean AInvert { get => AInvert_Element.Data; set => AInvert_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AInvert_Element = new();
public global::System.Nullable<UnityEngine.Vector2Int> ResolutionOverride { get => ResolutionOverride_Element.Data; set => ResolutionOverride_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector2Int>>, global::System.Nullable<UnityEngine.Vector2Int>> ResolutionOverride_Element = new();
public global::FrooxEngine.TexturePackingWizard.ResolutionSizeHandling ResolutionSizing { get => ResolutionSizing_Element.Data; set => ResolutionSizing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.TexturePackingWizard.ResolutionSizeHandling>, global::FrooxEngine.TexturePackingWizard.ResolutionSizeHandling> ResolutionSizing_Element = new();
public UnityEngine.Vector2Int EmptyFallbackResolution { get => EmptyFallbackResolution_Element.Data; set => EmptyFallbackResolution_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> EmptyFallbackResolution_Element = new();
public global::System.Boolean GenerateMips { get => GenerateMips_Element.Data; set => GenerateMips_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> GenerateMips_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OutputTexture { get => OutputTexture_Element.Data; set => OutputTexture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> OutputTexture_Element = new();
public global::System.Boolean IsProcessing { get => IsProcessing_Element.Data; set => IsProcessing_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsProcessing_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RTexture", RTexture_Element.ToLinkReference(context));
members.Add("RFallbackValue", RFallbackValue_Element.ToLinkField(context));
members.Add("RColorChannel", RColorChannel_Element.ToLinkField(context));
members.Add("RInvert", RInvert_Element.ToLinkField(context));
members.Add("GTexture", GTexture_Element.ToLinkReference(context));
members.Add("GFallbackValue", GFallbackValue_Element.ToLinkField(context));
members.Add("GColorChannel", GColorChannel_Element.ToLinkField(context));
members.Add("GInvert", GInvert_Element.ToLinkField(context));
members.Add("BTexture", BTexture_Element.ToLinkReference(context));
members.Add("BFallbackValue", BFallbackValue_Element.ToLinkField(context));
members.Add("BColorChannel", BColorChannel_Element.ToLinkField(context));
members.Add("BInvert", BInvert_Element.ToLinkField(context));
members.Add("ATexture", ATexture_Element.ToLinkReference(context));
members.Add("AFallbackValue", AFallbackValue_Element.ToLinkField(context));
members.Add("AColorChannel", AColorChannel_Element.ToLinkField(context));
members.Add("AInvert", AInvert_Element.ToLinkField(context));
members.Add("ResolutionOverride", ResolutionOverride_Element.ToLinkField(context));
members.Add("ResolutionSizing", ResolutionSizing_Element.ToLinkField(context));
members.Add("EmptyFallbackResolution", EmptyFallbackResolution_Element.ToLinkField(context));
members.Add("GenerateMips", GenerateMips_Element.ToLinkField(context));
members.Add("OutputTexture", OutputTexture_Element.ToLinkReference(context));
members.Add("IsProcessing", IsProcessing_Element.ToLinkField(context));
}

}
}
