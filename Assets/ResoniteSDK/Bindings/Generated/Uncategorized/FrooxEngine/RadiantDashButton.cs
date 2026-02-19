
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RadiantDashButton
// Generated on: čtvrtek 19. února 2026 8:00:27
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RadiantDashButton")]
public partial class RadiantDashButton : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::FrooxEngine.RadiantDash Dash;
public global::FrooxEngine.RadiantDashScreen Screen;
public global::FrooxEngine.IField<global::System.Boolean> _switchingEnabled;
public global::FrooxEngine.IField<global::System.Boolean> _screenEnabled;
public global::FrooxEngine.SyncRef<global::FrooxEngine.RadiantDashScreen> _currentScreen;
public global::FrooxEngine.UIX.Button _button;
public global::FrooxEngine.UIX.Text _text;
public global::FrooxEngine.UIX.Image _textBg;
public global::FrooxEngine.UIX.Image _icon;
public global::FrooxEngine.UIX.LayoutElement _layout;
public global::FrooxEngine.UIX.RectTransform _rootRect;
public global::FrooxEngine.UIX.RectTransform _iconRect;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Dash", Dash.ToResoniteReference(context));
members.Add("Screen", Screen.ToResoniteReference(context));
members.Add("_switchingEnabled", _switchingEnabled.ToResoniteReference(context));
members.Add("_screenEnabled", _screenEnabled.ToResoniteReference(context));
members.Add("_currentScreen", _currentScreen.ToResoniteReference(context));
members.Add("_button", _button.ToResoniteReference(context));
members.Add("_text", _text.ToResoniteReference(context));
members.Add("_textBg", _textBg.ToResoniteReference(context));
members.Add("_icon", _icon.ToResoniteReference(context));
members.Add("_layout", _layout.ToResoniteReference(context));
members.Add("_rootRect", _rootRect.ToResoniteReference(context));
members.Add("_iconRect", _iconRect.ToResoniteReference(context));
}

}
}
