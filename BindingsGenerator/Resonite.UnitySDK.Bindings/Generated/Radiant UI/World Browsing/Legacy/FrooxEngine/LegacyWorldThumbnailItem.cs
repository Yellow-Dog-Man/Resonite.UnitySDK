
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyWorldThumbnailItem
// Generated on: čtvrtek 26. února 2026 15:09:02
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyWorldThumbnailItem")]
public partial class LegacyWorldThumbnailItem : global::FrooxEngine.LegacyWorldItem, global::FrooxEngine.IButtonPressReceiver, global::FrooxEngine.IButtonHoverReceiver

{
    public global::FrooxEngine.UIX.RawGraphic _thumbnailGraphic { get => _thumbnailGraphic_Element.Data; set => _thumbnailGraphic_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RawGraphic>, global::FrooxEngine.UIX.RawGraphic> _thumbnailGraphic_Element = new();
public global::FrooxEngine.StaticTexture2D _thumbnailTexture { get => _thumbnailTexture_Element.Data; set => _thumbnailTexture_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.StaticTexture2D>, global::FrooxEngine.StaticTexture2D> _thumbnailTexture_Element = new();
public global::FrooxEngine.UIX.RectTransform _nameRoot { get => _nameRoot_Element.Data; set => _nameRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RectTransform>, global::FrooxEngine.UIX.RectTransform> _nameRoot_Element = new();
public global::FrooxEngine.UIX.RectTransform _detailRoot { get => _detailRoot_Element.Data; set => _detailRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RectTransform>, global::FrooxEngine.UIX.RectTransform> _detailRoot_Element = new();
public global::FrooxEngine.UIX.RectTransform _visitedRoot { get => _visitedRoot_Element.Data; set => _visitedRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RectTransform>, global::FrooxEngine.UIX.RectTransform> _visitedRoot_Element = new();
public global::FrooxEngine.UIX.RectTransform _counterRoot { get => _counterRoot_Element.Data; set => _counterRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RectTransform>, global::FrooxEngine.UIX.RectTransform> _counterRoot_Element = new();
public global::FrooxEngine.UIX.RectTransform _iconsRoot { get => _iconsRoot_Element.Data; set => _iconsRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RectTransform>, global::FrooxEngine.UIX.RectTransform> _iconsRoot_Element = new();
public global::FrooxEngine.UIX.RectTransform _closeButton { get => _closeButton_Element.Data; set => _closeButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RectTransform>, global::FrooxEngine.UIX.RectTransform> _closeButton_Element = new();
public global::FrooxEngine.UIX.Text _nameText { get => _nameText_Element.Data; set => _nameText_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _nameText_Element = new();
public global::FrooxEngine.UIX.Text _detailText { get => _detailText_Element.Data; set => _detailText_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _detailText_Element = new();
public global::FrooxEngine.UIX.Text _counterText { get => _counterText_Element.Data; set => _counterText_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _counterText_Element = new();
public global::FrooxEngine.UIX.Image _borderOverlay { get => _borderOverlay_Element.Data; set => _borderOverlay_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Image>, global::FrooxEngine.UIX.Image> _borderOverlay_Element = new();
public UnityEngine.ColorX _borderColor { get => _borderColor_Element.Data; set => _borderColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> _borderColor_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_thumbnailGraphic", _thumbnailGraphic_Element.ToLinkReference(context));
members.Add("_thumbnailTexture", _thumbnailTexture_Element.ToLinkReference(context));
members.Add("_nameRoot", _nameRoot_Element.ToLinkReference(context));
members.Add("_detailRoot", _detailRoot_Element.ToLinkReference(context));
members.Add("_visitedRoot", _visitedRoot_Element.ToLinkReference(context));
members.Add("_counterRoot", _counterRoot_Element.ToLinkReference(context));
members.Add("_iconsRoot", _iconsRoot_Element.ToLinkReference(context));
members.Add("_closeButton", _closeButton_Element.ToLinkReference(context));
members.Add("_nameText", _nameText_Element.ToLinkReference(context));
members.Add("_detailText", _detailText_Element.ToLinkReference(context));
members.Add("_counterText", _counterText_Element.ToLinkReference(context));
members.Add("_borderOverlay", _borderOverlay_Element.ToLinkReference(context));
members.Add("_borderColor", _borderColor_Element.ToLinkField(context));
}

}
}
