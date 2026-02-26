
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RadiantModalOverlay
// Generated on: čtvrtek 26. února 2026 12:28:08
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RadiantModalOverlay")]
public partial class RadiantModalOverlay : global::FrooxEngine.UIX.ModalOverlay

{
    public global::System.Single BlurSpread { get => BlurSpread_Element.Data; set => BlurSpread_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BlurSpread_Element = new();
public UnityEngine.ColorX BackgroundColor { get => BackgroundColor_Element.Data; set => BackgroundColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> BackgroundColor_Element = new();
public global::System.Single ContentAnimationScaleOffset { get => ContentAnimationScaleOffset_Element.Data; set => ContentAnimationScaleOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ContentAnimationScaleOffset_Element = new();
public global::System.Single HeaderSize { get => HeaderSize_Element.Data; set => HeaderSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeaderSize_Element = new();
public global::System.Single Padding { get => Padding_Element.Data; set => Padding_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Padding_Element = new();
public global::FrooxEngine.UIX.Text _title { get => _title_Element.Data; set => _title_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _title_Element = new();
public global::FrooxEngine.BlurMaterial _blur { get => _blur_Element.Data; set => _blur_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.BlurMaterial>, global::FrooxEngine.BlurMaterial> _blur_Element = new();
public global::FrooxEngine.UIX.RawGraphic _blurGraphic { get => _blurGraphic_Element.Data; set => _blurGraphic_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RawGraphic>, global::FrooxEngine.UIX.RawGraphic> _blurGraphic_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _blurSpread { get => _blurSpread_Element.Data; set => _blurSpread_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _blurSpread_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _backgroundColor { get => _backgroundColor_Element.Data; set => _backgroundColor_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _backgroundColor_Element = new();
public global::FrooxEngine.IField<UnityEngine.Rect> _maskRect { get => _maskRect_Element.Data; set => _maskRect_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Rect>, global::FrooxEngine.IField<UnityEngine.Rect>> _maskRect_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _headerOffsetMin { get => _headerOffsetMin_Element.Data; set => _headerOffsetMin_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _headerOffsetMin_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _headerOffsetMax { get => _headerOffsetMax_Element.Data; set => _headerOffsetMax_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _headerOffsetMax_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _contentOffsetMin { get => _contentOffsetMin_Element.Data; set => _contentOffsetMin_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _contentOffsetMin_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _contentOffsetMax { get => _contentOffsetMax_Element.Data; set => _contentOffsetMax_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _contentOffsetMax_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _titleOffsetMin { get => _titleOffsetMin_Element.Data; set => _titleOffsetMin_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _titleOffsetMin_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _titleOffsetMax { get => _titleOffsetMax_Element.Data; set => _titleOffsetMax_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _titleOffsetMax_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _closeOffsetMin { get => _closeOffsetMin_Element.Data; set => _closeOffsetMin_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _closeOffsetMin_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _closeOffsetMax { get => _closeOffsetMax_Element.Data; set => _closeOffsetMax_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _closeOffsetMax_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BlurSpread", BlurSpread_Element.ToLinkField(context));
members.Add("BackgroundColor", BackgroundColor_Element.ToLinkField(context));
members.Add("ContentAnimationScaleOffset", ContentAnimationScaleOffset_Element.ToLinkField(context));
members.Add("HeaderSize", HeaderSize_Element.ToLinkField(context));
members.Add("Padding", Padding_Element.ToLinkField(context));
members.Add("_title", _title_Element.ToLinkReference(context));
members.Add("_blur", _blur_Element.ToLinkReference(context));
members.Add("_blurGraphic", _blurGraphic_Element.ToLinkReference(context));
members.Add("_blurSpread", _blurSpread_Element.ToLinkReference(context));
members.Add("_backgroundColor", _backgroundColor_Element.ToLinkReference(context));
members.Add("_maskRect", _maskRect_Element.ToLinkReference(context));
members.Add("_headerOffsetMin", _headerOffsetMin_Element.ToLinkReference(context));
members.Add("_headerOffsetMax", _headerOffsetMax_Element.ToLinkReference(context));
members.Add("_contentOffsetMin", _contentOffsetMin_Element.ToLinkReference(context));
members.Add("_contentOffsetMax", _contentOffsetMax_Element.ToLinkReference(context));
members.Add("_titleOffsetMin", _titleOffsetMin_Element.ToLinkReference(context));
members.Add("_titleOffsetMax", _titleOffsetMax_Element.ToLinkReference(context));
members.Add("_closeOffsetMin", _closeOffsetMin_Element.ToLinkReference(context));
members.Add("_closeOffsetMax", _closeOffsetMax_Element.ToLinkReference(context));
}

}
}
