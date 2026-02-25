
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.TiledRawImage
// Generated on: středa 25. února 2026 16:14:15
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.TiledRawImage")]
public partial class TiledRawImage : global::FrooxEngine.UIX.Graphic

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Texture;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material;
public UnityEngine.ColorX Tint;
public global::FrooxEngine.UIX.TiledRawImage.TileSizeBasis SizeBasis;
public UnityEngine.Vector2 TileSize;
public UnityEngine.Vector2 TileOffset;
public global::System.Boolean InteractionTarget;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture.ToResoniteReference(context));
members.Add("Material", Material.ToResoniteReference(context));
members.Add("Tint", Tint.ToResoniteLinkField());
members.Add("SizeBasis", SizeBasis.ToResoniteLinkField());
members.Add("TileSize", TileSize.ToResoniteLinkField());
members.Add("TileOffset", TileOffset.ToResoniteLinkField());
members.Add("InteractionTarget", InteractionTarget.ToResoniteLinkField());
}

}
}
