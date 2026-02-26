
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RadiantSearchBar
// Generated on: čtvrtek 26. února 2026 10:04:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RadiantSearchBar")]
public partial class RadiantSearchBar : global::FrooxEngine.Component

{
    public global::System.String SearchTerm { get => SearchTerm_Element.Data; set => SearchTerm_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> SearchTerm_Element = new();
public global::System.Boolean IsSearching { get => IsSearching_Element.Data; set => IsSearching_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsSearching_Element = new();
public global::System.Single SearchAnimTileSpeed { get => SearchAnimTileSpeed_Element.Data; set => SearchAnimTileSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SearchAnimTileSpeed_Element = new();
public UnityEngine.ColorX SearchAnimColor { get => SearchAnimColor_Element.Data; set => SearchAnimColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> SearchAnimColor_Element = new();
public global::FrooxEngine.UIX.TextField _textField { get => _textField_Element.Data; set => _textField_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _textField_Element = new();
public global::FrooxEngine.UIX.Text _searchText { get => _searchText_Element.Data; set => _searchText_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _searchText_Element = new();
public global::FrooxEngine.UIX.Text _defaultText { get => _defaultText_Element.Data; set => _defaultText_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _defaultText_Element = new();
public global::FrooxEngine.UIX.TiledRawImage _searchingVisual { get => _searchingVisual_Element.Data; set => _searchingVisual_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TiledRawImage>, global::FrooxEngine.UIX.TiledRawImage> _searchingVisual_Element = new();
public global::FrooxEngine.UIX.Button _cancelButton { get => _cancelButton_Element.Data; set => _cancelButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _cancelButton_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _defaultVisible { get => _defaultVisible_Element.Data; set => _defaultVisible_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _defaultVisible_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _searchingAnimationColor { get => _searchingAnimationColor_Element.Data; set => _searchingAnimationColor_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _searchingAnimationColor_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _searchingTextureOffset { get => _searchingTextureOffset_Element.Data; set => _searchingTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _searchingTextureOffset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SearchTerm", SearchTerm_Element.Data.ToResoniteLinkField());
members.Add("IsSearching", IsSearching_Element.Data.ToResoniteLinkField());
members.Add("SearchAnimTileSpeed", SearchAnimTileSpeed_Element.Data.ToResoniteLinkField());
members.Add("SearchAnimColor", SearchAnimColor_Element.Data.ToResoniteLinkField());
members.Add("_textField", _textField_Element.Data.ToResoniteReference(context));
members.Add("_searchText", _searchText_Element.Data.ToResoniteReference(context));
members.Add("_defaultText", _defaultText_Element.Data.ToResoniteReference(context));
members.Add("_searchingVisual", _searchingVisual_Element.Data.ToResoniteReference(context));
members.Add("_cancelButton", _cancelButton_Element.Data.ToResoniteReference(context));
members.Add("_defaultVisible", _defaultVisible_Element.Data.ToResoniteReference(context));
members.Add("_searchingAnimationColor", _searchingAnimationColor_Element.Data.ToResoniteReference(context));
members.Add("_searchingTextureOffset", _searchingTextureOffset_Element.Data.ToResoniteReference(context));
}

}
}
