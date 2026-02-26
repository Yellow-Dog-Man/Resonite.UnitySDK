
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StaticTextureProvider<,,,>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StaticTextureProvider<,,,>")]
public abstract partial class StaticTextureProvider<A,B,M,D> : global::FrooxEngine.StaticAssetProvider<A,M,D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture>, global::FrooxEngine.ITextureProvider
	where D : class, global::FrooxEngine.IEngineTextureVariantDescriptor
	where M : global::Elements.Assets.ImageMetadataBase
	where B : global::Elements.Assets.Bitmap
	where A : global::FrooxEngine.Asset, global::FrooxEngine.ITexture

{
    public global::System.Nullable<global::Renderite.Shared.TextureFilterMode> FilterMode { get => FilterMode_Element.Data; set => FilterMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::Renderite.Shared.TextureFilterMode>>, global::System.Nullable<global::Renderite.Shared.TextureFilterMode>> FilterMode_Element = new();
public global::System.Nullable<global::System.Int32> AnisotropicLevel { get => AnisotropicLevel_Element.Data; set => AnisotropicLevel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> AnisotropicLevel_Element = new();
public global::System.Boolean Uncompressed { get => Uncompressed_Element.Data; set => Uncompressed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Uncompressed_Element = new();
public global::System.Boolean DirectLoad { get => DirectLoad_Element.Data; set => DirectLoad_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DirectLoad_Element = new();
public global::System.Boolean ForceExactVariant { get => ForceExactVariant_Element.Data; set => ForceExactVariant_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ForceExactVariant_Element = new();
public global::System.Nullable<global::Elements.Assets.TextureCompression> PreferredFormat { get => PreferredFormat_Element.Data; set => PreferredFormat_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::Elements.Assets.TextureCompression>>, global::System.Nullable<global::Elements.Assets.TextureCompression>> PreferredFormat_Element = new();
public global::System.Nullable<global::Renderite.Shared.ColorProfile> PreferredProfile { get => PreferredProfile_Element.Data; set => PreferredProfile_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::Renderite.Shared.ColorProfile>>, global::System.Nullable<global::Renderite.Shared.ColorProfile>> PreferredProfile_Element = new();
public global::System.Single MipMapBias { get => MipMapBias_Element.Data; set => MipMapBias_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MipMapBias_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FilterMode", FilterMode_Element.ToLinkField(context));
members.Add("AnisotropicLevel", AnisotropicLevel_Element.ToLinkField(context));
members.Add("Uncompressed", Uncompressed_Element.ToLinkField(context));
members.Add("DirectLoad", DirectLoad_Element.ToLinkField(context));
members.Add("ForceExactVariant", ForceExactVariant_Element.ToLinkField(context));
members.Add("PreferredFormat", PreferredFormat_Element.ToLinkField(context));
members.Add("PreferredProfile", PreferredProfile_Element.ToLinkField(context));
members.Add("MipMapBias", MipMapBias_Element.ToLinkField(context));
}

}
}
