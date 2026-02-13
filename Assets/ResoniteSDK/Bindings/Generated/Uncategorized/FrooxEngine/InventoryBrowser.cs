
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InventoryBrowser
// Generated on: pátek 13. února 2026 23:23:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InventoryBrowser")]
public partial class InventoryBrowser : global::FrooxEngine.BrowserDialog

{
    public global::FrooxEngine.UserRef _user;
public global::System.Boolean _autoReinitialize;
public global::System.String _currentPath;
public global::System.String _currentOwnerId;
public global::FrooxEngine.UIX.Button _addNewButton;
public global::FrooxEngine.UIX.Button _deleteButton;
public global::FrooxEngine.UIX.Button _inventoriesButton;
public global::FrooxEngine.UIX.Button _shareButton;
public global::FrooxEngine.UIX.Button _unshareButton;
public global::FrooxEngine.UIX.Button _copyLink;
public global::FrooxEngine.UIX.Button _addCurrentAvatar;
public global::FrooxEngine.InventoryBrowser.SpecialItemType _lastSpecialItemType;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_user", new ResoniteLink.SyncObject() { Members = _user.CollectMembers() });
members.Add("_autoReinitialize", _autoReinitialize.ToResoniteLinkField());
members.Add("_currentPath", _currentPath.ToResoniteLinkField());
members.Add("_currentOwnerId", _currentOwnerId.ToResoniteLinkField());
members.Add("_addNewButton", new ResoniteLink.Reference() { });
members.Add("_deleteButton", new ResoniteLink.Reference() { });
members.Add("_inventoriesButton", new ResoniteLink.Reference() { });
members.Add("_shareButton", new ResoniteLink.Reference() { });
members.Add("_unshareButton", new ResoniteLink.Reference() { });
members.Add("_copyLink", new ResoniteLink.Reference() { });
members.Add("_addCurrentAvatar", new ResoniteLink.Reference() { });
members.Add("_lastSpecialItemType", _lastSpecialItemType.ToResoniteLinkField());
}

}
}
