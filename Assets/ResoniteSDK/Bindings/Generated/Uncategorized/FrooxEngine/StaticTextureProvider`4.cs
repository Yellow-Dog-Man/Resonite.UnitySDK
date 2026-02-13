
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StaticTextureProvider<,,,>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StaticTextureProvider<,,,>")]
public abstract partial class StaticTextureProvider<A,B,M,D> : global::FrooxEngine.StaticAssetProvider<A,M,D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture>, global::FrooxEngine.ITextureProvider
	where D : class, global::FrooxEngine.IEngineTextureVariantDescriptor
	where M : global::Elements.Assets.ImageMetadataBase
	where B : global::Elements.Assets.Bitmap
	where A : global::FrooxEngine.Asset, global::FrooxEngine.ITexture

{
    public global::System.Nullable<global::Renderite.Shared.TextureFilterMode> FilterMode;
public global::System.Nullable<global::System.Int32> AnisotropicLevel;
public global::System.Boolean Uncompressed;
public global::System.Boolean DirectLoad;
public global::System.Boolean ForceExactVariant;
public global::System.Nullable<global::Elements.Assets.TextureCompression> PreferredFormat;
public global::System.Nullable<global::Renderite.Shared.ColorProfile> PreferredProfile;
public global::System.Single MipMapBias;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("FilterMode", FilterMode.ToResoniteLinkField());
members.Add("AnisotropicLevel", AnisotropicLevel.ToResoniteLinkField());
members.Add("Uncompressed", Uncompressed.ToResoniteLinkField());
members.Add("DirectLoad", DirectLoad.ToResoniteLinkField());
members.Add("ForceExactVariant", ForceExactVariant.ToResoniteLinkField());
members.Add("PreferredFormat", PreferredFormat.ToResoniteLinkField());
members.Add("PreferredProfile", PreferredProfile.ToResoniteLinkField());
members.Add("MipMapBias", MipMapBias.ToResoniteLinkField());
}

}
}
