
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RadiantSearchBar
// Generated on: pátek 13. února 2026 23:23:02
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("SearchTerm", SearchTerm.ToResoniteLinkField());
members.Add("IsSearching", IsSearching.ToResoniteLinkField());
members.Add("SearchAnimTileSpeed", SearchAnimTileSpeed.ToResoniteLinkField());
members.Add("SearchAnimColor", SearchAnimColor.ToResoniteLinkField());
members.Add("_textField", new ResoniteLink.Reference() { });
members.Add("_searchText", new ResoniteLink.Reference() { });
members.Add("_defaultText", new ResoniteLink.Reference() { });
members.Add("_searchingVisual", new ResoniteLink.Reference() { });
members.Add("_cancelButton", new ResoniteLink.Reference() { });
members.Add("_defaultVisible", new ResoniteLink.Reference() { });
members.Add("_searchingAnimationColor", new ResoniteLink.Reference() { });
members.Add("_searchingTextureOffset", new ResoniteLink.Reference() { });
}

}
}
