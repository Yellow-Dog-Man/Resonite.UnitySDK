
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RadiantDashScreen
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RadiantDashScreen")]
public partial class RadiantDashScreen : global::FrooxEngine.Component

{
    public System.Uri Icon { get => Icon_Element.Data; set => Icon_Element.Data = value; }
public Field<global::FrooxEngine.Sync<System.Uri>, System.Uri> Icon_Element = new();
public global::System.Nullable<UnityEngine.ColorX> ActiveColor { get => ActiveColor_Element.Data; set => ActiveColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.ColorX>>, global::System.Nullable<UnityEngine.ColorX>> ActiveColor_Element = new();
public global::System.String Label { get => Label_Element.Data; set => Label_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Label_Element = new();
public global::System.Boolean ScreenEnabled { get => ScreenEnabled_Element.Data; set => ScreenEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ScreenEnabled_Element = new();
public UnityEngine.Vector2 BaseResolution { get => BaseResolution_Element.Data; set => BaseResolution_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> BaseResolution_Element = new();
public global::FrooxEngine.Slot _screenRoot { get => _screenRoot_Element.Data; set => _screenRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _screenRoot_Element = new();
public global::FrooxEngine.UIX.Canvas _screenCanvas { get => _screenCanvas_Element.Data; set => _screenCanvas_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Canvas>, global::FrooxEngine.UIX.Canvas> _screenCanvas_Element = new();
public global::FrooxEngine.ModalOverlayManager _modalOverlayManager { get => _modalOverlayManager_Element.Data; set => _modalOverlayManager_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ModalOverlayManager>, global::FrooxEngine.ModalOverlayManager> _modalOverlayManager_Element = new();
public global::FrooxEngine.RadiantDashButton _button { get => _button_Element.Data; set => _button_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.RadiantDashButton>, global::FrooxEngine.RadiantDashButton> _button_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> _iconTexture { get => _iconTexture_Element.Data; set => _iconTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D>> _iconTexture_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Icon", Icon_Element.Data.ToResoniteLinkField());
members.Add("ActiveColor", ActiveColor_Element.Data.ToResoniteLinkField());
members.Add("Label", Label_Element.Data.ToResoniteLinkField());
members.Add("ScreenEnabled", ScreenEnabled_Element.Data.ToResoniteLinkField());
members.Add("BaseResolution", BaseResolution_Element.Data.ToResoniteLinkField());
members.Add("_screenRoot", _screenRoot_Element.Data.ToResoniteReference(context));
members.Add("_screenCanvas", _screenCanvas_Element.Data.ToResoniteReference(context));
members.Add("_modalOverlayManager", _modalOverlayManager_Element.Data.ToResoniteReference(context));
members.Add("_button", _button_Element.Data.ToResoniteReference(context));
members.Add("_iconTexture", _iconTexture_Element.Data.ToResoniteReference(context));
}

}
}
