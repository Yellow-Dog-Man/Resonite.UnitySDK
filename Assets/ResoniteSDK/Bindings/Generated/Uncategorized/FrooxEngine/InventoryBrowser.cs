
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InventoryBrowser
// Generated on: úterý 24. února 2026 18:20:24
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_user", new ResoniteLink.SyncObject() { Members = _user.CollectMembers(context) });
members.Add("_autoReinitialize", _autoReinitialize.ToResoniteLinkField());
members.Add("_currentPath", _currentPath.ToResoniteLinkField());
members.Add("_currentOwnerId", _currentOwnerId.ToResoniteLinkField());
members.Add("_addNewButton", _addNewButton.ToResoniteReference(context));
members.Add("_deleteButton", _deleteButton.ToResoniteReference(context));
members.Add("_inventoriesButton", _inventoriesButton.ToResoniteReference(context));
members.Add("_shareButton", _shareButton.ToResoniteReference(context));
members.Add("_unshareButton", _unshareButton.ToResoniteReference(context));
members.Add("_copyLink", _copyLink.ToResoniteReference(context));
members.Add("_addCurrentAvatar", _addCurrentAvatar.ToResoniteReference(context));
members.Add("_lastSpecialItemType", _lastSpecialItemType.ToResoniteLinkField());
}

}
}
