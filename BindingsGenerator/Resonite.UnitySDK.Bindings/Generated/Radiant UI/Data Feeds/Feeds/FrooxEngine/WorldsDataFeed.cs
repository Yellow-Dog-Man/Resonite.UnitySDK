
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldsDataFeed
// Generated on: čtvrtek 26. února 2026 10:04:35
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
    public global::System.Boolean ListOpenedWorlds { get => ListOpenedWorlds_Element.Data; set => ListOpenedWorlds_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ListOpenedWorlds_Element = new();
public global::System.Boolean ListSessions { get => ListSessions_Element.Data; set => ListSessions_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ListSessions_Element = new();
public global::System.Boolean MergeByWorldId { get => MergeByWorldId_Element.Data; set => MergeByWorldId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MergeByWorldId_Element = new();
public global::System.Boolean MergeBySessionId { get => MergeBySessionId_Element.Data; set => MergeBySessionId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MergeBySessionId_Element = new();
public global::System.Boolean IncompatibleSessions { get => IncompatibleSessions_Element.Data; set => IncompatibleSessions_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IncompatibleSessions_Element = new();
public global::System.Boolean HeadlessHosts { get => HeadlessHosts_Element.Data; set => HeadlessHosts_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> HeadlessHosts_Element = new();
public global::System.Boolean UserHosts { get => UserHosts_Element.Data; set => UserHosts_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UserHosts_Element = new();
public global::System.Int32 MinimumTotalUsers { get => MinimumTotalUsers_Element.Data; set => MinimumTotalUsers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MinimumTotalUsers_Element = new();
public global::System.Int32 MinimumTotalContacts { get => MinimumTotalContacts_Element.Data; set => MinimumTotalContacts_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MinimumTotalContacts_Element = new();
public global::SkyFrost.Base.SessionAccessLevel MinSessionAccessLevel { get => MinSessionAccessLevel_Element.Data; set => MinSessionAccessLevel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::SkyFrost.Base.SessionAccessLevel>, global::SkyFrost.Base.SessionAccessLevel> MinSessionAccessLevel_Element = new();
public global::SkyFrost.Base.SessionAccessLevel MaxSessionAccessLevel { get => MaxSessionAccessLevel_Element.Data; set => MaxSessionAccessLevel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::SkyFrost.Base.SessionAccessLevel>, global::SkyFrost.Base.SessionAccessLevel> MaxSessionAccessLevel_Element = new();
public global::System.Double MinUptime { get => MinUptime_Element.Data; set => MinUptime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Double>, global::System.Double> MinUptime_Element = new();
public global::System.Double MaxUptime { get => MaxUptime_Element.Data; set => MaxUptime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Double>, global::System.Double> MaxUptime_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ListOpenedWorlds", ListOpenedWorlds_Element.Data.ToResoniteLinkField());
members.Add("ListSessions", ListSessions_Element.Data.ToResoniteLinkField());
members.Add("MergeByWorldId", MergeByWorldId_Element.Data.ToResoniteLinkField());
members.Add("MergeBySessionId", MergeBySessionId_Element.Data.ToResoniteLinkField());
members.Add("IncompatibleSessions", IncompatibleSessions_Element.Data.ToResoniteLinkField());
members.Add("HeadlessHosts", HeadlessHosts_Element.Data.ToResoniteLinkField());
members.Add("UserHosts", UserHosts_Element.Data.ToResoniteLinkField());
members.Add("MinimumTotalUsers", MinimumTotalUsers_Element.Data.ToResoniteLinkField());
members.Add("MinimumTotalContacts", MinimumTotalContacts_Element.Data.ToResoniteLinkField());
members.Add("MinSessionAccessLevel", MinSessionAccessLevel_Element.Data.ToResoniteLinkField());
members.Add("MaxSessionAccessLevel", MaxSessionAccessLevel_Element.Data.ToResoniteLinkField());
members.Add("MinUptime", MinUptime_Element.Data.ToResoniteLinkField());
members.Add("MaxUptime", MaxUptime_Element.Data.ToResoniteLinkField());
}

}
}
