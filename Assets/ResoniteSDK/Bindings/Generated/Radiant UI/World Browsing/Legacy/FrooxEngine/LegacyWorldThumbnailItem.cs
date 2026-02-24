
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyWorldThumbnailItem
// Generated on: úterý 24. února 2026 18:20:04
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_thumbnailGraphic", _thumbnailGraphic.ToResoniteReference(context));
members.Add("_thumbnailTexture", _thumbnailTexture.ToResoniteReference(context));
members.Add("_nameRoot", _nameRoot.ToResoniteReference(context));
members.Add("_detailRoot", _detailRoot.ToResoniteReference(context));
members.Add("_visitedRoot", _visitedRoot.ToResoniteReference(context));
members.Add("_counterRoot", _counterRoot.ToResoniteReference(context));
members.Add("_iconsRoot", _iconsRoot.ToResoniteReference(context));
members.Add("_closeButton", _closeButton.ToResoniteReference(context));
members.Add("_nameText", _nameText.ToResoniteReference(context));
members.Add("_detailText", _detailText.ToResoniteReference(context));
members.Add("_counterText", _counterText.ToResoniteReference(context));
members.Add("_borderOverlay", _borderOverlay.ToResoniteReference(context));
members.Add("_borderColor", _borderColor.ToResoniteLinkField());
}

}
}
