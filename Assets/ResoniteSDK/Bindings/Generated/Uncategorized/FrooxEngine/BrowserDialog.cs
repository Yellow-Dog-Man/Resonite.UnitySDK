
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BrowserDialog
// Generated on: pátek 13. února 2026 23:23:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BrowserDialog")]
public abstract partial class BrowserDialog : global::FrooxEngine.Component

{
    public global::FrooxEngine.BrowserItem SelectedItem;
public global::FrooxEngine.BrowserItem _previousSelectedItem;
public global::System.Boolean AllowSelect;
public global::System.Single ItemSize;
public global::FrooxEngine.UIX.Text _selectedText;
public global::FrooxEngine.Slot _pathRoot;
public global::FrooxEngine.Slot _buttonsRoot;
public global::FrooxEngine.UIX.GridLayout _folderGrid;
public global::FrooxEngine.UIX.GridLayout _itemGrid;
public global::FrooxEngine.SpriteProvider _tabSprite;
public global::FrooxEngine.Slot _loadingIndicator;
public global::FrooxEngine.UIX.SlideSwapRegion _swapper;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("SelectedItem", new ResoniteLink.Reference() { });
members.Add("_previousSelectedItem", new ResoniteLink.Reference() { });
members.Add("AllowSelect", AllowSelect.ToResoniteLinkField());
members.Add("ItemSize", ItemSize.ToResoniteLinkField());
members.Add("_selectedText", new ResoniteLink.Reference() { });
members.Add("_pathRoot", new ResoniteLink.Reference() { });
members.Add("_buttonsRoot", new ResoniteLink.Reference() { });
members.Add("_folderGrid", new ResoniteLink.Reference() { });
members.Add("_itemGrid", new ResoniteLink.Reference() { });
members.Add("_tabSprite", new ResoniteLink.Reference() { });
members.Add("_loadingIndicator", new ResoniteLink.Reference() { });
members.Add("_swapper", new ResoniteLink.Reference() { });
}

}
}
