
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyWorldDetail
// Generated on: pátek 13. února 2026 23:23:02
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Expanded", Expanded.ToResoniteLinkField());
members.Add("CompactDetailExpanded", CompactDetailExpanded.ToResoniteLinkField());
members.Add("CompactDetailCategory", CompactDetailCategory.ToResoniteLinkField());
members.Add("ModalCompactSize", ModalCompactSize.ToResoniteLinkField());
members.Add("ModalExpandedSize", ModalExpandedSize.ToResoniteLinkField());
members.Add("_hostText", new ResoniteLink.Reference() { });
members.Add("_sessionItemsRoot", new ResoniteLink.Reference() { });
members.Add("_thumbnailGraphic", new ResoniteLink.Reference() { });
members.Add("_thumbnailTexture", new ResoniteLink.Reference() { });
members.Add("_detailImageRoot", new ResoniteLink.Reference() { });
members.Add("_compactRoot", new ResoniteLink.Reference() { });
members.Add("_compactHeaderRoot", new ResoniteLink.Reference() { });
members.Add("_detailHeaderRoot", new ResoniteLink.Reference() { });
members.Add("_compactMaskEnabled", new ResoniteLink.Reference() { });
members.Add("_compactMaskRootEnabled", new ResoniteLink.Reference() { });
members.Add("_openButton", new ResoniteLink.Reference() { });
members.Add("_scrollRect", new ResoniteLink.Reference() { });
members.Add("_expandButton", new ResoniteLink.Reference() { });
members.Add("_expandIcon", new ResoniteLink.Reference() { });
members.Add("_expandSprite", new ResoniteLink.Reference() { });
members.Add("_compactSprite", new ResoniteLink.Reference() { });
members.Add("_description", new ResoniteLink.Reference() { });
members.Add("_leftDetailsRoot", new ResoniteLink.Reference() { });
members.Add("_rightDetailsRoot", new ResoniteLink.Reference() { });
members.Add("_detailsText", new ResoniteLink.Reference() { });
members.Add("_cycleLeftButton", new ResoniteLink.Reference() { });
members.Add("_cycleRightButton", new ResoniteLink.Reference() { });
members.Add("_compactParent", new ResoniteLink.Reference() { });
members.Add("_compactHeaderParent", new ResoniteLink.Reference() { });
members.Add("_sidebarActive", new ResoniteLink.Reference() { });
members.Add("_sidebarAnchorMin", new ResoniteLink.Reference() { });
members.Add("_sidebarAnchorMax", new ResoniteLink.Reference() { });
members.Add("_contentAnchorMin", new ResoniteLink.Reference() { });
members.Add("_contentAnchorMax", new ResoniteLink.Reference() { });
members.Add("_rectTransformLerp", new ResoniteLink.Reference() { });
members.Add("_modalAnchorMin", new ResoniteLink.Reference() { });
members.Add("_modalAnchorMax", new ResoniteLink.Reference() { });
members.Add("_compactButtonsActive", new ResoniteLink.Reference() { });
members.Add("_compactButtonsAnchorMin", new ResoniteLink.Reference() { });
members.Add("_compactButtonsAnchorMax", new ResoniteLink.Reference() { });
members.Add("_compactDetailRect", new ResoniteLink.Reference() { });
members.Add("_compactDetailButtonRect", new ResoniteLink.Reference() { });
members.Add("_compactDetailText", new ResoniteLink.Reference() { });
members.Add("_compactDetailExpandButton", new ResoniteLink.Reference() { });
members.Add("_newSessionItemRoot", new ResoniteLink.Reference() { });
}

}
}
