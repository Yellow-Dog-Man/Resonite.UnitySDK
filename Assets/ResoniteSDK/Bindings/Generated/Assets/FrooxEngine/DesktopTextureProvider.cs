
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DesktopTextureProvider
// Generated on: pátek 13. února 2026 23:21:30
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DesktopTextureProvider")]
public partial class DesktopTextureProvider : global::FrooxEngine.AssetProvider<global::FrooxEngine.DesktopTexture>, global::FrooxEngine.ITexture2DProvider, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>, global::FrooxEngine.ITextureProvider, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture>

{
    public global::System.Int32 DisplayIndex;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("DisplayIndex", DisplayIndex.ToResoniteLinkField());
}

}
}
