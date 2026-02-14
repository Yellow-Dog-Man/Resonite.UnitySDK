
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyWorldListManager
// Generated on: sobota 14. února 2026 8:58:32
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyWorldListManager")]
public partial class LegacyWorldListManager : global::FrooxEngine.Component

{
    public global::FrooxEngine.UserRef UpdatingUser;
public global::FrooxEngine.LegacyWorldItem WorldItemTemplate;
public System.String WorldItemType;
public global::System.Boolean ShowOpenedWorlds;
public global::System.Boolean ShowSessions;
public global::System.Boolean ShowPublishedWorlds;
public global::System.Boolean ShowLocallySavedWorlds;
public global::System.Boolean MergeSessionsByWorldId;
public global::System.Single IdleSortDelay;
public global::System.Single InteractingSortDelay;
public global::System.String SearchTerm;
public global::System.String SubmittedTo;
public global::System.Boolean OnlyFeatured;
public global::System.Boolean OwnWorlds;
public global::System.String ByOwner;
public global::SkyFrost.Base.OwnerType OwnerType;
public global::System.Nullable<global::System.DateTime> MinDate;
public global::System.Nullable<global::System.DateTime> MaxDate;
public global::System.Int32 MaxItems;
public global::System.Int32 SkipItems;
public global::FrooxEngine.LegacyWorldListManager.EmptySessionFilter EmptySessions;
public global::System.Boolean IncompatibleSessions;
public global::System.Boolean OnlyHeadlessHosts;
public global::System.Int32 MinimumTotalUsers;
public global::System.Int32 MinimumTotalContacts;
public global::SkyFrost.Base.SessionAccessLevel MinSessionAccessLevel;
public global::SkyFrost.Base.SessionAccessLevel MaxSessionAccessLevel;
public global::System.Double MinUptime;
public global::System.Double MaxUptime;
public global::System.String ParentSessionId;
public global::System.Nullable<global::System.Boolean> Visited;
public System.Collections.Generic.List<global::FrooxEngine.LegacyWorldListManager.SortProperty> SortProperties;
public global::System.Boolean IsSearching;
public global::System.Boolean HasMoreResults;
public global::System.Int32 TotalResults;
public global::System.Int32 FilteredResults;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UpdatingUser", new ResoniteLink.SyncObject() { Members = UpdatingUser.CollectMembers(context) });
members.Add("WorldItemTemplate", WorldItemTemplate.ToResoniteReference(context));
members.Add("WorldItemType", WorldItemType.ToResoniteLinkField());
members.Add("ShowOpenedWorlds", ShowOpenedWorlds.ToResoniteLinkField());
members.Add("ShowSessions", ShowSessions.ToResoniteLinkField());
members.Add("ShowPublishedWorlds", ShowPublishedWorlds.ToResoniteLinkField());
members.Add("ShowLocallySavedWorlds", ShowLocallySavedWorlds.ToResoniteLinkField());
members.Add("MergeSessionsByWorldId", MergeSessionsByWorldId.ToResoniteLinkField());
members.Add("IdleSortDelay", IdleSortDelay.ToResoniteLinkField());
members.Add("InteractingSortDelay", InteractingSortDelay.ToResoniteLinkField());
members.Add("SearchTerm", SearchTerm.ToResoniteLinkField());
members.Add("SubmittedTo", SubmittedTo.ToResoniteLinkField());
members.Add("OnlyFeatured", OnlyFeatured.ToResoniteLinkField());
members.Add("OwnWorlds", OwnWorlds.ToResoniteLinkField());
members.Add("ByOwner", ByOwner.ToResoniteLinkField());
members.Add("OwnerType", OwnerType.ToResoniteLinkField());
members.Add("MinDate", MinDate.ToResoniteLinkField());
members.Add("MaxDate", MaxDate.ToResoniteLinkField());
members.Add("MaxItems", MaxItems.ToResoniteLinkField());
members.Add("SkipItems", SkipItems.ToResoniteLinkField());
members.Add("EmptySessions", EmptySessions.ToResoniteLinkField());
members.Add("IncompatibleSessions", IncompatibleSessions.ToResoniteLinkField());
members.Add("OnlyHeadlessHosts", OnlyHeadlessHosts.ToResoniteLinkField());
members.Add("MinimumTotalUsers", MinimumTotalUsers.ToResoniteLinkField());
members.Add("MinimumTotalContacts", MinimumTotalContacts.ToResoniteLinkField());
members.Add("MinSessionAccessLevel", MinSessionAccessLevel.ToResoniteLinkField());
members.Add("MaxSessionAccessLevel", MaxSessionAccessLevel.ToResoniteLinkField());
members.Add("MinUptime", MinUptime.ToResoniteLinkField());
members.Add("MaxUptime", MaxUptime.ToResoniteLinkField());
members.Add("ParentSessionId", ParentSessionId.ToResoniteLinkField());
members.Add("Visited", Visited.ToResoniteLinkField());
members.Add("SortProperties", new ResoniteLink.SyncList()
{
    Elements = SortProperties.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("IsSearching", IsSearching.ToResoniteLinkField());
members.Add("HasMoreResults", HasMoreResults.ToResoniteLinkField());
members.Add("TotalResults", TotalResults.ToResoniteLinkField());
members.Add("FilteredResults", FilteredResults.ToResoniteLinkField());
}

}
}
