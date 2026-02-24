
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RadiantSearchBar
// Generated on: úterý 24. února 2026 18:20:03
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RadiantSearchBar")]
public partial class RadiantSearchBar : global::FrooxEngine.Component

{
    public global::System.String SearchTerm;
public global::System.Boolean IsSearching;
public global::System.Single SearchAnimTileSpeed;
public UnityEngine.ColorX SearchAnimColor;
public global::FrooxEngine.UIX.TextField _textField;
public global::FrooxEngine.UIX.Text _searchText;
public global::FrooxEngine.UIX.Text _defaultText;
public global::FrooxEngine.UIX.TiledRawImage _searchingVisual;
public global::FrooxEngine.UIX.Button _cancelButton;
public global::FrooxEngine.IField<global::System.Boolean> _defaultVisible;
public global::FrooxEngine.IField<UnityEngine.ColorX> _searchingAnimationColor;
public global::FrooxEngine.IField<UnityEngine.Vector2> _searchingTextureOffset;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SearchTerm", SearchTerm.ToResoniteLinkField());
members.Add("IsSearching", IsSearching.ToResoniteLinkField());
members.Add("SearchAnimTileSpeed", SearchAnimTileSpeed.ToResoniteLinkField());
members.Add("SearchAnimColor", SearchAnimColor.ToResoniteLinkField());
members.Add("_textField", _textField.ToResoniteReference(context));
members.Add("_searchText", _searchText.ToResoniteReference(context));
members.Add("_defaultText", _defaultText.ToResoniteReference(context));
members.Add("_searchingVisual", _searchingVisual.ToResoniteReference(context));
members.Add("_cancelButton", _cancelButton.ToResoniteReference(context));
members.Add("_defaultVisible", _defaultVisible.ToResoniteReference(context));
members.Add("_searchingAnimationColor", _searchingAnimationColor.ToResoniteReference(context));
members.Add("_searchingTextureOffset", _searchingTextureOffset.ToResoniteReference(context));
}

}
}
