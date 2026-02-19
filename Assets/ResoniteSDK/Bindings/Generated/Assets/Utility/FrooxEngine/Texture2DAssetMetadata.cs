
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Texture2DAssetMetadata
// Generated on: čtvrtek 19. února 2026 7:58:54
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Texture2DAssetMetadata")]
public partial class Texture2DAssetMetadata : global::FrooxEngine.Component

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> Texture;
public UnityEngine.Vector2Int Size;
public global::System.Int32 Width;
public global::System.Int32 Height;
public global::System.Boolean HasMipMaps;
public global::System.Int32 MipMapCount;
public global::System.Int64 MemoryBytes;
public global::System.String FormattedMemoryBytes;
public global::Renderite.Shared.TextureFormat Format;
public global::System.String ActualLoadedVariant;
public global::Renderite.Shared.ColorProfile Profile;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture.ToResoniteReference(context));
members.Add("Size", Size.ToResoniteLinkField());
members.Add("Width", Width.ToResoniteLinkField());
members.Add("Height", Height.ToResoniteLinkField());
members.Add("HasMipMaps", HasMipMaps.ToResoniteLinkField());
members.Add("MipMapCount", MipMapCount.ToResoniteLinkField());
members.Add("MemoryBytes", MemoryBytes.ToResoniteLinkField());
members.Add("FormattedMemoryBytes", FormattedMemoryBytes.ToResoniteLinkField());
members.Add("Format", Format.ToResoniteLinkField());
members.Add("ActualLoadedVariant", ActualLoadedVariant.ToResoniteLinkField());
members.Add("Profile", Profile.ToResoniteLinkField());
}

}
}
