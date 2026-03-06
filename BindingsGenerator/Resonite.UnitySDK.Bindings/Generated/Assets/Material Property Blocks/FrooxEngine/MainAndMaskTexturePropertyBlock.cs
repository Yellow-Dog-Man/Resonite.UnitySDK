
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MainAndMaskTexturePropertyBlock
// Generated on: pátek 6. března 2026 14:18:03
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MainAndMaskTexturePropertyBlock")]
public partial class MainAndMaskTexturePropertyBlock : global::FrooxEngine.MaterialPropertyBlockProvider

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Texture { get => Texture_Element.Data; set => Texture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> Texture_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MaskTexture { get => MaskTexture_Element.Data; set => MaskTexture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> MaskTexture_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture_Element.ToLinkReference(context));
members.Add("MaskTexture", MaskTexture_Element.ToLinkReference(context));
}

}
}
