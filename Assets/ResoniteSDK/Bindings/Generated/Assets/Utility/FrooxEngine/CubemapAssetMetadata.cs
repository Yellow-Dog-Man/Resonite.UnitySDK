
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CubemapAssetMetadata
// Generated on: sobota 14. února 2026 8:57:01
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CubemapAssetMetadata")]
public partial class CubemapAssetMetadata : global::FrooxEngine.Component

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Cubemap> Cubemap;
public global::System.Int32 Size;
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
members.Add("Cubemap", Cubemap.ToResoniteReference(context));
members.Add("Size", Size.ToResoniteLinkField());
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
