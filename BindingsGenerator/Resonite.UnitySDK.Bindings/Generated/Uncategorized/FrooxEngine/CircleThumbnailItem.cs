
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CircleThumbnailItem
// Generated on: čtvrtek 26. února 2026 15:09:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CircleThumbnailItem")]
public abstract partial class CircleThumbnailItem : global::FrooxEngine.Component

{
    public global::FrooxEngine.UIX.Image _background { get => _background_Element.Data; set => _background_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Image>, global::FrooxEngine.UIX.Image> _background_Element = new();
public global::FrooxEngine.UIX.Image _statusIndicator { get => _statusIndicator_Element.Data; set => _statusIndicator_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Image>, global::FrooxEngine.UIX.Image> _statusIndicator_Element = new();
public global::FrooxEngine.UIX.Image _thumbnail { get => _thumbnail_Element.Data; set => _thumbnail_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Image>, global::FrooxEngine.UIX.Image> _thumbnail_Element = new();
public global::FrooxEngine.StaticTexture2D _thumbnailTexture { get => _thumbnailTexture_Element.Data; set => _thumbnailTexture_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.StaticTexture2D>, global::FrooxEngine.StaticTexture2D> _thumbnailTexture_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_background", _background_Element.ToLinkReference(context));
members.Add("_statusIndicator", _statusIndicator_Element.ToLinkReference(context));
members.Add("_thumbnail", _thumbnail_Element.ToLinkReference(context));
members.Add("_thumbnailTexture", _thumbnailTexture_Element.ToLinkReference(context));
}

}
}
