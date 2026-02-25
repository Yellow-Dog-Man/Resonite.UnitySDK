
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VideoTextureAssetMetadata
// Generated on: středa 25. února 2026 16:13:05
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
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.VideoTexture> Texture;
public UnityEngine.Vector2Int Size;
public global::System.Int32 Width;
public global::System.Int32 Height;
public global::System.Boolean HasAlpha;
public global::System.Double Length;
public global::System.String PlaybackEngine;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture.ToResoniteReference(context));
members.Add("Size", Size.ToResoniteLinkField());
members.Add("Width", Width.ToResoniteLinkField());
members.Add("Height", Height.ToResoniteLinkField());
members.Add("HasAlpha", HasAlpha.ToResoniteLinkField());
members.Add("Length", Length.ToResoniteLinkField());
members.Add("PlaybackEngine", PlaybackEngine.ToResoniteLinkField());
}

}
}
