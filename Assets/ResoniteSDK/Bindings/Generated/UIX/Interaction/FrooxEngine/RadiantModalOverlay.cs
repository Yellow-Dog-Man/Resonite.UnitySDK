
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RadiantModalOverlay
// Generated on: pátek 13. února 2026 5:52:28
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("BlurSpread", BlurSpread.ToResoniteLinkField());
members.Add("BackgroundColor", BackgroundColor.ToResoniteLinkField());
members.Add("ContentAnimationScaleOffset", ContentAnimationScaleOffset.ToResoniteLinkField());
members.Add("HeaderSize", HeaderSize.ToResoniteLinkField());
members.Add("Padding", Padding.ToResoniteLinkField());
members.Add("_title", new ResoniteLink.Reference() { });
members.Add("_blur", new ResoniteLink.Reference() { });
members.Add("_blurGraphic", new ResoniteLink.Reference() { });
members.Add("_blurSpread", new ResoniteLink.Reference() { });
members.Add("_backgroundColor", new ResoniteLink.Reference() { });
members.Add("_maskRect", new ResoniteLink.Reference() { });
members.Add("_headerOffsetMin", new ResoniteLink.Reference() { });
members.Add("_headerOffsetMax", new ResoniteLink.Reference() { });
members.Add("_contentOffsetMin", new ResoniteLink.Reference() { });
members.Add("_contentOffsetMax", new ResoniteLink.Reference() { });
members.Add("_titleOffsetMin", new ResoniteLink.Reference() { });
members.Add("_titleOffsetMax", new ResoniteLink.Reference() { });
members.Add("_closeOffsetMin", new ResoniteLink.Reference() { });
members.Add("_closeOffsetMax", new ResoniteLink.Reference() { });
}

}
}
