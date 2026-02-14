
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RadiantModalOverlay
// Generated on: sobota 14. února 2026 8:58:41
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RadiantModalOverlay")]
public partial class RadiantModalOverlay : global::FrooxEngine.UIX.ModalOverlay

{
    public global::System.Single BlurSpread;
public UnityEngine.ColorX BackgroundColor;
public global::System.Single ContentAnimationScaleOffset;
public global::System.Single HeaderSize;
public global::System.Single Padding;
public global::FrooxEngine.UIX.Text _title;
public global::FrooxEngine.BlurMaterial _blur;
public global::FrooxEngine.UIX.RawGraphic _blurGraphic;
public global::FrooxEngine.IField<UnityEngine.Vector2> _blurSpread;
public global::FrooxEngine.IField<UnityEngine.ColorX> _backgroundColor;
public global::FrooxEngine.IField<UnityEngine.Rect> _maskRect;
public global::FrooxEngine.IField<UnityEngine.Vector2> _headerOffsetMin;
public global::FrooxEngine.IField<UnityEngine.Vector2> _headerOffsetMax;
public global::FrooxEngine.IField<UnityEngine.Vector2> _contentOffsetMin;
public global::FrooxEngine.IField<UnityEngine.Vector2> _contentOffsetMax;
public global::FrooxEngine.IField<UnityEngine.Vector2> _titleOffsetMin;
public global::FrooxEngine.IField<UnityEngine.Vector2> _titleOffsetMax;
public global::FrooxEngine.IField<UnityEngine.Vector2> _closeOffsetMin;
public global::FrooxEngine.IField<UnityEngine.Vector2> _closeOffsetMax;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BlurSpread", BlurSpread.ToResoniteLinkField());
members.Add("BackgroundColor", BackgroundColor.ToResoniteLinkField());
members.Add("ContentAnimationScaleOffset", ContentAnimationScaleOffset.ToResoniteLinkField());
members.Add("HeaderSize", HeaderSize.ToResoniteLinkField());
members.Add("Padding", Padding.ToResoniteLinkField());
members.Add("_title", _title.ToResoniteReference(context));
members.Add("_blur", _blur.ToResoniteReference(context));
members.Add("_blurGraphic", _blurGraphic.ToResoniteReference(context));
members.Add("_blurSpread", _blurSpread.ToResoniteReference(context));
members.Add("_backgroundColor", _backgroundColor.ToResoniteReference(context));
members.Add("_maskRect", _maskRect.ToResoniteReference(context));
members.Add("_headerOffsetMin", _headerOffsetMin.ToResoniteReference(context));
members.Add("_headerOffsetMax", _headerOffsetMax.ToResoniteReference(context));
members.Add("_contentOffsetMin", _contentOffsetMin.ToResoniteReference(context));
members.Add("_contentOffsetMax", _contentOffsetMax.ToResoniteReference(context));
members.Add("_titleOffsetMin", _titleOffsetMin.ToResoniteReference(context));
members.Add("_titleOffsetMax", _titleOffsetMax.ToResoniteReference(context));
members.Add("_closeOffsetMin", _closeOffsetMin.ToResoniteReference(context));
members.Add("_closeOffsetMax", _closeOffsetMax.ToResoniteReference(context));
}

}
}
