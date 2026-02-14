
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ITexture2DAssetMetadata
// Generated on: sobota 14. února 2026 8:57:01
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ITexture2DAssetMetadata")]
public partial class ITexture2DAssetMetadata : global::FrooxEngine.Component

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Texture;
public UnityEngine.Vector2Int Size;
public global::System.Int32 Width;
public global::System.Int32 Height;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture.ToResoniteReference(context));
members.Add("Size", Size.ToResoniteLinkField());
members.Add("Width", Width.ToResoniteLinkField());
members.Add("Height", Height.ToResoniteLinkField());
}

}
}
