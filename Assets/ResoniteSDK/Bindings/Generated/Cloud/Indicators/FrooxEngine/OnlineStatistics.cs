
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OnlineStatistics
// Generated on: úterý 24. února 2026 18:17:44
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.OnlineStatistics")]
public partial class OnlineStatistics : global::FrooxEngine.Component

{
    public global::System.DateTime Timestamp;
public global::FrooxEngine.OnlineStatistics.SessionStats VisibleSessions;
public global::FrooxEngine.OnlineStatistics.SessionStats HiddenSessions;
public global::FrooxEngine.OnlineStatistics.SessionStats ActiveVisibleSessions;
public global::FrooxEngine.OnlineStatistics.SessionStats ActiveHiddenSessions;
public global::System.Nullable<global::System.Int32> RegisteredOnlineUsers;
public global::System.Nullable<global::System.Int32> TotalOnlineUsers;
public global::System.Nullable<global::System.Int32> PresentUsers;
public global::System.Nullable<global::System.Int32> AwayUsers;
public global::System.Nullable<global::System.Int32> UsersInVR;
public global::System.Nullable<global::System.Int32> UsersInScreen;
public global::System.Nullable<global::System.Int32> UsersOnDesktop;
public global::System.Nullable<global::System.Int32> UsersOnMobile;
public global::System.Nullable<global::System.Int32> UsersInVisiblePublicSessions;
public global::System.Nullable<global::System.Int32> UsersInVisibleSemiAccessibleSessions;
public global::System.Nullable<global::System.Int32> UsersInHiddenSessions;
public global::System.Nullable<global::System.Int32> UsersInPrivateSessions;
public global::System.Nullable<global::System.Int32> UsersInPrivate;
public global::System.Nullable<global::System.Int32> UsersInLAN;
public global::System.Nullable<global::System.Int32> UsersInContacts;
public global::System.Nullable<global::System.Int32> UsersInContactsPlus;
public global::System.Nullable<global::System.Int32> UsersInRegistered;
public global::System.Nullable<global::System.Int32> UsersInPublic;
public global::System.Nullable<global::System.Int32> GraphicalClientUsers;
public global::System.Nullable<global::System.Int32> ChatClientUsers;
public global::System.Nullable<global::System.Int32> HeadlessUsers;
public global::System.Nullable<global::System.Int32> BotUsers;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Timestamp", Timestamp.ToResoniteLinkField());
members.Add("VisibleSessions", new ResoniteLink.SyncObject() { Members = VisibleSessions.CollectMembers(context) });
members.Add("HiddenSessions", new ResoniteLink.SyncObject() { Members = HiddenSessions.CollectMembers(context) });
members.Add("ActiveVisibleSessions", new ResoniteLink.SyncObject() { Members = ActiveVisibleSessions.CollectMembers(context) });
members.Add("ActiveHiddenSessions", new ResoniteLink.SyncObject() { Members = ActiveHiddenSessions.CollectMembers(context) });
members.Add("RegisteredOnlineUsers", RegisteredOnlineUsers.ToResoniteLinkField());
members.Add("TotalOnlineUsers", TotalOnlineUsers.ToResoniteLinkField());
members.Add("PresentUsers", PresentUsers.ToResoniteLinkField());
members.Add("AwayUsers", AwayUsers.ToResoniteLinkField());
members.Add("UsersInVR", UsersInVR.ToResoniteLinkField());
members.Add("UsersInScreen", UsersInScreen.ToResoniteLinkField());
members.Add("UsersOnDesktop", UsersOnDesktop.ToResoniteLinkField());
members.Add("UsersOnMobile", UsersOnMobile.ToResoniteLinkField());
members.Add("UsersInVisiblePublicSessions", UsersInVisiblePublicSessions.ToResoniteLinkField());
members.Add("UsersInVisibleSemiAccessibleSessions", UsersInVisibleSemiAccessibleSessions.ToResoniteLinkField());
members.Add("UsersInHiddenSessions", UsersInHiddenSessions.ToResoniteLinkField());
members.Add("UsersInPrivateSessions", UsersInPrivateSessions.ToResoniteLinkField());
members.Add("UsersInPrivate", UsersInPrivate.ToResoniteLinkField());
members.Add("UsersInLAN", UsersInLAN.ToResoniteLinkField());
members.Add("UsersInContacts", UsersInContacts.ToResoniteLinkField());
members.Add("UsersInContactsPlus", UsersInContactsPlus.ToResoniteLinkField());
members.Add("UsersInRegistered", UsersInRegistered.ToResoniteLinkField());
members.Add("UsersInPublic", UsersInPublic.ToResoniteLinkField());
members.Add("GraphicalClientUsers", GraphicalClientUsers.ToResoniteLinkField());
members.Add("ChatClientUsers", ChatClientUsers.ToResoniteLinkField());
members.Add("HeadlessUsers", HeadlessUsers.ToResoniteLinkField());
members.Add("BotUsers", BotUsers.ToResoniteLinkField());
}

}
}
