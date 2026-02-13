
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ContactsDialog
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ContactsDialog")]
public partial class ContactsDialog : global::FrooxEngine.Component

{
    public global::FrooxEngine.UIX.TextField _searchBar;
public global::FrooxEngine.Slot _listRoot;
public global::FrooxEngine.Slot _sessionsRoot;
public global::FrooxEngine.Slot _messagesRoot;
public global::FrooxEngine.UIX.Image _status;
public global::FrooxEngine.UIX.Image _avatar;
public global::FrooxEngine.UIX.Text _username;
public global::FrooxEngine.Slot _userActionsRoot;
public global::FrooxEngine.UIX.Button _sendMessageButton;
public global::FrooxEngine.UIX.Button _sendVoiceMessageButton;
public global::FrooxEngine.UIX.TextField _sendMessageTextField;
public global::FrooxEngine.UIX.ScrollRect _messagesScrollRect;
public global::FrooxEngine.UIX.Button _inviteButton;
public global::FrooxEngine.UIX.Button _requestInviteButton;
public global::FrooxEngine.UIX.Button _banAllButton;
public global::FrooxEngine.UIX.Button _banSessionButton;
public global::FrooxEngine.UIX.Button _unblockedButton;
public global::FrooxEngine.UIX.Button _avatarBlockButton;
public global::FrooxEngine.UIX.Button _mutualBlockButton;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_searchBar", new ResoniteLink.Reference() { });
members.Add("_listRoot", new ResoniteLink.Reference() { });
members.Add("_sessionsRoot", new ResoniteLink.Reference() { });
members.Add("_messagesRoot", new ResoniteLink.Reference() { });
members.Add("_status", new ResoniteLink.Reference() { });
members.Add("_avatar", new ResoniteLink.Reference() { });
members.Add("_username", new ResoniteLink.Reference() { });
members.Add("_userActionsRoot", new ResoniteLink.Reference() { });
members.Add("_sendMessageButton", new ResoniteLink.Reference() { });
members.Add("_sendVoiceMessageButton", new ResoniteLink.Reference() { });
members.Add("_sendMessageTextField", new ResoniteLink.Reference() { });
members.Add("_messagesScrollRect", new ResoniteLink.Reference() { });
members.Add("_inviteButton", new ResoniteLink.Reference() { });
members.Add("_requestInviteButton", new ResoniteLink.Reference() { });
members.Add("_banAllButton", new ResoniteLink.Reference() { });
members.Add("_banSessionButton", new ResoniteLink.Reference() { });
members.Add("_unblockedButton", new ResoniteLink.Reference() { });
members.Add("_avatarBlockButton", new ResoniteLink.Reference() { });
members.Add("_mutualBlockButton", new ResoniteLink.Reference() { });
}

}
}
