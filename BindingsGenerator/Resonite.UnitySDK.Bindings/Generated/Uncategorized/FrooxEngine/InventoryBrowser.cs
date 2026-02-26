
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InventoryBrowser
// Generated on: čtvrtek 26. února 2026 12:28:11
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InventoryBrowser")]
public partial class InventoryBrowser : global::FrooxEngine.BrowserDialog

{
    public global::FrooxEngine.UserRef _user = new();
public global::System.Boolean _autoReinitialize { get => _autoReinitialize_Element.Data; set => _autoReinitialize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _autoReinitialize_Element = new();
public global::System.String _currentPath { get => _currentPath_Element.Data; set => _currentPath_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> _currentPath_Element = new();
public global::System.String _currentOwnerId { get => _currentOwnerId_Element.Data; set => _currentOwnerId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> _currentOwnerId_Element = new();
public global::FrooxEngine.UIX.Button _addNewButton { get => _addNewButton_Element.Data; set => _addNewButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _addNewButton_Element = new();
public global::FrooxEngine.UIX.Button _deleteButton { get => _deleteButton_Element.Data; set => _deleteButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _deleteButton_Element = new();
public global::FrooxEngine.UIX.Button _inventoriesButton { get => _inventoriesButton_Element.Data; set => _inventoriesButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _inventoriesButton_Element = new();
public global::FrooxEngine.UIX.Button _shareButton { get => _shareButton_Element.Data; set => _shareButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _shareButton_Element = new();
public global::FrooxEngine.UIX.Button _unshareButton { get => _unshareButton_Element.Data; set => _unshareButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _unshareButton_Element = new();
public global::FrooxEngine.UIX.Button _copyLink { get => _copyLink_Element.Data; set => _copyLink_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _copyLink_Element = new();
public global::FrooxEngine.UIX.Button _addCurrentAvatar { get => _addCurrentAvatar_Element.Data; set => _addCurrentAvatar_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _addCurrentAvatar_Element = new();
public global::FrooxEngine.InventoryBrowser.SpecialItemType _lastSpecialItemType { get => _lastSpecialItemType_Element.Data; set => _lastSpecialItemType_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.InventoryBrowser.SpecialItemType>, global::FrooxEngine.InventoryBrowser.SpecialItemType> _lastSpecialItemType_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_user", _user.ToLinkSyncObject(context));
members.Add("_autoReinitialize", _autoReinitialize_Element.ToLinkField(context));
members.Add("_currentPath", _currentPath_Element.ToLinkField(context));
members.Add("_currentOwnerId", _currentOwnerId_Element.ToLinkField(context));
members.Add("_addNewButton", _addNewButton_Element.ToLinkReference(context));
members.Add("_deleteButton", _deleteButton_Element.ToLinkReference(context));
members.Add("_inventoriesButton", _inventoriesButton_Element.ToLinkReference(context));
members.Add("_shareButton", _shareButton_Element.ToLinkReference(context));
members.Add("_unshareButton", _unshareButton_Element.ToLinkReference(context));
members.Add("_copyLink", _copyLink_Element.ToLinkReference(context));
members.Add("_addCurrentAvatar", _addCurrentAvatar_Element.ToLinkReference(context));
members.Add("_lastSpecialItemType", _lastSpecialItemType_Element.ToLinkField(context));
}

}
}
