
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyWorldThumbnailItem
// Generated on: pátek 13. února 2026 5:52:19
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyWorldThumbnailItem")]
public partial class LegacyWorldThumbnailItem : global::FrooxEngine.LegacyWorldItem, global::FrooxEngine.IButtonPressReceiver, global::FrooxEngine.IButtonHoverReceiver

{
    public global::FrooxEngine.UIX.RawGraphic _thumbnailGraphic;
public global::FrooxEngine.StaticTexture2D _thumbnailTexture;
public global::FrooxEngine.UIX.RectTransform _nameRoot;
public global::FrooxEngine.UIX.RectTransform _detailRoot;
public global::FrooxEngine.UIX.RectTransform _visitedRoot;
public global::FrooxEngine.UIX.RectTransform _counterRoot;
public global::FrooxEngine.UIX.RectTransform _iconsRoot;
public global::FrooxEngine.UIX.RectTransform _closeButton;
public global::FrooxEngine.UIX.Text _nameText;
public global::FrooxEngine.UIX.Text _detailText;
public global::FrooxEngine.UIX.Text _counterText;
public global::FrooxEngine.UIX.Image _borderOverlay;
public UnityEngine.ColorX _borderColor;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_thumbnailGraphic", new ResoniteLink.Reference() { });
members.Add("_thumbnailTexture", new ResoniteLink.Reference() { });
members.Add("_nameRoot", new ResoniteLink.Reference() { });
members.Add("_detailRoot", new ResoniteLink.Reference() { });
members.Add("_visitedRoot", new ResoniteLink.Reference() { });
members.Add("_counterRoot", new ResoniteLink.Reference() { });
members.Add("_iconsRoot", new ResoniteLink.Reference() { });
members.Add("_closeButton", new ResoniteLink.Reference() { });
members.Add("_nameText", new ResoniteLink.Reference() { });
members.Add("_detailText", new ResoniteLink.Reference() { });
members.Add("_counterText", new ResoniteLink.Reference() { });
members.Add("_borderOverlay", new ResoniteLink.Reference() { });
members.Add("_borderColor", _borderColor.ToResoniteLinkField());
}

}
}
