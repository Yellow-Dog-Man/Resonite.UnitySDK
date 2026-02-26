
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ContactsDialog
// Generated on: čtvrtek 26. února 2026 12:28:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ContactsDialog")]
public partial class ContactsDialog : global::FrooxEngine.Component

{
    public global::FrooxEngine.UIX.TextField _searchBar { get => _searchBar_Element.Data; set => _searchBar_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _searchBar_Element = new();
public global::FrooxEngine.Slot _listRoot { get => _listRoot_Element.Data; set => _listRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _listRoot_Element = new();
public global::FrooxEngine.Slot _sessionsRoot { get => _sessionsRoot_Element.Data; set => _sessionsRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _sessionsRoot_Element = new();
public global::FrooxEngine.Slot _messagesRoot { get => _messagesRoot_Element.Data; set => _messagesRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _messagesRoot_Element = new();
public global::FrooxEngine.UIX.Image _status { get => _status_Element.Data; set => _status_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Image>, global::FrooxEngine.UIX.Image> _status_Element = new();
public global::FrooxEngine.UIX.Image _avatar { get => _avatar_Element.Data; set => _avatar_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Image>, global::FrooxEngine.UIX.Image> _avatar_Element = new();
public global::FrooxEngine.UIX.Text _username { get => _username_Element.Data; set => _username_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _username_Element = new();
public global::FrooxEngine.Slot _userActionsRoot { get => _userActionsRoot_Element.Data; set => _userActionsRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _userActionsRoot_Element = new();
public global::FrooxEngine.UIX.Button _sendMessageButton { get => _sendMessageButton_Element.Data; set => _sendMessageButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _sendMessageButton_Element = new();
public global::FrooxEngine.UIX.Button _sendVoiceMessageButton { get => _sendVoiceMessageButton_Element.Data; set => _sendVoiceMessageButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _sendVoiceMessageButton_Element = new();
public global::FrooxEngine.UIX.TextField _sendMessageTextField { get => _sendMessageTextField_Element.Data; set => _sendMessageTextField_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _sendMessageTextField_Element = new();
public global::FrooxEngine.UIX.ScrollRect _messagesScrollRect { get => _messagesScrollRect_Element.Data; set => _messagesScrollRect_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.ScrollRect>, global::FrooxEngine.UIX.ScrollRect> _messagesScrollRect_Element = new();
public global::FrooxEngine.UIX.Button _inviteButton { get => _inviteButton_Element.Data; set => _inviteButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _inviteButton_Element = new();
public global::FrooxEngine.UIX.Button _requestInviteButton { get => _requestInviteButton_Element.Data; set => _requestInviteButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _requestInviteButton_Element = new();
public global::FrooxEngine.UIX.Button _banAllButton { get => _banAllButton_Element.Data; set => _banAllButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _banAllButton_Element = new();
public global::FrooxEngine.UIX.Button _banSessionButton { get => _banSessionButton_Element.Data; set => _banSessionButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _banSessionButton_Element = new();
public global::FrooxEngine.UIX.Button _unblockedButton { get => _unblockedButton_Element.Data; set => _unblockedButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _unblockedButton_Element = new();
public global::FrooxEngine.UIX.Button _avatarBlockButton { get => _avatarBlockButton_Element.Data; set => _avatarBlockButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _avatarBlockButton_Element = new();
public global::FrooxEngine.UIX.Button _mutualBlockButton { get => _mutualBlockButton_Element.Data; set => _mutualBlockButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _mutualBlockButton_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_searchBar", _searchBar_Element.ToLinkReference(context));
members.Add("_listRoot", _listRoot_Element.ToLinkReference(context));
members.Add("_sessionsRoot", _sessionsRoot_Element.ToLinkReference(context));
members.Add("_messagesRoot", _messagesRoot_Element.ToLinkReference(context));
members.Add("_status", _status_Element.ToLinkReference(context));
members.Add("_avatar", _avatar_Element.ToLinkReference(context));
members.Add("_username", _username_Element.ToLinkReference(context));
members.Add("_userActionsRoot", _userActionsRoot_Element.ToLinkReference(context));
members.Add("_sendMessageButton", _sendMessageButton_Element.ToLinkReference(context));
members.Add("_sendVoiceMessageButton", _sendVoiceMessageButton_Element.ToLinkReference(context));
members.Add("_sendMessageTextField", _sendMessageTextField_Element.ToLinkReference(context));
members.Add("_messagesScrollRect", _messagesScrollRect_Element.ToLinkReference(context));
members.Add("_inviteButton", _inviteButton_Element.ToLinkReference(context));
members.Add("_requestInviteButton", _requestInviteButton_Element.ToLinkReference(context));
members.Add("_banAllButton", _banAllButton_Element.ToLinkReference(context));
members.Add("_banSessionButton", _banSessionButton_Element.ToLinkReference(context));
members.Add("_unblockedButton", _unblockedButton_Element.ToLinkReference(context));
members.Add("_avatarBlockButton", _avatarBlockButton_Element.ToLinkReference(context));
members.Add("_mutualBlockButton", _mutualBlockButton_Element.ToLinkReference(context));
}

}
}
