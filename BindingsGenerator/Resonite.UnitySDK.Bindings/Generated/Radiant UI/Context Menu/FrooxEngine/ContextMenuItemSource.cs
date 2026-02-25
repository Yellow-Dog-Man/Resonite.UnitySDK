
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ContextMenuItemSource
// Generated on: středa 25. února 2026 16:14:14
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ContextMenuItemSource")]
public partial class ContextMenuItemSource : global::FrooxEngine.Component, global::FrooxEngine.IButton, global::FrooxEngine.IButtonPressReceiver, global::FrooxEngine.IButtonHoverReceiver

{
    public global::System.String Label;
public UnityEngine.ColorX Color;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite> Sprite;
public global::System.Boolean ButtonEnabled;
public global::System.Boolean AllowDrag;
public global::System.Boolean CloseMenuOnPress;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Label", Label.ToResoniteLinkField());
members.Add("Color", Color.ToResoniteLinkField());
members.Add("Sprite", Sprite.ToResoniteReference(context));
members.Add("ButtonEnabled", ButtonEnabled.ToResoniteLinkField());
members.Add("AllowDrag", AllowDrag.ToResoniteLinkField());
members.Add("CloseMenuOnPress", CloseMenuOnPress.ToResoniteLinkField());
}

}
}
