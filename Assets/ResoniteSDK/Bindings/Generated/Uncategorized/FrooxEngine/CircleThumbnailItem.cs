
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CircleThumbnailItem
// Generated on: sobota 14. února 2026 8:58:42
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CircleThumbnailItem")]
public abstract partial class CircleThumbnailItem : global::FrooxEngine.Component

{
    public global::FrooxEngine.UIX.Image _background;
public global::FrooxEngine.UIX.Image _statusIndicator;
public global::FrooxEngine.UIX.Image _thumbnail;
public global::FrooxEngine.StaticTexture2D _thumbnailTexture;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_background", _background.ToResoniteReference(context));
members.Add("_statusIndicator", _statusIndicator.ToResoniteReference(context));
members.Add("_thumbnail", _thumbnail.ToResoniteReference(context));
members.Add("_thumbnailTexture", _thumbnailTexture.ToResoniteReference(context));
}

}
}
