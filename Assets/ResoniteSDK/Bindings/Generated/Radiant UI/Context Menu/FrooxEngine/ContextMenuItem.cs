
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ContextMenuItem
// Generated on: pátek 13. února 2026 23:22:57
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Highlight", Highlight.ToResoniteLinkField());
members.Add("Icon", new ResoniteLink.Reference() { });
members.Add("Sprite", new ResoniteLink.Reference() { });
members.Add("Label", new ResoniteLink.Reference() { });
members.Add("Color", Color.ToResoniteLinkField());
members.Add("_menu", new ResoniteLink.Reference() { });
members.Add("_highlighted", _highlighted.ToResoniteLinkField());
members.Add("_arc", new ResoniteLink.Reference() { });
members.Add("_outerRadius", new ResoniteLink.Reference() { });
members.Add("_button", new ResoniteLink.Reference() { });
}

}
}
