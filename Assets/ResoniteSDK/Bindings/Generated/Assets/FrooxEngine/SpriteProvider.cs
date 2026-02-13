
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SpriteProvider
// Generated on: pátek 13. února 2026 23:21:31
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SpriteProvider")]
public partial class SpriteProvider : global::FrooxEngine.DynamicAssetProvider<global::FrooxEngine.Sprite>

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Texture;
public UnityEngine.Rect Rect;
public UnityEngine.Vector4 Borders;
public global::System.Single Scale;
public global::System.Single FixedSize;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Texture", new ResoniteLink.Reference() { });
members.Add("Rect", Rect.ToResoniteLinkField());
members.Add("Borders", Borders.ToResoniteLinkField());
members.Add("Scale", Scale.ToResoniteLinkField());
members.Add("FixedSize", FixedSize.ToResoniteLinkField());
}

}
}
