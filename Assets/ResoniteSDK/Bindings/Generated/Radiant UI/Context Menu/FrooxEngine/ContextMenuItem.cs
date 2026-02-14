
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ContextMenuItem
// Generated on: sobota 14. února 2026 8:58:27
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ContextMenuItem")]
public partial class ContextMenuItem : global::FrooxEngine.Component, global::FrooxEngine.IButtonHoverReceiver, global::FrooxEngine.IButtonPressReceiver

{
    public global::System.Boolean Highlight;
public global::FrooxEngine.UIX.Image Icon;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite> Sprite;
public global::FrooxEngine.IField<global::System.String> Label;
public UnityEngine.ColorX Color;
public global::FrooxEngine.ContextMenu _menu;
public global::System.Boolean _highlighted;
public global::FrooxEngine.IField<global::System.Single> _arc;
public global::FrooxEngine.IField<global::System.Single> _outerRadius;
public global::FrooxEngine.UIX.Button _button;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Highlight", Highlight.ToResoniteLinkField());
members.Add("Icon", Icon.ToResoniteReference(context));
members.Add("Sprite", Sprite.ToResoniteReference(context));
members.Add("Label", Label.ToResoniteReference(context));
members.Add("Color", Color.ToResoniteLinkField());
members.Add("_menu", _menu.ToResoniteReference(context));
members.Add("_highlighted", _highlighted.ToResoniteLinkField());
members.Add("_arc", _arc.ToResoniteReference(context));
members.Add("_outerRadius", _outerRadius.ToResoniteReference(context));
members.Add("_button", _button.ToResoniteReference(context));
}

}
}
