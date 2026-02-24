
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RadiantDashScreen
// Generated on: úterý 24. února 2026 18:20:20
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RadiantDashScreen")]
public partial class RadiantDashScreen : global::FrooxEngine.Component

{
    public System.Uri Icon;
public global::System.Nullable<UnityEngine.ColorX> ActiveColor;
public global::System.String Label;
public global::System.Boolean ScreenEnabled;
public UnityEngine.Vector2 BaseResolution;
public global::FrooxEngine.Slot _screenRoot;
public global::FrooxEngine.UIX.Canvas _screenCanvas;
public global::FrooxEngine.ModalOverlayManager _modalOverlayManager;
public global::FrooxEngine.RadiantDashButton _button;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> _iconTexture;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Icon", Icon.ToResoniteLinkField());
members.Add("ActiveColor", ActiveColor.ToResoniteLinkField());
members.Add("Label", Label.ToResoniteLinkField());
members.Add("ScreenEnabled", ScreenEnabled.ToResoniteLinkField());
members.Add("BaseResolution", BaseResolution.ToResoniteLinkField());
members.Add("_screenRoot", _screenRoot.ToResoniteReference(context));
members.Add("_screenCanvas", _screenCanvas.ToResoniteReference(context));
members.Add("_modalOverlayManager", _modalOverlayManager.ToResoniteReference(context));
members.Add("_button", _button.ToResoniteReference(context));
members.Add("_iconTexture", _iconTexture.ToResoniteReference(context));
}

}
}
