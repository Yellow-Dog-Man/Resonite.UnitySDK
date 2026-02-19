
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BrowserDialog
// Generated on: čtvrtek 19. února 2026 8:00:26
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SelectedItem", SelectedItem.ToResoniteReference(context));
members.Add("_previousSelectedItem", _previousSelectedItem.ToResoniteReference(context));
members.Add("AllowSelect", AllowSelect.ToResoniteLinkField());
members.Add("ItemSize", ItemSize.ToResoniteLinkField());
members.Add("_selectedText", _selectedText.ToResoniteReference(context));
members.Add("_pathRoot", _pathRoot.ToResoniteReference(context));
members.Add("_buttonsRoot", _buttonsRoot.ToResoniteReference(context));
members.Add("_folderGrid", _folderGrid.ToResoniteReference(context));
members.Add("_itemGrid", _itemGrid.ToResoniteReference(context));
members.Add("_tabSprite", _tabSprite.ToResoniteReference(context));
members.Add("_loadingIndicator", _loadingIndicator.ToResoniteReference(context));
members.Add("_swapper", _swapper.ToResoniteReference(context));
}

}
}
