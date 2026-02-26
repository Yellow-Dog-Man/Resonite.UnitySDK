
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RenderTextureProvider
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RenderTextureProvider")]
public partial class RenderTextureProvider : global::FrooxEngine.AssetProvider<global::FrooxEngine.RenderTexture>, global::FrooxEngine.ITexture2DProvider, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>, global::FrooxEngine.ITextureProvider, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture>

{
    public UnityEngine.Vector2Int Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> Size_Element = new();
public global::System.Int32 Depth { get => Depth_Element.Data; set => Depth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Depth_Element = new();
public global::Renderite.Shared.TextureFilterMode FilterMode { get => FilterMode_Element.Data; set => FilterMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.TextureFilterMode>, global::Renderite.Shared.TextureFilterMode> FilterMode_Element = new();
public global::System.Int32 AnisotropicLevel { get => AnisotropicLevel_Element.Data; set => AnisotropicLevel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> AnisotropicLevel_Element = new();
public global::Renderite.Shared.TextureWrapMode WrapModeU { get => WrapModeU_Element.Data; set => WrapModeU_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.TextureWrapMode>, global::Renderite.Shared.TextureWrapMode> WrapModeU_Element = new();
public global::Renderite.Shared.TextureWrapMode WrapModeV { get => WrapModeV_Element.Data; set => WrapModeV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.TextureWrapMode>, global::Renderite.Shared.TextureWrapMode> WrapModeV_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Size", Size_Element.ToLinkField(context));
members.Add("Depth", Depth_Element.ToLinkField(context));
members.Add("FilterMode", FilterMode_Element.ToLinkField(context));
members.Add("AnisotropicLevel", AnisotropicLevel_Element.ToLinkField(context));
members.Add("WrapModeU", WrapModeU_Element.ToLinkField(context));
members.Add("WrapModeV", WrapModeV_Element.ToLinkField(context));
}

}
}
