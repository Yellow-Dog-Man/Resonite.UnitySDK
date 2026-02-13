
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ContextMenu
// Generated on: pátek 13. února 2026 23:22:57
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ContextMenu")]
public partial class ContextMenu : global::FrooxEngine.UserRootComponent

{
    public global::FrooxEngine.User Owner;
public global::FrooxEngine.Slot Pointer;
public global::System.Single Separation;
public UnityEngine.Vector2 LabelSize;
public global::System.Single RadiusRatio;
public global::FrooxEngine.IWorldElement _currentSummoner;
public global::FrooxEngine.UIX.Canvas _canvas;
public global::FrooxEngine.UIX.ArcLayout _arcLayout;
public global::FrooxEngine.IField<global::System.Boolean> _canvasActive;
public global::FrooxEngine.IField<global::System.Boolean> _colliderEnabled;
public global::FrooxEngine.UIX.Image _iconImage;
public global::FrooxEngine.IField<global::System.Single> _separation;
public global::FrooxEngine.IField<UnityEngine.Vector2> _offsetMin;
public global::FrooxEngine.IField<UnityEngine.Vector2> _offsetMax;
public global::FrooxEngine.UIX.OutlinedArc _innerCircle;
public global::FrooxEngine.UIX.Button _innerCircleButton;
public global::FrooxEngine.IField<UnityEngine.Vector2> _innerCircleAnchorMin;
public global::FrooxEngine.IField<UnityEngine.Vector2> _innerCircleAnchorMax;
public global::FrooxEngine.Slot _itemsRoot;
public global::FrooxEngine.UI_CircleSegment _arcMaterial;
public global::FrooxEngine.UI_TextUnlitMaterial _fontMaterial;
public global::FrooxEngine.UI_UnlitMaterial _spriteMaterial;
public global::FrooxEngine.IField<global::System.Boolean> _arcOverlay;
public global::FrooxEngine.IField<global::System.Boolean> _fontOverlay;
public global::FrooxEngine.IField<global::System.Boolean> _spriteOverlay;
public global::FrooxEngine.IField<global::FrooxEngine.ZTest> _arcZTest;
public global::FrooxEngine.IField<global::FrooxEngine.ZTest> _fontZTest;
public global::FrooxEngine.IField<global::FrooxEngine.ZTest> _spriteZTest;
public global::FrooxEngine.IField<global::FrooxEngine.ZWrite> _zwriteArc;
public global::FrooxEngine.IField<global::FrooxEngine.ZWrite> _zwriteText;
public global::FrooxEngine.IField<global::System.Int32> _arcRenderQueue;
public global::FrooxEngine.IField<global::System.Int32> _fontRenderQueue;
public global::FrooxEngine.IField<global::System.Int32> _spriteRenderQueue;
public global::FrooxEngine.IField<global::System.Int32> _canvasOffset;
public global::FrooxEngine.IField<UnityEngine.ColorX> _fillFade;
public global::FrooxEngine.IField<UnityEngine.ColorX> _outlineFade;
public global::FrooxEngine.IField<UnityEngine.ColorX> _textFade;
public global::FrooxEngine.IField<UnityEngine.ColorX> _iconFade;
public global::System.Single _lerp;
public global::FrooxEngine.ContextMenu.State _state;
public global::System.Boolean _flickModeActive;
public global::System.Boolean _flickEnabled;
public global::System.Boolean _hidden;
public global::FrooxEngine.ContextMenuItem _selectedItem;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Owner", new ResoniteLink.Reference() { });
members.Add("Pointer", new ResoniteLink.Reference() { });
members.Add("Separation", Separation.ToResoniteLinkField());
members.Add("LabelSize", LabelSize.ToResoniteLinkField());
members.Add("RadiusRatio", RadiusRatio.ToResoniteLinkField());
members.Add("_currentSummoner", new ResoniteLink.Reference() { });
members.Add("_canvas", new ResoniteLink.Reference() { });
members.Add("_arcLayout", new ResoniteLink.Reference() { });
members.Add("_canvasActive", new ResoniteLink.Reference() { });
members.Add("_colliderEnabled", new ResoniteLink.Reference() { });
members.Add("_iconImage", new ResoniteLink.Reference() { });
members.Add("_separation", new ResoniteLink.Reference() { });
members.Add("_offsetMin", new ResoniteLink.Reference() { });
members.Add("_offsetMax", new ResoniteLink.Reference() { });
members.Add("_innerCircle", new ResoniteLink.Reference() { });
members.Add("_innerCircleButton", new ResoniteLink.Reference() { });
members.Add("_innerCircleAnchorMin", new ResoniteLink.Reference() { });
members.Add("_innerCircleAnchorMax", new ResoniteLink.Reference() { });
members.Add("_itemsRoot", new ResoniteLink.Reference() { });
members.Add("_arcMaterial", new ResoniteLink.Reference() { });
members.Add("_fontMaterial", new ResoniteLink.Reference() { });
members.Add("_spriteMaterial", new ResoniteLink.Reference() { });
members.Add("_arcOverlay", new ResoniteLink.Reference() { });
members.Add("_fontOverlay", new ResoniteLink.Reference() { });
members.Add("_spriteOverlay", new ResoniteLink.Reference() { });
members.Add("_arcZTest", new ResoniteLink.Reference() { });
members.Add("_fontZTest", new ResoniteLink.Reference() { });
members.Add("_spriteZTest", new ResoniteLink.Reference() { });
members.Add("_zwriteArc", new ResoniteLink.Reference() { });
members.Add("_zwriteText", new ResoniteLink.Reference() { });
members.Add("_arcRenderQueue", new ResoniteLink.Reference() { });
members.Add("_fontRenderQueue", new ResoniteLink.Reference() { });
members.Add("_spriteRenderQueue", new ResoniteLink.Reference() { });
members.Add("_canvasOffset", new ResoniteLink.Reference() { });
members.Add("_fillFade", new ResoniteLink.Reference() { });
members.Add("_outlineFade", new ResoniteLink.Reference() { });
members.Add("_textFade", new ResoniteLink.Reference() { });
members.Add("_iconFade", new ResoniteLink.Reference() { });
members.Add("_lerp", _lerp.ToResoniteLinkField());
members.Add("_state", _state.ToResoniteLinkField());
members.Add("_flickModeActive", _flickModeActive.ToResoniteLinkField());
members.Add("_flickEnabled", _flickEnabled.ToResoniteLinkField());
members.Add("_hidden", _hidden.ToResoniteLinkField());
members.Add("_selectedItem", new ResoniteLink.Reference() { });
}

}
}
