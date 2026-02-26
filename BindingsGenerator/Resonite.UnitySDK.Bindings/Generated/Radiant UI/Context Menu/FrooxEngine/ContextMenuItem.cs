
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ContextMenuItem
// Generated on: čtvrtek 26. února 2026 10:04:32
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ContextMenuItem")]
public partial class ContextMenuItem : global::FrooxEngine.Component, global::FrooxEngine.IButtonHoverReceiver, global::FrooxEngine.IButtonPressReceiver

{
    public global::System.Boolean Highlight { get => Highlight_Element.Data; set => Highlight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Highlight_Element = new();
public global::FrooxEngine.UIX.Image Icon { get => Icon_Element.Data; set => Icon_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Image>, global::FrooxEngine.UIX.Image> Icon_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite> Sprite { get => Sprite_Element.Data; set => Sprite_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite>>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite>> Sprite_Element = new();
public global::FrooxEngine.IField<global::System.String> Label { get => Label_Element.Data; set => Label_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> Label_Element = new();
public UnityEngine.ColorX Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color_Element = new();
public global::FrooxEngine.ContextMenu _menu { get => _menu_Element.Data; set => _menu_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ContextMenu>, global::FrooxEngine.ContextMenu> _menu_Element = new();
public global::System.Boolean _highlighted { get => _highlighted_Element.Data; set => _highlighted_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _highlighted_Element = new();
public global::FrooxEngine.IField<global::System.Single> _arc { get => _arc_Element.Data; set => _arc_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _arc_Element = new();
public global::FrooxEngine.IField<global::System.Single> _outerRadius { get => _outerRadius_Element.Data; set => _outerRadius_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _outerRadius_Element = new();
public global::FrooxEngine.UIX.Button _button { get => _button_Element.Data; set => _button_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _button_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Highlight", Highlight_Element.Data.ToResoniteLinkField());
members.Add("Icon", Icon_Element.Data.ToResoniteReference(context));
members.Add("Sprite", Sprite_Element.Data.ToResoniteReference(context));
members.Add("Label", Label_Element.Data.ToResoniteReference(context));
members.Add("Color", Color_Element.Data.ToResoniteLinkField());
members.Add("_menu", _menu_Element.Data.ToResoniteReference(context));
members.Add("_highlighted", _highlighted_Element.Data.ToResoniteLinkField());
members.Add("_arc", _arc_Element.Data.ToResoniteReference(context));
members.Add("_outerRadius", _outerRadius_Element.Data.ToResoniteReference(context));
members.Add("_button", _button_Element.Data.ToResoniteReference(context));
}

}
}
