
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ContextMenu
// Generated on: čtvrtek 26. února 2026 15:08:58
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ContextMenu")]
public partial class ContextMenu : global::FrooxEngine.UserRootComponent

{
    public global::FrooxEngine.User Owner { get => Owner_Element.Data; set => Owner_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> Owner_Element = new();
public global::FrooxEngine.Slot Pointer { get => Pointer_Element.Data; set => Pointer_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Pointer_Element = new();
public global::System.Single Separation { get => Separation_Element.Data; set => Separation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Separation_Element = new();
public UnityEngine.Vector2 LabelSize { get => LabelSize_Element.Data; set => LabelSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> LabelSize_Element = new();
public global::System.Single RadiusRatio { get => RadiusRatio_Element.Data; set => RadiusRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RadiusRatio_Element = new();
public global::FrooxEngine.IWorldElement _currentSummoner { get => _currentSummoner_Element.Data; set => _currentSummoner_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef, global::FrooxEngine.IWorldElement> _currentSummoner_Element = new();
public global::FrooxEngine.UIX.Canvas _canvas { get => _canvas_Element.Data; set => _canvas_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Canvas>, global::FrooxEngine.UIX.Canvas> _canvas_Element = new();
public global::FrooxEngine.UIX.ArcLayout _arcLayout { get => _arcLayout_Element.Data; set => _arcLayout_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.ArcLayout>, global::FrooxEngine.UIX.ArcLayout> _arcLayout_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _canvasActive { get => _canvasActive_Element.Data; set => _canvasActive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _canvasActive_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _colliderEnabled { get => _colliderEnabled_Element.Data; set => _colliderEnabled_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _colliderEnabled_Element = new();
public global::FrooxEngine.UIX.Image _iconImage { get => _iconImage_Element.Data; set => _iconImage_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Image>, global::FrooxEngine.UIX.Image> _iconImage_Element = new();
public global::FrooxEngine.IField<global::System.Single> _separation { get => _separation_Element.Data; set => _separation_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _separation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _offsetMin { get => _offsetMin_Element.Data; set => _offsetMin_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _offsetMin_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _offsetMax { get => _offsetMax_Element.Data; set => _offsetMax_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _offsetMax_Element = new();
public global::FrooxEngine.UIX.OutlinedArc _innerCircle { get => _innerCircle_Element.Data; set => _innerCircle_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.OutlinedArc>, global::FrooxEngine.UIX.OutlinedArc> _innerCircle_Element = new();
public global::FrooxEngine.UIX.Button _innerCircleButton { get => _innerCircleButton_Element.Data; set => _innerCircleButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _innerCircleButton_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _innerCircleAnchorMin { get => _innerCircleAnchorMin_Element.Data; set => _innerCircleAnchorMin_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _innerCircleAnchorMin_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _innerCircleAnchorMax { get => _innerCircleAnchorMax_Element.Data; set => _innerCircleAnchorMax_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _innerCircleAnchorMax_Element = new();
public global::FrooxEngine.Slot _itemsRoot { get => _itemsRoot_Element.Data; set => _itemsRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _itemsRoot_Element = new();
public global::FrooxEngine.UI_CircleSegment _arcMaterial { get => _arcMaterial_Element.Data; set => _arcMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UI_CircleSegment>, global::FrooxEngine.UI_CircleSegment> _arcMaterial_Element = new();
public global::FrooxEngine.UI_TextUnlitMaterial _fontMaterial { get => _fontMaterial_Element.Data; set => _fontMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UI_TextUnlitMaterial>, global::FrooxEngine.UI_TextUnlitMaterial> _fontMaterial_Element = new();
public global::FrooxEngine.UI_UnlitMaterial _spriteMaterial { get => _spriteMaterial_Element.Data; set => _spriteMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UI_UnlitMaterial>, global::FrooxEngine.UI_UnlitMaterial> _spriteMaterial_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _arcOverlay { get => _arcOverlay_Element.Data; set => _arcOverlay_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _arcOverlay_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _fontOverlay { get => _fontOverlay_Element.Data; set => _fontOverlay_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _fontOverlay_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _spriteOverlay { get => _spriteOverlay_Element.Data; set => _spriteOverlay_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _spriteOverlay_Element = new();
public global::FrooxEngine.IField<global::FrooxEngine.ZTest> _arcZTest { get => _arcZTest_Element.Data; set => _arcZTest_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::FrooxEngine.ZTest>, global::FrooxEngine.IField<global::FrooxEngine.ZTest>> _arcZTest_Element = new();
public global::FrooxEngine.IField<global::FrooxEngine.ZTest> _fontZTest { get => _fontZTest_Element.Data; set => _fontZTest_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::FrooxEngine.ZTest>, global::FrooxEngine.IField<global::FrooxEngine.ZTest>> _fontZTest_Element = new();
public global::FrooxEngine.IField<global::FrooxEngine.ZTest> _spriteZTest { get => _spriteZTest_Element.Data; set => _spriteZTest_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::FrooxEngine.ZTest>, global::FrooxEngine.IField<global::FrooxEngine.ZTest>> _spriteZTest_Element = new();
public global::FrooxEngine.IField<global::FrooxEngine.ZWrite> _zwriteArc { get => _zwriteArc_Element.Data; set => _zwriteArc_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::FrooxEngine.ZWrite>, global::FrooxEngine.IField<global::FrooxEngine.ZWrite>> _zwriteArc_Element = new();
public global::FrooxEngine.IField<global::FrooxEngine.ZWrite> _zwriteText { get => _zwriteText_Element.Data; set => _zwriteText_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::FrooxEngine.ZWrite>, global::FrooxEngine.IField<global::FrooxEngine.ZWrite>> _zwriteText_Element = new();
public global::FrooxEngine.IField<global::System.Int32> _arcRenderQueue { get => _arcRenderQueue_Element.Data; set => _arcRenderQueue_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Int32>, global::FrooxEngine.IField<global::System.Int32>> _arcRenderQueue_Element = new();
public global::FrooxEngine.IField<global::System.Int32> _fontRenderQueue { get => _fontRenderQueue_Element.Data; set => _fontRenderQueue_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Int32>, global::FrooxEngine.IField<global::System.Int32>> _fontRenderQueue_Element = new();
public global::FrooxEngine.IField<global::System.Int32> _spriteRenderQueue { get => _spriteRenderQueue_Element.Data; set => _spriteRenderQueue_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Int32>, global::FrooxEngine.IField<global::System.Int32>> _spriteRenderQueue_Element = new();
public global::FrooxEngine.IField<global::System.Int32> _canvasOffset { get => _canvasOffset_Element.Data; set => _canvasOffset_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Int32>, global::FrooxEngine.IField<global::System.Int32>> _canvasOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _fillFade { get => _fillFade_Element.Data; set => _fillFade_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _fillFade_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _outlineFade { get => _outlineFade_Element.Data; set => _outlineFade_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _outlineFade_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _textFade { get => _textFade_Element.Data; set => _textFade_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _textFade_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _iconFade { get => _iconFade_Element.Data; set => _iconFade_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _iconFade_Element = new();
public global::System.Single _lerp { get => _lerp_Element.Data; set => _lerp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _lerp_Element = new();
public global::FrooxEngine.ContextMenu.State _state { get => _state_Element.Data; set => _state_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ContextMenu.State>, global::FrooxEngine.ContextMenu.State> _state_Element = new();
public global::System.Boolean _flickModeActive { get => _flickModeActive_Element.Data; set => _flickModeActive_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _flickModeActive_Element = new();
public global::System.Boolean _flickEnabled { get => _flickEnabled_Element.Data; set => _flickEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _flickEnabled_Element = new();
public global::System.Boolean _hidden { get => _hidden_Element.Data; set => _hidden_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _hidden_Element = new();
public global::FrooxEngine.ContextMenuItem _selectedItem { get => _selectedItem_Element.Data; set => _selectedItem_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ContextMenuItem>, global::FrooxEngine.ContextMenuItem> _selectedItem_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Owner", Owner_Element.ToLinkReference(context));
members.Add("Pointer", Pointer_Element.ToLinkReference(context));
members.Add("Separation", Separation_Element.ToLinkField(context));
members.Add("LabelSize", LabelSize_Element.ToLinkField(context));
members.Add("RadiusRatio", RadiusRatio_Element.ToLinkField(context));
members.Add("_currentSummoner", _currentSummoner_Element.ToLinkReference(context));
members.Add("_canvas", _canvas_Element.ToLinkReference(context));
members.Add("_arcLayout", _arcLayout_Element.ToLinkReference(context));
members.Add("_canvasActive", _canvasActive_Element.ToLinkReference(context));
members.Add("_colliderEnabled", _colliderEnabled_Element.ToLinkReference(context));
members.Add("_iconImage", _iconImage_Element.ToLinkReference(context));
members.Add("_separation", _separation_Element.ToLinkReference(context));
members.Add("_offsetMin", _offsetMin_Element.ToLinkReference(context));
members.Add("_offsetMax", _offsetMax_Element.ToLinkReference(context));
members.Add("_innerCircle", _innerCircle_Element.ToLinkReference(context));
members.Add("_innerCircleButton", _innerCircleButton_Element.ToLinkReference(context));
members.Add("_innerCircleAnchorMin", _innerCircleAnchorMin_Element.ToLinkReference(context));
members.Add("_innerCircleAnchorMax", _innerCircleAnchorMax_Element.ToLinkReference(context));
members.Add("_itemsRoot", _itemsRoot_Element.ToLinkReference(context));
members.Add("_arcMaterial", _arcMaterial_Element.ToLinkReference(context));
members.Add("_fontMaterial", _fontMaterial_Element.ToLinkReference(context));
members.Add("_spriteMaterial", _spriteMaterial_Element.ToLinkReference(context));
members.Add("_arcOverlay", _arcOverlay_Element.ToLinkReference(context));
members.Add("_fontOverlay", _fontOverlay_Element.ToLinkReference(context));
members.Add("_spriteOverlay", _spriteOverlay_Element.ToLinkReference(context));
members.Add("_arcZTest", _arcZTest_Element.ToLinkReference(context));
members.Add("_fontZTest", _fontZTest_Element.ToLinkReference(context));
members.Add("_spriteZTest", _spriteZTest_Element.ToLinkReference(context));
members.Add("_zwriteArc", _zwriteArc_Element.ToLinkReference(context));
members.Add("_zwriteText", _zwriteText_Element.ToLinkReference(context));
members.Add("_arcRenderQueue", _arcRenderQueue_Element.ToLinkReference(context));
members.Add("_fontRenderQueue", _fontRenderQueue_Element.ToLinkReference(context));
members.Add("_spriteRenderQueue", _spriteRenderQueue_Element.ToLinkReference(context));
members.Add("_canvasOffset", _canvasOffset_Element.ToLinkReference(context));
members.Add("_fillFade", _fillFade_Element.ToLinkReference(context));
members.Add("_outlineFade", _outlineFade_Element.ToLinkReference(context));
members.Add("_textFade", _textFade_Element.ToLinkReference(context));
members.Add("_iconFade", _iconFade_Element.ToLinkReference(context));
members.Add("_lerp", _lerp_Element.ToLinkField(context));
members.Add("_state", _state_Element.ToLinkField(context));
members.Add("_flickModeActive", _flickModeActive_Element.ToLinkField(context));
members.Add("_flickEnabled", _flickEnabled_Element.ToLinkField(context));
members.Add("_hidden", _hidden_Element.ToLinkField(context));
members.Add("_selectedItem", _selectedItem_Element.ToLinkReference(context));
}

}
}
