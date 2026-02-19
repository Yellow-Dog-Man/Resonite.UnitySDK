
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyWorldDetail
// Generated on: čtvrtek 19. února 2026 8:00:18
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyWorldDetail")]
public partial class LegacyWorldDetail : global::FrooxEngine.LegacyWorldItem

{
    public global::System.Boolean Expanded;
public global::System.Boolean CompactDetailExpanded;
public global::FrooxEngine.LegacyWorldDetail.DetailCategory CompactDetailCategory;
public UnityEngine.Vector2 ModalCompactSize;
public UnityEngine.Vector2 ModalExpandedSize;
public global::FrooxEngine.UIX.Text _hostText;
public global::FrooxEngine.Slot _sessionItemsRoot;
public global::FrooxEngine.UIX.RawGraphic _thumbnailGraphic;
public global::FrooxEngine.StaticTexture2D _thumbnailTexture;
public global::FrooxEngine.Slot _detailImageRoot;
public global::FrooxEngine.Slot _compactRoot;
public global::FrooxEngine.Slot _compactHeaderRoot;
public global::FrooxEngine.Slot _detailHeaderRoot;
public global::FrooxEngine.IField<global::System.Boolean> _compactMaskEnabled;
public global::FrooxEngine.IField<global::System.Boolean> _compactMaskRootEnabled;
public global::FrooxEngine.UIX.Button _openButton;
public global::FrooxEngine.UIX.ScrollRect _scrollRect;
public global::FrooxEngine.UIX.Button _expandButton;
public global::FrooxEngine.UIX.Image _expandIcon;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite> _expandSprite;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite> _compactSprite;
public global::FrooxEngine.UIX.Text _description;
public global::FrooxEngine.Slot _leftDetailsRoot;
public global::FrooxEngine.Slot _rightDetailsRoot;
public global::FrooxEngine.UIX.Text _detailsText;
public global::FrooxEngine.UIX.Button _cycleLeftButton;
public global::FrooxEngine.UIX.Button _cycleRightButton;
public global::FrooxEngine.SyncRef<global::FrooxEngine.Slot> _compactParent;
public global::FrooxEngine.SyncRef<global::FrooxEngine.Slot> _compactHeaderParent;
public global::FrooxEngine.IField<global::System.Boolean> _sidebarActive;
public global::FrooxEngine.IField<UnityEngine.Vector2> _sidebarAnchorMin;
public global::FrooxEngine.IField<UnityEngine.Vector2> _sidebarAnchorMax;
public global::FrooxEngine.IField<UnityEngine.Vector2> _contentAnchorMin;
public global::FrooxEngine.IField<UnityEngine.Vector2> _contentAnchorMax;
public global::FrooxEngine.IField<global::System.Single> _rectTransformLerp;
public global::FrooxEngine.IField<UnityEngine.Vector2> _modalAnchorMin;
public global::FrooxEngine.IField<UnityEngine.Vector2> _modalAnchorMax;
public global::FrooxEngine.IField<global::System.Boolean> _compactButtonsActive;
public global::FrooxEngine.IField<UnityEngine.Vector2> _compactButtonsAnchorMin;
public global::FrooxEngine.IField<UnityEngine.Vector2> _compactButtonsAnchorMax;
public global::FrooxEngine.IField<UnityEngine.Rect> _compactDetailRect;
public global::FrooxEngine.IField<UnityEngine.Rect> _compactDetailButtonRect;
public global::FrooxEngine.UIX.Text _compactDetailText;
public global::FrooxEngine.UIX.Button _compactDetailExpandButton;
public global::FrooxEngine.Slot _newSessionItemRoot;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Expanded", Expanded.ToResoniteLinkField());
members.Add("CompactDetailExpanded", CompactDetailExpanded.ToResoniteLinkField());
members.Add("CompactDetailCategory", CompactDetailCategory.ToResoniteLinkField());
members.Add("ModalCompactSize", ModalCompactSize.ToResoniteLinkField());
members.Add("ModalExpandedSize", ModalExpandedSize.ToResoniteLinkField());
members.Add("_hostText", _hostText.ToResoniteReference(context));
members.Add("_sessionItemsRoot", _sessionItemsRoot.ToResoniteReference(context));
members.Add("_thumbnailGraphic", _thumbnailGraphic.ToResoniteReference(context));
members.Add("_thumbnailTexture", _thumbnailTexture.ToResoniteReference(context));
members.Add("_detailImageRoot", _detailImageRoot.ToResoniteReference(context));
members.Add("_compactRoot", _compactRoot.ToResoniteReference(context));
members.Add("_compactHeaderRoot", _compactHeaderRoot.ToResoniteReference(context));
members.Add("_detailHeaderRoot", _detailHeaderRoot.ToResoniteReference(context));
members.Add("_compactMaskEnabled", _compactMaskEnabled.ToResoniteReference(context));
members.Add("_compactMaskRootEnabled", _compactMaskRootEnabled.ToResoniteReference(context));
members.Add("_openButton", _openButton.ToResoniteReference(context));
members.Add("_scrollRect", _scrollRect.ToResoniteReference(context));
members.Add("_expandButton", _expandButton.ToResoniteReference(context));
members.Add("_expandIcon", _expandIcon.ToResoniteReference(context));
members.Add("_expandSprite", _expandSprite.ToResoniteReference(context));
members.Add("_compactSprite", _compactSprite.ToResoniteReference(context));
members.Add("_description", _description.ToResoniteReference(context));
members.Add("_leftDetailsRoot", _leftDetailsRoot.ToResoniteReference(context));
members.Add("_rightDetailsRoot", _rightDetailsRoot.ToResoniteReference(context));
members.Add("_detailsText", _detailsText.ToResoniteReference(context));
members.Add("_cycleLeftButton", _cycleLeftButton.ToResoniteReference(context));
members.Add("_cycleRightButton", _cycleRightButton.ToResoniteReference(context));
members.Add("_compactParent", _compactParent.ToResoniteReference(context));
members.Add("_compactHeaderParent", _compactHeaderParent.ToResoniteReference(context));
members.Add("_sidebarActive", _sidebarActive.ToResoniteReference(context));
members.Add("_sidebarAnchorMin", _sidebarAnchorMin.ToResoniteReference(context));
members.Add("_sidebarAnchorMax", _sidebarAnchorMax.ToResoniteReference(context));
members.Add("_contentAnchorMin", _contentAnchorMin.ToResoniteReference(context));
members.Add("_contentAnchorMax", _contentAnchorMax.ToResoniteReference(context));
members.Add("_rectTransformLerp", _rectTransformLerp.ToResoniteReference(context));
members.Add("_modalAnchorMin", _modalAnchorMin.ToResoniteReference(context));
members.Add("_modalAnchorMax", _modalAnchorMax.ToResoniteReference(context));
members.Add("_compactButtonsActive", _compactButtonsActive.ToResoniteReference(context));
members.Add("_compactButtonsAnchorMin", _compactButtonsAnchorMin.ToResoniteReference(context));
members.Add("_compactButtonsAnchorMax", _compactButtonsAnchorMax.ToResoniteReference(context));
members.Add("_compactDetailRect", _compactDetailRect.ToResoniteReference(context));
members.Add("_compactDetailButtonRect", _compactDetailButtonRect.ToResoniteReference(context));
members.Add("_compactDetailText", _compactDetailText.ToResoniteReference(context));
members.Add("_compactDetailExpandButton", _compactDetailExpandButton.ToResoniteReference(context));
members.Add("_newSessionItemRoot", _newSessionItemRoot.ToResoniteReference(context));
}

}
}
