
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ItemTextureThumbnailSource
// Generated on: sobota 14. února 2026 8:58:45
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ItemTextureThumbnailSource")]
public partial class ItemTextureThumbnailSource : global::FrooxEngine.Component, global::FrooxEngine.IItemThumbnailSource, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> Texture;
public global::System.Nullable<UnityEngine.Rect> Crop;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture.ToResoniteReference(context));
members.Add("Crop", Crop.ToResoniteLinkField());
}

}
}
