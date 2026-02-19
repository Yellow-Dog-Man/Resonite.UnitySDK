
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ContextMenu
// Generated on: čtvrtek 19. února 2026 8:00:13
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Owner", Owner.ToResoniteReference(context));
members.Add("Pointer", Pointer.ToResoniteReference(context));
members.Add("Separation", Separation.ToResoniteLinkField());
members.Add("LabelSize", LabelSize.ToResoniteLinkField());
members.Add("RadiusRatio", RadiusRatio.ToResoniteLinkField());
members.Add("_currentSummoner", _currentSummoner.ToResoniteReference(context));
members.Add("_canvas", _canvas.ToResoniteReference(context));
members.Add("_arcLayout", _arcLayout.ToResoniteReference(context));
members.Add("_canvasActive", _canvasActive.ToResoniteReference(context));
members.Add("_colliderEnabled", _colliderEnabled.ToResoniteReference(context));
members.Add("_iconImage", _iconImage.ToResoniteReference(context));
members.Add("_separation", _separation.ToResoniteReference(context));
members.Add("_offsetMin", _offsetMin.ToResoniteReference(context));
members.Add("_offsetMax", _offsetMax.ToResoniteReference(context));
members.Add("_innerCircle", _innerCircle.ToResoniteReference(context));
members.Add("_innerCircleButton", _innerCircleButton.ToResoniteReference(context));
members.Add("_innerCircleAnchorMin", _innerCircleAnchorMin.ToResoniteReference(context));
members.Add("_innerCircleAnchorMax", _innerCircleAnchorMax.ToResoniteReference(context));
members.Add("_itemsRoot", _itemsRoot.ToResoniteReference(context));
members.Add("_arcMaterial", _arcMaterial.ToResoniteReference(context));
members.Add("_fontMaterial", _fontMaterial.ToResoniteReference(context));
members.Add("_spriteMaterial", _spriteMaterial.ToResoniteReference(context));
members.Add("_arcOverlay", _arcOverlay.ToResoniteReference(context));
members.Add("_fontOverlay", _fontOverlay.ToResoniteReference(context));
members.Add("_spriteOverlay", _spriteOverlay.ToResoniteReference(context));
members.Add("_arcZTest", _arcZTest.ToResoniteReference(context));
members.Add("_fontZTest", _fontZTest.ToResoniteReference(context));
members.Add("_spriteZTest", _spriteZTest.ToResoniteReference(context));
members.Add("_zwriteArc", _zwriteArc.ToResoniteReference(context));
members.Add("_zwriteText", _zwriteText.ToResoniteReference(context));
members.Add("_arcRenderQueue", _arcRenderQueue.ToResoniteReference(context));
members.Add("_fontRenderQueue", _fontRenderQueue.ToResoniteReference(context));
members.Add("_spriteRenderQueue", _spriteRenderQueue.ToResoniteReference(context));
members.Add("_canvasOffset", _canvasOffset.ToResoniteReference(context));
members.Add("_fillFade", _fillFade.ToResoniteReference(context));
members.Add("_outlineFade", _outlineFade.ToResoniteReference(context));
members.Add("_textFade", _textFade.ToResoniteReference(context));
members.Add("_iconFade", _iconFade.ToResoniteReference(context));
members.Add("_lerp", _lerp.ToResoniteLinkField());
members.Add("_state", _state.ToResoniteLinkField());
members.Add("_flickModeActive", _flickModeActive.ToResoniteLinkField());
members.Add("_flickEnabled", _flickEnabled.ToResoniteLinkField());
members.Add("_hidden", _hidden.ToResoniteLinkField());
members.Add("_selectedItem", _selectedItem.ToResoniteReference(context));
}

}
}
