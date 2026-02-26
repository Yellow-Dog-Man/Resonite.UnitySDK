
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StaticFont
// Generated on: čtvrtek 26. února 2026 15:07:52
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StaticFont")]
public partial class StaticFont : global::FrooxEngine.StaticAssetProvider<global::FrooxEngine.Font,global::Elements.Assets.DummyMetadata,global::FrooxEngine.FontVariantDescriptor>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.FontSet>

{
    public global::System.Int32 Padding { get => Padding_Element.Data; set => Padding_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Padding_Element = new();
public global::System.Int32 PixelRange { get => PixelRange_Element.Data; set => PixelRange_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> PixelRange_Element = new();
public global::System.Int32 GlyphEmSize { get => GlyphEmSize_Element.Data; set => GlyphEmSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> GlyphEmSize_Element = new();
public global::System.Boolean MipMaps { get => MipMaps_Element.Data; set => MipMaps_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MipMaps_Element = new();
public global::Elements.Assets.Filtering MipMapFiltering { get => MipMapFiltering_Element.Data; set => MipMapFiltering_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.Filtering>, global::Elements.Assets.Filtering> MipMapFiltering_Element = new();
public global::System.Single LODBias { get => LODBias_Element.Data; set => LODBias_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LODBias_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Padding", Padding_Element.ToLinkField(context));
members.Add("PixelRange", PixelRange_Element.ToLinkField(context));
members.Add("GlyphEmSize", GlyphEmSize_Element.ToLinkField(context));
members.Add("MipMaps", MipMaps_Element.ToLinkField(context));
members.Add("MipMapFiltering", MipMapFiltering_Element.ToLinkField(context));
members.Add("LODBias", LODBias_Element.ToLinkField(context));
}

}
}
