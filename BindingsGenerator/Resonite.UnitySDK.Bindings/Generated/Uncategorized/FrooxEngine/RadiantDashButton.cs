
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RadiantDashButton
// Generated on: čtvrtek 26. února 2026 10:04:44
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RadiantDashButton")]
public partial class RadiantDashButton : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::FrooxEngine.RadiantDash Dash { get => Dash_Element.Data; set => Dash_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.RadiantDash>, global::FrooxEngine.RadiantDash> Dash_Element = new();
public global::FrooxEngine.RadiantDashScreen Screen { get => Screen_Element.Data; set => Screen_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.RadiantDashScreen>, global::FrooxEngine.RadiantDashScreen> Screen_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _switchingEnabled { get => _switchingEnabled_Element.Data; set => _switchingEnabled_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> _switchingEnabled_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _screenEnabled { get => _screenEnabled_Element.Data; set => _screenEnabled_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> _screenEnabled_Element = new();
public global::FrooxEngine.SyncRef<global::FrooxEngine.RadiantDashScreen> _currentScreen { get => _currentScreen_Element.Data; set => _currentScreen_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.SyncRef<global::FrooxEngine.RadiantDashScreen>>, global::FrooxEngine.SyncRef<global::FrooxEngine.RadiantDashScreen>> _currentScreen_Element = new();
public global::FrooxEngine.UIX.Button _button { get => _button_Element.Data; set => _button_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _button_Element = new();
public global::FrooxEngine.UIX.Text _text { get => _text_Element.Data; set => _text_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _text_Element = new();
public global::FrooxEngine.UIX.Image _textBg { get => _textBg_Element.Data; set => _textBg_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Image>, global::FrooxEngine.UIX.Image> _textBg_Element = new();
public global::FrooxEngine.UIX.Image _icon { get => _icon_Element.Data; set => _icon_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Image>, global::FrooxEngine.UIX.Image> _icon_Element = new();
public global::FrooxEngine.UIX.LayoutElement _layout { get => _layout_Element.Data; set => _layout_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.LayoutElement>, global::FrooxEngine.UIX.LayoutElement> _layout_Element = new();
public global::FrooxEngine.UIX.RectTransform _rootRect { get => _rootRect_Element.Data; set => _rootRect_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RectTransform>, global::FrooxEngine.UIX.RectTransform> _rootRect_Element = new();
public global::FrooxEngine.UIX.RectTransform _iconRect { get => _iconRect_Element.Data; set => _iconRect_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RectTransform>, global::FrooxEngine.UIX.RectTransform> _iconRect_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Dash", Dash_Element.Data.ToResoniteReference(context));
members.Add("Screen", Screen_Element.Data.ToResoniteReference(context));
members.Add("_switchingEnabled", _switchingEnabled_Element.Data.ToResoniteReference(context));
members.Add("_screenEnabled", _screenEnabled_Element.Data.ToResoniteReference(context));
members.Add("_currentScreen", _currentScreen_Element.Data.ToResoniteReference(context));
members.Add("_button", _button_Element.Data.ToResoniteReference(context));
members.Add("_text", _text_Element.Data.ToResoniteReference(context));
members.Add("_textBg", _textBg_Element.Data.ToResoniteReference(context));
members.Add("_icon", _icon_Element.Data.ToResoniteReference(context));
members.Add("_layout", _layout_Element.Data.ToResoniteReference(context));
members.Add("_rootRect", _rootRect_Element.Data.ToResoniteReference(context));
members.Add("_iconRect", _iconRect_Element.Data.ToResoniteReference(context));
}

}
}
