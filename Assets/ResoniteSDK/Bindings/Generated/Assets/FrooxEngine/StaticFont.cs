
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StaticFont
// Generated on: pátek 13. února 2026 5:51:04
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StaticFont")]
public partial class StaticFont : global::FrooxEngine.StaticAssetProvider<global::FrooxEngine.Font,global::Elements.Assets.DummyMetadata,global::FrooxEngine.FontVariantDescriptor>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.FontSet>

{
    public global::System.Int32 Padding;
public global::System.Int32 PixelRange;
public global::System.Int32 GlyphEmSize;
public global::System.Boolean MipMaps;
public global::Elements.Assets.Filtering MipMapFiltering;
public global::System.Single LODBias;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Padding", Padding.ToResoniteLinkField());
members.Add("PixelRange", PixelRange.ToResoniteLinkField());
members.Add("GlyphEmSize", GlyphEmSize.ToResoniteLinkField());
members.Add("MipMaps", MipMaps.ToResoniteLinkField());
members.Add("MipMapFiltering", MipMapFiltering.ToResoniteLinkField());
members.Add("LODBias", LODBias.ToResoniteLinkField());
}

}
}
