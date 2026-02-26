
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NotificationSettings
// Generated on: čtvrtek 26. února 2026 10:04:47
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
    public global::System.Boolean UserOnline { get => UserOnline_Element.Data; set => UserOnline_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UserOnline_Element = new();
public global::System.Boolean UserOnlineOnAnotherBuild { get => UserOnlineOnAnotherBuild_Element.Data; set => UserOnlineOnAnotherBuild_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UserOnlineOnAnotherBuild_Element = new();
public global::FrooxEngine.NotificationType UserSociable { get => UserSociable_Element.Data; set => UserSociable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.NotificationType>, global::FrooxEngine.NotificationType> UserSociable_Element = new();
public global::FrooxEngine.NotificationType Message { get => Message_Element.Data; set => Message_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.NotificationType>, global::FrooxEngine.NotificationType> Message_Element = new();
public global::FrooxEngine.NotificationType Invite { get => Invite_Element.Data; set => Invite_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.NotificationType>, global::FrooxEngine.NotificationType> Invite_Element = new();
public global::FrooxEngine.NotificationType ContactRequest { get => ContactRequest_Element.Data; set => ContactRequest_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.NotificationType>, global::FrooxEngine.NotificationType> ContactRequest_Element = new();
public global::FrooxEngine.NotificationType InviteRequest { get => InviteRequest_Element.Data; set => InviteRequest_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.NotificationType>, global::FrooxEngine.NotificationType> InviteRequest_Element = new();
public global::FrooxEngine.NotificationType ContactSessionStarted { get => ContactSessionStarted_Element.Data; set => ContactSessionStarted_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.NotificationType>, global::FrooxEngine.NotificationType> ContactSessionStarted_Element = new();
public global::FrooxEngine.NotificationType PublicSessionStarted { get => PublicSessionStarted_Element.Data; set => PublicSessionStarted_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.NotificationType>, global::FrooxEngine.NotificationType> PublicSessionStarted_Element = new();
public global::FrooxEngine.NotificationType UserJoinAndLeave { get => UserJoinAndLeave_Element.Data; set => UserJoinAndLeave_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.NotificationType>, global::FrooxEngine.NotificationType> UserJoinAndLeave_Element = new();
public global::FrooxEngine.NotificationType PermissionChanged { get => PermissionChanged_Element.Data; set => PermissionChanged_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.NotificationType>, global::FrooxEngine.NotificationType> PermissionChanged_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UserOnline", UserOnline_Element.Data.ToResoniteLinkField());
members.Add("UserOnlineOnAnotherBuild", UserOnlineOnAnotherBuild_Element.Data.ToResoniteLinkField());
members.Add("UserSociable", UserSociable_Element.Data.ToResoniteLinkField());
members.Add("Message", Message_Element.Data.ToResoniteLinkField());
members.Add("Invite", Invite_Element.Data.ToResoniteLinkField());
members.Add("ContactRequest", ContactRequest_Element.Data.ToResoniteLinkField());
members.Add("InviteRequest", InviteRequest_Element.Data.ToResoniteLinkField());
members.Add("ContactSessionStarted", ContactSessionStarted_Element.Data.ToResoniteLinkField());
members.Add("PublicSessionStarted", PublicSessionStarted_Element.Data.ToResoniteLinkField());
members.Add("UserJoinAndLeave", UserJoinAndLeave_Element.Data.ToResoniteLinkField());
members.Add("PermissionChanged", PermissionChanged_Element.Data.ToResoniteLinkField());
}

}
}
