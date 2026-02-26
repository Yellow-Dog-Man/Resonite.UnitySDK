
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.TiledRawImage
// Generated on: čtvrtek 26. února 2026 15:09:02
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Texture { get => Texture_Element.Data; set => Texture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> Texture_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material { get => Material_Element.Data; set => Material_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>> Material_Element = new();
public UnityEngine.ColorX Tint { get => Tint_Element.Data; set => Tint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Tint_Element = new();
public global::FrooxEngine.UIX.TiledRawImage.TileSizeBasis SizeBasis { get => SizeBasis_Element.Data; set => SizeBasis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UIX.TiledRawImage.TileSizeBasis>, global::FrooxEngine.UIX.TiledRawImage.TileSizeBasis> SizeBasis_Element = new();
public UnityEngine.Vector2 TileSize { get => TileSize_Element.Data; set => TileSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TileSize_Element = new();
public UnityEngine.Vector2 TileOffset { get => TileOffset_Element.Data; set => TileOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TileOffset_Element = new();
public global::System.Boolean InteractionTarget { get => InteractionTarget_Element.Data; set => InteractionTarget_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> InteractionTarget_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture_Element.ToLinkReference(context));
members.Add("Material", Material_Element.ToLinkReference(context));
members.Add("Tint", Tint_Element.ToLinkField(context));
members.Add("SizeBasis", SizeBasis_Element.ToLinkField(context));
members.Add("TileSize", TileSize_Element.ToLinkField(context));
members.Add("TileOffset", TileOffset_Element.ToLinkField(context));
members.Add("InteractionTarget", InteractionTarget_Element.ToLinkField(context));
}

}
}
