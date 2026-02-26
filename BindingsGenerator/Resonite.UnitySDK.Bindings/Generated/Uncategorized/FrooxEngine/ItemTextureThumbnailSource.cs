
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ItemTextureThumbnailSource
// Generated on: čtvrtek 26. února 2026 12:28:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ItemTextureThumbnailSource")]
public partial class ItemTextureThumbnailSource : global::FrooxEngine.Component, global::FrooxEngine.IItemThumbnailSource, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> Texture { get => Texture_Element.Data; set => Texture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D>> Texture_Element = new();
public global::System.Nullable<UnityEngine.Rect> Crop { get => Crop_Element.Data; set => Crop_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Rect>>, global::System.Nullable<UnityEngine.Rect>> Crop_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture_Element.ToLinkReference(context));
members.Add("Crop", Crop_Element.ToLinkField(context));
}

}
}
