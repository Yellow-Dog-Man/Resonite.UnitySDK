
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RadiantDashButton
// Generated on: pátek 13. února 2026 5:52:30
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Dash", new ResoniteLink.Reference() { });
members.Add("Screen", new ResoniteLink.Reference() { });
members.Add("_switchingEnabled", new ResoniteLink.Reference() { });
members.Add("_screenEnabled", new ResoniteLink.Reference() { });
members.Add("_currentScreen", new ResoniteLink.Reference() { });
members.Add("_button", new ResoniteLink.Reference() { });
members.Add("_text", new ResoniteLink.Reference() { });
members.Add("_textBg", new ResoniteLink.Reference() { });
members.Add("_icon", new ResoniteLink.Reference() { });
members.Add("_layout", new ResoniteLink.Reference() { });
members.Add("_rootRect", new ResoniteLink.Reference() { });
members.Add("_iconRect", new ResoniteLink.Reference() { });
}

}
}
