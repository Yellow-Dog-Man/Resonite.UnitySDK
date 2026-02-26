
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ContextMenuItemSource
// Generated on: čtvrtek 26. února 2026 10:04:35
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
    public global::System.String Label { get => Label_Element.Data; set => Label_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Label_Element = new();
public UnityEngine.ColorX Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite> Sprite { get => Sprite_Element.Data; set => Sprite_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite>>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite>> Sprite_Element = new();
public global::System.Boolean ButtonEnabled { get => ButtonEnabled_Element.Data; set => ButtonEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ButtonEnabled_Element = new();
public global::System.Boolean AllowDrag { get => AllowDrag_Element.Data; set => AllowDrag_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowDrag_Element = new();
public global::System.Boolean CloseMenuOnPress { get => CloseMenuOnPress_Element.Data; set => CloseMenuOnPress_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CloseMenuOnPress_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Label", Label_Element.Data.ToResoniteLinkField());
members.Add("Color", Color_Element.Data.ToResoniteLinkField());
members.Add("Sprite", Sprite_Element.Data.ToResoniteReference(context));
members.Add("ButtonEnabled", ButtonEnabled_Element.Data.ToResoniteLinkField());
members.Add("AllowDrag", AllowDrag_Element.Data.ToResoniteLinkField());
members.Add("CloseMenuOnPress", CloseMenuOnPress_Element.Data.ToResoniteLinkField());
}

}
}
