
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ContactsDialog
// Generated on: sobota 14. února 2026 8:58:42
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_searchBar", _searchBar.ToResoniteReference(context));
members.Add("_listRoot", _listRoot.ToResoniteReference(context));
members.Add("_sessionsRoot", _sessionsRoot.ToResoniteReference(context));
members.Add("_messagesRoot", _messagesRoot.ToResoniteReference(context));
members.Add("_status", _status.ToResoniteReference(context));
members.Add("_avatar", _avatar.ToResoniteReference(context));
members.Add("_username", _username.ToResoniteReference(context));
members.Add("_userActionsRoot", _userActionsRoot.ToResoniteReference(context));
members.Add("_sendMessageButton", _sendMessageButton.ToResoniteReference(context));
members.Add("_sendVoiceMessageButton", _sendVoiceMessageButton.ToResoniteReference(context));
members.Add("_sendMessageTextField", _sendMessageTextField.ToResoniteReference(context));
members.Add("_messagesScrollRect", _messagesScrollRect.ToResoniteReference(context));
members.Add("_inviteButton", _inviteButton.ToResoniteReference(context));
members.Add("_requestInviteButton", _requestInviteButton.ToResoniteReference(context));
members.Add("_banAllButton", _banAllButton.ToResoniteReference(context));
members.Add("_banSessionButton", _banSessionButton.ToResoniteReference(context));
members.Add("_unblockedButton", _unblockedButton.ToResoniteReference(context));
members.Add("_avatarBlockButton", _avatarBlockButton.ToResoniteReference(context));
members.Add("_mutualBlockButton", _mutualBlockButton.ToResoniteReference(context));
}

}
}
