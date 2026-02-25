
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NotificationSettings
// Generated on: středa 25. února 2026 16:14:42
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NotificationSettings")]
public partial class NotificationSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.NotificationSettings>

{
    public global::System.Boolean UserOnline;
public global::System.Boolean UserOnlineOnAnotherBuild;
public global::FrooxEngine.NotificationType UserSociable;
public global::FrooxEngine.NotificationType Message;
public global::FrooxEngine.NotificationType Invite;
public global::FrooxEngine.NotificationType ContactRequest;
public global::FrooxEngine.NotificationType InviteRequest;
public global::FrooxEngine.NotificationType ContactSessionStarted;
public global::FrooxEngine.NotificationType PublicSessionStarted;
public global::FrooxEngine.NotificationType UserJoinAndLeave;
public global::FrooxEngine.NotificationType PermissionChanged;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UserOnline", UserOnline.ToResoniteLinkField());
members.Add("UserOnlineOnAnotherBuild", UserOnlineOnAnotherBuild.ToResoniteLinkField());
members.Add("UserSociable", UserSociable.ToResoniteLinkField());
members.Add("Message", Message.ToResoniteLinkField());
members.Add("Invite", Invite.ToResoniteLinkField());
members.Add("ContactRequest", ContactRequest.ToResoniteLinkField());
members.Add("InviteRequest", InviteRequest.ToResoniteLinkField());
members.Add("ContactSessionStarted", ContactSessionStarted.ToResoniteLinkField());
members.Add("PublicSessionStarted", PublicSessionStarted.ToResoniteLinkField());
members.Add("UserJoinAndLeave", UserJoinAndLeave.ToResoniteLinkField());
members.Add("PermissionChanged", PermissionChanged.ToResoniteLinkField());
}

}
}
