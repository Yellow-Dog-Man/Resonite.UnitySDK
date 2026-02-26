
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ITexture2DAssetMetadata
// Generated on: čtvrtek 26. února 2026 15:07:56
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Texture { get => Texture_Element.Data; set => Texture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> Texture_Element = new();
public UnityEngine.Vector2Int Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> Size_Element = new();
public global::System.Int32 Width { get => Width_Element.Data; set => Width_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> Width_Element = new();
public global::System.Int32 Height { get => Height_Element.Data; set => Height_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> Height_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture_Element.ToLinkReference(context));
members.Add("Size", Size_Element.ToLinkField(context));
members.Add("Width", Width_Element.ToLinkField(context));
members.Add("Height", Height_Element.ToLinkField(context));
}

}
}
