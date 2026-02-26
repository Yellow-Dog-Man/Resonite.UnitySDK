
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StaticTexture2D
// Generated on: čtvrtek 26. února 2026 12:26:46
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public global::System.Boolean IsNormalMap { get => IsNormalMap_Element.Data; set => IsNormalMap_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsNormalMap_Element = new();
public global::Renderite.Shared.TextureWrapMode WrapModeU { get => WrapModeU_Element.Data; set => WrapModeU_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.TextureWrapMode>, global::Renderite.Shared.TextureWrapMode> WrapModeU_Element = new();
public global::Renderite.Shared.TextureWrapMode WrapModeV { get => WrapModeV_Element.Data; set => WrapModeV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.TextureWrapMode>, global::Renderite.Shared.TextureWrapMode> WrapModeV_Element = new();
public global::System.Single PowerOfTwoAlignThreshold { get => PowerOfTwoAlignThreshold_Element.Data; set => PowerOfTwoAlignThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PowerOfTwoAlignThreshold_Element = new();
public global::System.Boolean CrunchCompressed { get => CrunchCompressed_Element.Data; set => CrunchCompressed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CrunchCompressed_Element = new();
public global::System.Nullable<global::System.Int32> MinSize { get => MinSize_Element.Data; set => MinSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> MinSize_Element = new();
public global::System.Nullable<global::System.Int32> MaxSize { get => MaxSize_Element.Data; set => MaxSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> MaxSize_Element = new();
public global::System.Boolean MipMaps { get => MipMaps_Element.Data; set => MipMaps_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MipMaps_Element = new();
public global::System.Boolean KeepOriginalMipMaps { get => KeepOriginalMipMaps_Element.Data; set => KeepOriginalMipMaps_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> KeepOriginalMipMaps_Element = new();
public global::Elements.Assets.Filtering MipMapFilter { get => MipMapFilter_Element.Data; set => MipMapFilter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.Filtering>, global::Elements.Assets.Filtering> MipMapFilter_Element = new();
public global::System.Boolean Readable { get => Readable_Element.Data; set => Readable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Readable_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsNormalMap", IsNormalMap_Element.ToLinkField(context));
members.Add("WrapModeU", WrapModeU_Element.ToLinkField(context));
members.Add("WrapModeV", WrapModeV_Element.ToLinkField(context));
members.Add("PowerOfTwoAlignThreshold", PowerOfTwoAlignThreshold_Element.ToLinkField(context));
members.Add("CrunchCompressed", CrunchCompressed_Element.ToLinkField(context));
members.Add("MinSize", MinSize_Element.ToLinkField(context));
members.Add("MaxSize", MaxSize_Element.ToLinkField(context));
members.Add("MipMaps", MipMaps_Element.ToLinkField(context));
members.Add("KeepOriginalMipMaps", KeepOriginalMipMaps_Element.ToLinkField(context));
members.Add("MipMapFilter", MipMapFilter_Element.ToLinkField(context));
members.Add("Readable", Readable_Element.ToLinkField(context));
}

}
}
