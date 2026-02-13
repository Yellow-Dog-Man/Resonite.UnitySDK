
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CircleThumbnailItem
// Generated on: pátek 13. února 2026 23:23:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CircleThumbnailItem")]
public abstract partial class CircleThumbnailItem : global::FrooxEngine.Component

{
    public global::FrooxEngine.UIX.Image _background;
public global::FrooxEngine.UIX.Image _statusIndicator;
public global::FrooxEngine.UIX.Image _thumbnail;
public global::FrooxEngine.StaticTexture2D _thumbnailTexture;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_background", new ResoniteLink.Reference() { });
members.Add("_statusIndicator", new ResoniteLink.Reference() { });
members.Add("_thumbnail", new ResoniteLink.Reference() { });
members.Add("_thumbnailTexture", new ResoniteLink.Reference() { });
}

}
}
