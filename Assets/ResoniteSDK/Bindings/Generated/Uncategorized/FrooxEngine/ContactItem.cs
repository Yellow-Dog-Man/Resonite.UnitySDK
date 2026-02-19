
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ContactItem
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ContactItem")]
public partial class ContactItem : global::FrooxEngine.CircleThumbnailItem

{
    public global::FrooxEngine.UIX.Text _username;
public global::FrooxEngine.UIX.Text _status;
public global::FrooxEngine.UIX.Text _unreadCount;
public global::FrooxEngine.UIX.Button _joinButton;
public global::System.String _rawUsername;
public System.Collections.Generic.List<global::System.String> _alternateNames;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_username", _username.ToResoniteReference(context));
members.Add("_status", _status.ToResoniteReference(context));
members.Add("_unreadCount", _unreadCount.ToResoniteReference(context));
members.Add("_joinButton", _joinButton.ToResoniteReference(context));
members.Add("_rawUsername", _rawUsername.ToResoniteLinkField());
members.Add("_alternateNames", new ResoniteLink.SyncList()
{
    Elements = _alternateNames.ConvertList(m => m.ToResoniteLinkField())
});
}

}
}
