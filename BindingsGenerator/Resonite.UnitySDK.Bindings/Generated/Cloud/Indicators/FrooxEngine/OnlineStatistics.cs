
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OnlineStatistics
// Generated on: čtvrtek 26. února 2026 10:03:37
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.OnlineStatistics")]
public partial class OnlineStatistics : global::FrooxEngine.Component

{
    public global::System.DateTime Timestamp { get => Timestamp_Element.Data; set => Timestamp_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.DateTime>, global::System.DateTime> Timestamp_Element = new();
public global::FrooxEngine.OnlineStatistics.SessionStats VisibleSessions = new();
public global::FrooxEngine.OnlineStatistics.SessionStats HiddenSessions = new();
public global::FrooxEngine.OnlineStatistics.SessionStats ActiveVisibleSessions = new();
public global::FrooxEngine.OnlineStatistics.SessionStats ActiveHiddenSessions = new();
public global::System.Nullable<global::System.Int32> RegisteredOnlineUsers { get => RegisteredOnlineUsers_Element.Data; set => RegisteredOnlineUsers_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> RegisteredOnlineUsers_Element = new();
public global::System.Nullable<global::System.Int32> TotalOnlineUsers { get => TotalOnlineUsers_Element.Data; set => TotalOnlineUsers_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> TotalOnlineUsers_Element = new();
public global::System.Nullable<global::System.Int32> PresentUsers { get => PresentUsers_Element.Data; set => PresentUsers_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> PresentUsers_Element = new();
public global::System.Nullable<global::System.Int32> AwayUsers { get => AwayUsers_Element.Data; set => AwayUsers_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> AwayUsers_Element = new();
public global::System.Nullable<global::System.Int32> UsersInVR { get => UsersInVR_Element.Data; set => UsersInVR_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> UsersInVR_Element = new();
public global::System.Nullable<global::System.Int32> UsersInScreen { get => UsersInScreen_Element.Data; set => UsersInScreen_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> UsersInScreen_Element = new();
public global::System.Nullable<global::System.Int32> UsersOnDesktop { get => UsersOnDesktop_Element.Data; set => UsersOnDesktop_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> UsersOnDesktop_Element = new();
public global::System.Nullable<global::System.Int32> UsersOnMobile { get => UsersOnMobile_Element.Data; set => UsersOnMobile_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> UsersOnMobile_Element = new();
public global::System.Nullable<global::System.Int32> UsersInVisiblePublicSessions { get => UsersInVisiblePublicSessions_Element.Data; set => UsersInVisiblePublicSessions_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> UsersInVisiblePublicSessions_Element = new();
public global::System.Nullable<global::System.Int32> UsersInVisibleSemiAccessibleSessions { get => UsersInVisibleSemiAccessibleSessions_Element.Data; set => UsersInVisibleSemiAccessibleSessions_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> UsersInVisibleSemiAccessibleSessions_Element = new();
public global::System.Nullable<global::System.Int32> UsersInHiddenSessions { get => UsersInHiddenSessions_Element.Data; set => UsersInHiddenSessions_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> UsersInHiddenSessions_Element = new();
public global::System.Nullable<global::System.Int32> UsersInPrivateSessions { get => UsersInPrivateSessions_Element.Data; set => UsersInPrivateSessions_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> UsersInPrivateSessions_Element = new();
public global::System.Nullable<global::System.Int32> UsersInPrivate { get => UsersInPrivate_Element.Data; set => UsersInPrivate_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> UsersInPrivate_Element = new();
public global::System.Nullable<global::System.Int32> UsersInLAN { get => UsersInLAN_Element.Data; set => UsersInLAN_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> UsersInLAN_Element = new();
public global::System.Nullable<global::System.Int32> UsersInContacts { get => UsersInContacts_Element.Data; set => UsersInContacts_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> UsersInContacts_Element = new();
public global::System.Nullable<global::System.Int32> UsersInContactsPlus { get => UsersInContactsPlus_Element.Data; set => UsersInContactsPlus_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> UsersInContactsPlus_Element = new();
public global::System.Nullable<global::System.Int32> UsersInRegistered { get => UsersInRegistered_Element.Data; set => UsersInRegistered_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> UsersInRegistered_Element = new();
public global::System.Nullable<global::System.Int32> UsersInPublic { get => UsersInPublic_Element.Data; set => UsersInPublic_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> UsersInPublic_Element = new();
public global::System.Nullable<global::System.Int32> GraphicalClientUsers { get => GraphicalClientUsers_Element.Data; set => GraphicalClientUsers_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> GraphicalClientUsers_Element = new();
public global::System.Nullable<global::System.Int32> ChatClientUsers { get => ChatClientUsers_Element.Data; set => ChatClientUsers_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> ChatClientUsers_Element = new();
public global::System.Nullable<global::System.Int32> HeadlessUsers { get => HeadlessUsers_Element.Data; set => HeadlessUsers_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> HeadlessUsers_Element = new();
public global::System.Nullable<global::System.Int32> BotUsers { get => BotUsers_Element.Data; set => BotUsers_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> BotUsers_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Timestamp", Timestamp_Element.Data.ToResoniteLinkField());
members.Add("VisibleSessions", new ResoniteLink.SyncObject() { Members = VisibleSessions.CollectMembers(context) });
members.Add("HiddenSessions", new ResoniteLink.SyncObject() { Members = HiddenSessions.CollectMembers(context) });
members.Add("ActiveVisibleSessions", new ResoniteLink.SyncObject() { Members = ActiveVisibleSessions.CollectMembers(context) });
members.Add("ActiveHiddenSessions", new ResoniteLink.SyncObject() { Members = ActiveHiddenSessions.CollectMembers(context) });
members.Add("RegisteredOnlineUsers", RegisteredOnlineUsers_Element.Data.ToResoniteLinkField());
members.Add("TotalOnlineUsers", TotalOnlineUsers_Element.Data.ToResoniteLinkField());
members.Add("PresentUsers", PresentUsers_Element.Data.ToResoniteLinkField());
members.Add("AwayUsers", AwayUsers_Element.Data.ToResoniteLinkField());
members.Add("UsersInVR", UsersInVR_Element.Data.ToResoniteLinkField());
members.Add("UsersInScreen", UsersInScreen_Element.Data.ToResoniteLinkField());
members.Add("UsersOnDesktop", UsersOnDesktop_Element.Data.ToResoniteLinkField());
members.Add("UsersOnMobile", UsersOnMobile_Element.Data.ToResoniteLinkField());
members.Add("UsersInVisiblePublicSessions", UsersInVisiblePublicSessions_Element.Data.ToResoniteLinkField());
members.Add("UsersInVisibleSemiAccessibleSessions", UsersInVisibleSemiAccessibleSessions_Element.Data.ToResoniteLinkField());
members.Add("UsersInHiddenSessions", UsersInHiddenSessions_Element.Data.ToResoniteLinkField());
members.Add("UsersInPrivateSessions", UsersInPrivateSessions_Element.Data.ToResoniteLinkField());
members.Add("UsersInPrivate", UsersInPrivate_Element.Data.ToResoniteLinkField());
members.Add("UsersInLAN", UsersInLAN_Element.Data.ToResoniteLinkField());
members.Add("UsersInContacts", UsersInContacts_Element.Data.ToResoniteLinkField());
members.Add("UsersInContactsPlus", UsersInContactsPlus_Element.Data.ToResoniteLinkField());
members.Add("UsersInRegistered", UsersInRegistered_Element.Data.ToResoniteLinkField());
members.Add("UsersInPublic", UsersInPublic_Element.Data.ToResoniteLinkField());
members.Add("GraphicalClientUsers", GraphicalClientUsers_Element.Data.ToResoniteLinkField());
members.Add("ChatClientUsers", ChatClientUsers_Element.Data.ToResoniteLinkField());
members.Add("HeadlessUsers", HeadlessUsers_Element.Data.ToResoniteLinkField());
members.Add("BotUsers", BotUsers_Element.Data.ToResoniteLinkField());
}

}
}
