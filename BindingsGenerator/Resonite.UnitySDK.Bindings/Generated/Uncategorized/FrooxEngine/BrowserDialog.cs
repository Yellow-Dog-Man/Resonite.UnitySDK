
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BrowserDialog
// Generated on: čtvrtek 26. února 2026 15:09:10
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.BrowserItem SelectedItem { get => SelectedItem_Element.Data; set => SelectedItem_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.BrowserItem>, global::FrooxEngine.BrowserItem> SelectedItem_Element = new();
public global::FrooxEngine.BrowserItem _previousSelectedItem { get => _previousSelectedItem_Element.Data; set => _previousSelectedItem_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.BrowserItem>, global::FrooxEngine.BrowserItem> _previousSelectedItem_Element = new();
public global::System.Boolean AllowSelect { get => AllowSelect_Element.Data; set => AllowSelect_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowSelect_Element = new();
public global::System.Single ItemSize { get => ItemSize_Element.Data; set => ItemSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ItemSize_Element = new();
public global::FrooxEngine.UIX.Text _selectedText { get => _selectedText_Element.Data; set => _selectedText_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _selectedText_Element = new();
public global::FrooxEngine.Slot _pathRoot { get => _pathRoot_Element.Data; set => _pathRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _pathRoot_Element = new();
public global::FrooxEngine.Slot _buttonsRoot { get => _buttonsRoot_Element.Data; set => _buttonsRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _buttonsRoot_Element = new();
public global::FrooxEngine.UIX.GridLayout _folderGrid { get => _folderGrid_Element.Data; set => _folderGrid_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.GridLayout>, global::FrooxEngine.UIX.GridLayout> _folderGrid_Element = new();
public global::FrooxEngine.UIX.GridLayout _itemGrid { get => _itemGrid_Element.Data; set => _itemGrid_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.GridLayout>, global::FrooxEngine.UIX.GridLayout> _itemGrid_Element = new();
public global::FrooxEngine.SpriteProvider _tabSprite { get => _tabSprite_Element.Data; set => _tabSprite_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.SpriteProvider>, global::FrooxEngine.SpriteProvider> _tabSprite_Element = new();
public global::FrooxEngine.Slot _loadingIndicator { get => _loadingIndicator_Element.Data; set => _loadingIndicator_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _loadingIndicator_Element = new();
public global::FrooxEngine.UIX.SlideSwapRegion _swapper { get => _swapper_Element.Data; set => _swapper_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.SlideSwapRegion>, global::FrooxEngine.UIX.SlideSwapRegion> _swapper_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SelectedItem", SelectedItem_Element.ToLinkReference(context));
members.Add("_previousSelectedItem", _previousSelectedItem_Element.ToLinkReference(context));
members.Add("AllowSelect", AllowSelect_Element.ToLinkField(context));
members.Add("ItemSize", ItemSize_Element.ToLinkField(context));
members.Add("_selectedText", _selectedText_Element.ToLinkReference(context));
members.Add("_pathRoot", _pathRoot_Element.ToLinkReference(context));
members.Add("_buttonsRoot", _buttonsRoot_Element.ToLinkReference(context));
members.Add("_folderGrid", _folderGrid_Element.ToLinkReference(context));
members.Add("_itemGrid", _itemGrid_Element.ToLinkReference(context));
members.Add("_tabSprite", _tabSprite_Element.ToLinkReference(context));
members.Add("_loadingIndicator", _loadingIndicator_Element.ToLinkReference(context));
members.Add("_swapper", _swapper_Element.ToLinkReference(context));
}

}
}
