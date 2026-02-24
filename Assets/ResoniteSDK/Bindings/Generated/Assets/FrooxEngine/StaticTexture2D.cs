
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StaticTexture2D
// Generated on: úterý 24. února 2026 18:17:33
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StaticTexture2D")]
public partial class StaticTexture2D : global::FrooxEngine.StaticTextureProvider<global::FrooxEngine.Texture2D,global::Elements.Assets.Bitmap2D,global::Elements.Assets.BitmapMetadata,global::FrooxEngine.Texture2DVariantDescriptor>, global::FrooxEngine.ITexture2DProvider, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>

{
    public global::System.Boolean IsNormalMap;
public global::Renderite.Shared.TextureWrapMode WrapModeU;
public global::Renderite.Shared.TextureWrapMode WrapModeV;
public global::System.Single PowerOfTwoAlignThreshold;
public global::System.Boolean CrunchCompressed;
public global::System.Nullable<global::System.Int32> MinSize;
public global::System.Nullable<global::System.Int32> MaxSize;
public global::System.Boolean MipMaps;
public global::System.Boolean KeepOriginalMipMaps;
public global::Elements.Assets.Filtering MipMapFilter;
public global::System.Boolean Readable;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsNormalMap", IsNormalMap.ToResoniteLinkField());
members.Add("WrapModeU", WrapModeU.ToResoniteLinkField());
members.Add("WrapModeV", WrapModeV.ToResoniteLinkField());
members.Add("PowerOfTwoAlignThreshold", PowerOfTwoAlignThreshold.ToResoniteLinkField());
members.Add("CrunchCompressed", CrunchCompressed.ToResoniteLinkField());
members.Add("MinSize", MinSize.ToResoniteLinkField());
members.Add("MaxSize", MaxSize.ToResoniteLinkField());
members.Add("MipMaps", MipMaps.ToResoniteLinkField());
members.Add("KeepOriginalMipMaps", KeepOriginalMipMaps.ToResoniteLinkField());
members.Add("MipMapFilter", MipMapFilter.ToResoniteLinkField());
members.Add("Readable", Readable.ToResoniteLinkField());
}

}
}
