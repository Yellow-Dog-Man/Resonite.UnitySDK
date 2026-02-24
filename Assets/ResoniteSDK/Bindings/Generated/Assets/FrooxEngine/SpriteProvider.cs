
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SpriteProvider
// Generated on: úterý 24. února 2026 18:17:32
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SpriteProvider")]
public partial class SpriteProvider : global::FrooxEngine.DynamicAssetProvider<global::FrooxEngine.Sprite>

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Texture;
public UnityEngine.Rect Rect;
public UnityEngine.Vector4 Borders;
public global::System.Single Scale;
public global::System.Single FixedSize;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture.ToResoniteReference(context));
members.Add("Rect", Rect.ToResoniteLinkField());
members.Add("Borders", Borders.ToResoniteLinkField());
members.Add("Scale", Scale.ToResoniteLinkField());
members.Add("FixedSize", FixedSize.ToResoniteLinkField());
}

}
}
