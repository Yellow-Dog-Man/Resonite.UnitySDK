
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldsDataFeed
// Generated on: středa 25. února 2026 16:14:14
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldsDataFeed")]
public partial class WorldsDataFeed : global::FrooxEngine.Component, global::FrooxEngine.IDataFeedComponent, global::FrooxEngine.IDataFeed

{
    public global::System.Boolean ListOpenedWorlds;
public global::System.Boolean ListSessions;
public global::System.Boolean MergeByWorldId;
public global::System.Boolean MergeBySessionId;
public global::System.Boolean IncompatibleSessions;
public global::System.Boolean HeadlessHosts;
public global::System.Boolean UserHosts;
public global::System.Int32 MinimumTotalUsers;
public global::System.Int32 MinimumTotalContacts;
public global::SkyFrost.Base.SessionAccessLevel MinSessionAccessLevel;
public global::SkyFrost.Base.SessionAccessLevel MaxSessionAccessLevel;
public global::System.Double MinUptime;
public global::System.Double MaxUptime;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ListOpenedWorlds", ListOpenedWorlds.ToResoniteLinkField());
members.Add("ListSessions", ListSessions.ToResoniteLinkField());
members.Add("MergeByWorldId", MergeByWorldId.ToResoniteLinkField());
members.Add("MergeBySessionId", MergeBySessionId.ToResoniteLinkField());
members.Add("IncompatibleSessions", IncompatibleSessions.ToResoniteLinkField());
members.Add("HeadlessHosts", HeadlessHosts.ToResoniteLinkField());
members.Add("UserHosts", UserHosts.ToResoniteLinkField());
members.Add("MinimumTotalUsers", MinimumTotalUsers.ToResoniteLinkField());
members.Add("MinimumTotalContacts", MinimumTotalContacts.ToResoniteLinkField());
members.Add("MinSessionAccessLevel", MinSessionAccessLevel.ToResoniteLinkField());
members.Add("MaxSessionAccessLevel", MaxSessionAccessLevel.ToResoniteLinkField());
members.Add("MinUptime", MinUptime.ToResoniteLinkField());
members.Add("MaxUptime", MaxUptime.ToResoniteLinkField());
}

}
}
