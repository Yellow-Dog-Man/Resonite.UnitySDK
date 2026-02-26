
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VideoTextureAssetMetadata
// Generated on: čtvrtek 26. února 2026 10:03:36
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VideoTextureAssetMetadata")]
public partial class VideoTextureAssetMetadata : global::FrooxEngine.Component

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.VideoTexture> Texture { get => Texture_Element.Data; set => Texture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.VideoTexture>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.VideoTexture>> Texture_Element = new();
public UnityEngine.Vector2Int Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> Size_Element = new();
public global::System.Int32 Width { get => Width_Element.Data; set => Width_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> Width_Element = new();
public global::System.Int32 Height { get => Height_Element.Data; set => Height_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> Height_Element = new();
public global::System.Boolean HasAlpha { get => HasAlpha_Element.Data; set => HasAlpha_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> HasAlpha_Element = new();
public global::System.Double Length { get => Length_Element.Data; set => Length_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Double>, global::System.Double> Length_Element = new();
public global::System.String PlaybackEngine { get => PlaybackEngine_Element.Data; set => PlaybackEngine_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> PlaybackEngine_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture_Element.Data.ToResoniteReference(context));
members.Add("Size", Size_Element.Data.ToResoniteLinkField());
members.Add("Width", Width_Element.Data.ToResoniteLinkField());
members.Add("Height", Height_Element.Data.ToResoniteLinkField());
members.Add("HasAlpha", HasAlpha_Element.Data.ToResoniteLinkField());
members.Add("Length", Length_Element.Data.ToResoniteLinkField());
members.Add("PlaybackEngine", PlaybackEngine_Element.Data.ToResoniteLinkField());
}

}
}
