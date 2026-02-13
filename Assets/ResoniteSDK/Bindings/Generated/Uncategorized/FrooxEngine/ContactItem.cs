
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ContactItem
// Generated on: pátek 13. února 2026 5:52:29
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ContactItem")]
public partial class ContactItem : global::FrooxEngine.CircleThumbnailItem

{
    public global::FrooxEngine.UIX.Text _username;
public global::FrooxEngine.UIX.Text _status;
public global::FrooxEngine.UIX.Text _unreadCount;
public global::FrooxEngine.UIX.Button _joinButton;
public global::System.String _rawUsername;
public System.Collections.Generic.List<global::System.String> _alternateNames;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_username", new ResoniteLink.Reference() { });
members.Add("_status", new ResoniteLink.Reference() { });
members.Add("_unreadCount", new ResoniteLink.Reference() { });
members.Add("_joinButton", new ResoniteLink.Reference() { });
members.Add("_rawUsername", _rawUsername.ToResoniteLinkField());
members.Add("_alternateNames", new ResoniteLink.SyncList()
{
    Elements = _alternateNames.Select(m => m.ToResoniteLinkField()).ToList<ResoniteLink.Member>()
});
}

}
}
