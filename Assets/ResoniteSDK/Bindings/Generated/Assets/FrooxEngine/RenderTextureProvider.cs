
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RenderTextureProvider
// Generated on: čtvrtek 19. února 2026 7:58:49
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RenderTextureProvider")]
public partial class RenderTextureProvider : global::FrooxEngine.AssetProvider<global::FrooxEngine.RenderTexture>, global::FrooxEngine.ITexture2DProvider, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>, global::FrooxEngine.ITextureProvider, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture>

{
    public UnityEngine.Vector2Int Size;
public global::System.Int32 Depth;
public global::Renderite.Shared.TextureFilterMode FilterMode;
public global::System.Int32 AnisotropicLevel;
public global::Renderite.Shared.TextureWrapMode WrapModeU;
public global::Renderite.Shared.TextureWrapMode WrapModeV;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Size", Size.ToResoniteLinkField());
members.Add("Depth", Depth.ToResoniteLinkField());
members.Add("FilterMode", FilterMode.ToResoniteLinkField());
members.Add("AnisotropicLevel", AnisotropicLevel.ToResoniteLinkField());
members.Add("WrapModeU", WrapModeU.ToResoniteLinkField());
members.Add("WrapModeV", WrapModeV.ToResoniteLinkField());
}

}
}
