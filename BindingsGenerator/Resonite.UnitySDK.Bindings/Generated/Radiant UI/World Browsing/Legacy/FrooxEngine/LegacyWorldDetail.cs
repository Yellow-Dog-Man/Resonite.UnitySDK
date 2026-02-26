
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyWorldDetail
// Generated on: čtvrtek 26. února 2026 10:04:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyWorldDetail")]
public partial class LegacyWorldDetail : global::FrooxEngine.LegacyWorldItem

{
    public global::System.Boolean Expanded { get => Expanded_Element.Data; set => Expanded_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Expanded_Element = new();
public global::System.Boolean CompactDetailExpanded { get => CompactDetailExpanded_Element.Data; set => CompactDetailExpanded_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CompactDetailExpanded_Element = new();
public global::FrooxEngine.LegacyWorldDetail.DetailCategory CompactDetailCategory { get => CompactDetailCategory_Element.Data; set => CompactDetailCategory_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.LegacyWorldDetail.DetailCategory>, global::FrooxEngine.LegacyWorldDetail.DetailCategory> CompactDetailCategory_Element = new();
public UnityEngine.Vector2 ModalCompactSize { get => ModalCompactSize_Element.Data; set => ModalCompactSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> ModalCompactSize_Element = new();
public UnityEngine.Vector2 ModalExpandedSize { get => ModalExpandedSize_Element.Data; set => ModalExpandedSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> ModalExpandedSize_Element = new();
public global::FrooxEngine.UIX.Text _hostText { get => _hostText_Element.Data; set => _hostText_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _hostText_Element = new();
public global::FrooxEngine.Slot _sessionItemsRoot { get => _sessionItemsRoot_Element.Data; set => _sessionItemsRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _sessionItemsRoot_Element = new();
public global::FrooxEngine.UIX.RawGraphic _thumbnailGraphic { get => _thumbnailGraphic_Element.Data; set => _thumbnailGraphic_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RawGraphic>, global::FrooxEngine.UIX.RawGraphic> _thumbnailGraphic_Element = new();
public global::FrooxEngine.StaticTexture2D _thumbnailTexture { get => _thumbnailTexture_Element.Data; set => _thumbnailTexture_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.StaticTexture2D>, global::FrooxEngine.StaticTexture2D> _thumbnailTexture_Element = new();
public global::FrooxEngine.Slot _detailImageRoot { get => _detailImageRoot_Element.Data; set => _detailImageRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _detailImageRoot_Element = new();
public global::FrooxEngine.Slot _compactRoot { get => _compactRoot_Element.Data; set => _compactRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _compactRoot_Element = new();
public global::FrooxEngine.Slot _compactHeaderRoot { get => _compactHeaderRoot_Element.Data; set => _compactHeaderRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _compactHeaderRoot_Element = new();
public global::FrooxEngine.Slot _detailHeaderRoot { get => _detailHeaderRoot_Element.Data; set => _detailHeaderRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _detailHeaderRoot_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _compactMaskEnabled { get => _compactMaskEnabled_Element.Data; set => _compactMaskEnabled_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _compactMaskEnabled_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _compactMaskRootEnabled { get => _compactMaskRootEnabled_Element.Data; set => _compactMaskRootEnabled_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _compactMaskRootEnabled_Element = new();
public global::FrooxEngine.UIX.Button _openButton { get => _openButton_Element.Data; set => _openButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _openButton_Element = new();
public global::FrooxEngine.UIX.ScrollRect _scrollRect { get => _scrollRect_Element.Data; set => _scrollRect_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.ScrollRect>, global::FrooxEngine.UIX.ScrollRect> _scrollRect_Element = new();
public global::FrooxEngine.UIX.Button _expandButton { get => _expandButton_Element.Data; set => _expandButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _expandButton_Element = new();
public global::FrooxEngine.UIX.Image _expandIcon { get => _expandIcon_Element.Data; set => _expandIcon_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Image>, global::FrooxEngine.UIX.Image> _expandIcon_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite> _expandSprite { get => _expandSprite_Element.Data; set => _expandSprite_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Sprite>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite>> _expandSprite_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite> _compactSprite { get => _compactSprite_Element.Data; set => _compactSprite_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Sprite>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite>> _compactSprite_Element = new();
public global::FrooxEngine.UIX.Text _description { get => _description_Element.Data; set => _description_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _description_Element = new();
public global::FrooxEngine.Slot _leftDetailsRoot { get => _leftDetailsRoot_Element.Data; set => _leftDetailsRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _leftDetailsRoot_Element = new();
public global::FrooxEngine.Slot _rightDetailsRoot { get => _rightDetailsRoot_Element.Data; set => _rightDetailsRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _rightDetailsRoot_Element = new();
public global::FrooxEngine.UIX.Text _detailsText { get => _detailsText_Element.Data; set => _detailsText_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _detailsText_Element = new();
public global::FrooxEngine.UIX.Button _cycleLeftButton { get => _cycleLeftButton_Element.Data; set => _cycleLeftButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _cycleLeftButton_Element = new();
public global::FrooxEngine.UIX.Button _cycleRightButton { get => _cycleRightButton_Element.Data; set => _cycleRightButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _cycleRightButton_Element = new();
public global::FrooxEngine.SyncRef<global::FrooxEngine.Slot> _compactParent { get => _compactParent_Element.Data; set => _compactParent_Element.Data = value; }
public Field<global::FrooxEngine.RefDrive<global::FrooxEngine.Slot>, global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>> _compactParent_Element = new();
public global::FrooxEngine.SyncRef<global::FrooxEngine.Slot> _compactHeaderParent { get => _compactHeaderParent_Element.Data; set => _compactHeaderParent_Element.Data = value; }
public Field<global::FrooxEngine.RefDrive<global::FrooxEngine.Slot>, global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>> _compactHeaderParent_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _sidebarActive { get => _sidebarActive_Element.Data; set => _sidebarActive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _sidebarActive_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _sidebarAnchorMin { get => _sidebarAnchorMin_Element.Data; set => _sidebarAnchorMin_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _sidebarAnchorMin_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _sidebarAnchorMax { get => _sidebarAnchorMax_Element.Data; set => _sidebarAnchorMax_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _sidebarAnchorMax_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _contentAnchorMin { get => _contentAnchorMin_Element.Data; set => _contentAnchorMin_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _contentAnchorMin_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _contentAnchorMax { get => _contentAnchorMax_Element.Data; set => _contentAnchorMax_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _contentAnchorMax_Element = new();
public global::FrooxEngine.IField<global::System.Single> _rectTransformLerp { get => _rectTransformLerp_Element.Data; set => _rectTransformLerp_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _rectTransformLerp_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _modalAnchorMin { get => _modalAnchorMin_Element.Data; set => _modalAnchorMin_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _modalAnchorMin_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _modalAnchorMax { get => _modalAnchorMax_Element.Data; set => _modalAnchorMax_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _modalAnchorMax_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _compactButtonsActive { get => _compactButtonsActive_Element.Data; set => _compactButtonsActive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _compactButtonsActive_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _compactButtonsAnchorMin { get => _compactButtonsAnchorMin_Element.Data; set => _compactButtonsAnchorMin_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _compactButtonsAnchorMin_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _compactButtonsAnchorMax { get => _compactButtonsAnchorMax_Element.Data; set => _compactButtonsAnchorMax_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _compactButtonsAnchorMax_Element = new();
public global::FrooxEngine.IField<UnityEngine.Rect> _compactDetailRect { get => _compactDetailRect_Element.Data; set => _compactDetailRect_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Rect>, global::FrooxEngine.IField<UnityEngine.Rect>> _compactDetailRect_Element = new();
public global::FrooxEngine.IField<UnityEngine.Rect> _compactDetailButtonRect { get => _compactDetailButtonRect_Element.Data; set => _compactDetailButtonRect_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Rect>, global::FrooxEngine.IField<UnityEngine.Rect>> _compactDetailButtonRect_Element = new();
public global::FrooxEngine.UIX.Text _compactDetailText { get => _compactDetailText_Element.Data; set => _compactDetailText_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _compactDetailText_Element = new();
public global::FrooxEngine.UIX.Button _compactDetailExpandButton { get => _compactDetailExpandButton_Element.Data; set => _compactDetailExpandButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _compactDetailExpandButton_Element = new();
public global::FrooxEngine.Slot _newSessionItemRoot { get => _newSessionItemRoot_Element.Data; set => _newSessionItemRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _newSessionItemRoot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Expanded", Expanded_Element.Data.ToResoniteLinkField());
members.Add("CompactDetailExpanded", CompactDetailExpanded_Element.Data.ToResoniteLinkField());
members.Add("CompactDetailCategory", CompactDetailCategory_Element.Data.ToResoniteLinkField());
members.Add("ModalCompactSize", ModalCompactSize_Element.Data.ToResoniteLinkField());
members.Add("ModalExpandedSize", ModalExpandedSize_Element.Data.ToResoniteLinkField());
members.Add("_hostText", _hostText_Element.Data.ToResoniteReference(context));
members.Add("_sessionItemsRoot", _sessionItemsRoot_Element.Data.ToResoniteReference(context));
members.Add("_thumbnailGraphic", _thumbnailGraphic_Element.Data.ToResoniteReference(context));
members.Add("_thumbnailTexture", _thumbnailTexture_Element.Data.ToResoniteReference(context));
members.Add("_detailImageRoot", _detailImageRoot_Element.Data.ToResoniteReference(context));
members.Add("_compactRoot", _compactRoot_Element.Data.ToResoniteReference(context));
members.Add("_compactHeaderRoot", _compactHeaderRoot_Element.Data.ToResoniteReference(context));
members.Add("_detailHeaderRoot", _detailHeaderRoot_Element.Data.ToResoniteReference(context));
members.Add("_compactMaskEnabled", _compactMaskEnabled_Element.Data.ToResoniteReference(context));
members.Add("_compactMaskRootEnabled", _compactMaskRootEnabled_Element.Data.ToResoniteReference(context));
members.Add("_openButton", _openButton_Element.Data.ToResoniteReference(context));
members.Add("_scrollRect", _scrollRect_Element.Data.ToResoniteReference(context));
members.Add("_expandButton", _expandButton_Element.Data.ToResoniteReference(context));
members.Add("_expandIcon", _expandIcon_Element.Data.ToResoniteReference(context));
members.Add("_expandSprite", _expandSprite_Element.Data.ToResoniteReference(context));
members.Add("_compactSprite", _compactSprite_Element.Data.ToResoniteReference(context));
members.Add("_description", _description_Element.Data.ToResoniteReference(context));
members.Add("_leftDetailsRoot", _leftDetailsRoot_Element.Data.ToResoniteReference(context));
members.Add("_rightDetailsRoot", _rightDetailsRoot_Element.Data.ToResoniteReference(context));
members.Add("_detailsText", _detailsText_Element.Data.ToResoniteReference(context));
members.Add("_cycleLeftButton", _cycleLeftButton_Element.Data.ToResoniteReference(context));
members.Add("_cycleRightButton", _cycleRightButton_Element.Data.ToResoniteReference(context));
members.Add("_compactParent", _compactParent_Element.Data.ToResoniteReference(context));
members.Add("_compactHeaderParent", _compactHeaderParent_Element.Data.ToResoniteReference(context));
members.Add("_sidebarActive", _sidebarActive_Element.Data.ToResoniteReference(context));
members.Add("_sidebarAnchorMin", _sidebarAnchorMin_Element.Data.ToResoniteReference(context));
members.Add("_sidebarAnchorMax", _sidebarAnchorMax_Element.Data.ToResoniteReference(context));
members.Add("_contentAnchorMin", _contentAnchorMin_Element.Data.ToResoniteReference(context));
members.Add("_contentAnchorMax", _contentAnchorMax_Element.Data.ToResoniteReference(context));
members.Add("_rectTransformLerp", _rectTransformLerp_Element.Data.ToResoniteReference(context));
members.Add("_modalAnchorMin", _modalAnchorMin_Element.Data.ToResoniteReference(context));
members.Add("_modalAnchorMax", _modalAnchorMax_Element.Data.ToResoniteReference(context));
members.Add("_compactButtonsActive", _compactButtonsActive_Element.Data.ToResoniteReference(context));
members.Add("_compactButtonsAnchorMin", _compactButtonsAnchorMin_Element.Data.ToResoniteReference(context));
members.Add("_compactButtonsAnchorMax", _compactButtonsAnchorMax_Element.Data.ToResoniteReference(context));
members.Add("_compactDetailRect", _compactDetailRect_Element.Data.ToResoniteReference(context));
members.Add("_compactDetailButtonRect", _compactDetailButtonRect_Element.Data.ToResoniteReference(context));
members.Add("_compactDetailText", _compactDetailText_Element.Data.ToResoniteReference(context));
members.Add("_compactDetailExpandButton", _compactDetailExpandButton_Element.Data.ToResoniteReference(context));
members.Add("_newSessionItemRoot", _newSessionItemRoot_Element.Data.ToResoniteReference(context));
}

}
}
