
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MainAndMaskTexturePropertyBlock
// Generated on: pátek 13. února 2026 5:51:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MainAndMaskTexturePropertyBlock")]
public partial class MainAndMaskTexturePropertyBlock : global::FrooxEngine.MaterialPropertyBlockProvider

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Texture;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MaskTexture;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Texture", new ResoniteLink.Reference() { });
members.Add("MaskTexture", new ResoniteLink.Reference() { });
}

}
}
