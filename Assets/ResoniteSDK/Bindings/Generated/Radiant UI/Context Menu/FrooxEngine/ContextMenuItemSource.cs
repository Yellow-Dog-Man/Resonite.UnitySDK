
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ContextMenuItemSource
// Generated on: pátek 13. února 2026 23:23:01
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ContextMenuItemSource")]
public partial class ContextMenuItemSource : global::FrooxEngine.Component, global::FrooxEngine.IButton, global::FrooxEngine.IButtonPressReceiver, global::FrooxEngine.IButtonHoverReceiver

{
    public global::System.String Label;
public UnityEngine.ColorX Color;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite> Sprite;
public global::System.Boolean ButtonEnabled;
public global::System.Boolean AllowDrag;
public global::System.Boolean CloseMenuOnPress;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Label", Label.ToResoniteLinkField());
members.Add("Color", Color.ToResoniteLinkField());
members.Add("Sprite", new ResoniteLink.Reference() { });
members.Add("ButtonEnabled", ButtonEnabled.ToResoniteLinkField());
members.Add("AllowDrag", AllowDrag.ToResoniteLinkField());
members.Add("CloseMenuOnPress", CloseMenuOnPress.ToResoniteLinkField());
}

}
}
