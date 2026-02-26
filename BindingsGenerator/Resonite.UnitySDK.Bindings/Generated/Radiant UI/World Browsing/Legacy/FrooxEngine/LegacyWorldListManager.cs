
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyWorldListManager
// Generated on: čtvrtek 26. února 2026 10:04:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyWorldListManager")]
public partial class LegacyWorldListManager : global::FrooxEngine.Component

{
    public global::FrooxEngine.UserRef UpdatingUser = new();
public global::FrooxEngine.LegacyWorldItem WorldItemTemplate { get => WorldItemTemplate_Element.Data; set => WorldItemTemplate_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacyWorldItem>, global::FrooxEngine.LegacyWorldItem> WorldItemTemplate_Element = new();
public System.String WorldItemType { get => WorldItemType_Element.Data; set => WorldItemType_Element.Data = value; }
public Field<global::FrooxEngine.SyncType, System.String> WorldItemType_Element = new();
public global::System.Boolean ShowOpenedWorlds { get => ShowOpenedWorlds_Element.Data; set => ShowOpenedWorlds_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowOpenedWorlds_Element = new();
public global::System.Boolean ShowSessions { get => ShowSessions_Element.Data; set => ShowSessions_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowSessions_Element = new();
public global::System.Boolean ShowPublishedWorlds { get => ShowPublishedWorlds_Element.Data; set => ShowPublishedWorlds_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowPublishedWorlds_Element = new();
public global::System.Boolean ShowLocallySavedWorlds { get => ShowLocallySavedWorlds_Element.Data; set => ShowLocallySavedWorlds_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowLocallySavedWorlds_Element = new();
public global::System.Boolean MergeSessionsByWorldId { get => MergeSessionsByWorldId_Element.Data; set => MergeSessionsByWorldId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MergeSessionsByWorldId_Element = new();
public global::System.Single IdleSortDelay { get => IdleSortDelay_Element.Data; set => IdleSortDelay_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> IdleSortDelay_Element = new();
public global::System.Single InteractingSortDelay { get => InteractingSortDelay_Element.Data; set => InteractingSortDelay_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InteractingSortDelay_Element = new();
public global::System.String SearchTerm { get => SearchTerm_Element.Data; set => SearchTerm_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> SearchTerm_Element = new();
public global::System.String SubmittedTo { get => SubmittedTo_Element.Data; set => SubmittedTo_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> SubmittedTo_Element = new();
public global::System.Boolean OnlyFeatured { get => OnlyFeatured_Element.Data; set => OnlyFeatured_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OnlyFeatured_Element = new();
public global::System.Boolean OwnWorlds { get => OwnWorlds_Element.Data; set => OwnWorlds_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OwnWorlds_Element = new();
public global::System.String ByOwner { get => ByOwner_Element.Data; set => ByOwner_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> ByOwner_Element = new();
public global::SkyFrost.Base.OwnerType OwnerType { get => OwnerType_Element.Data; set => OwnerType_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::SkyFrost.Base.OwnerType>, global::SkyFrost.Base.OwnerType> OwnerType_Element = new();
public global::System.Nullable<global::System.DateTime> MinDate { get => MinDate_Element.Data; set => MinDate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.DateTime>>, global::System.Nullable<global::System.DateTime>> MinDate_Element = new();
public global::System.Nullable<global::System.DateTime> MaxDate { get => MaxDate_Element.Data; set => MaxDate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.DateTime>>, global::System.Nullable<global::System.DateTime>> MaxDate_Element = new();
public global::System.Int32 MaxItems { get => MaxItems_Element.Data; set => MaxItems_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MaxItems_Element = new();
public global::System.Int32 SkipItems { get => SkipItems_Element.Data; set => SkipItems_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> SkipItems_Element = new();
public global::FrooxEngine.LegacyWorldListManager.EmptySessionFilter EmptySessions { get => EmptySessions_Element.Data; set => EmptySessions_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.LegacyWorldListManager.EmptySessionFilter>, global::FrooxEngine.LegacyWorldListManager.EmptySessionFilter> EmptySessions_Element = new();
public global::System.Boolean IncompatibleSessions { get => IncompatibleSessions_Element.Data; set => IncompatibleSessions_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IncompatibleSessions_Element = new();
public global::System.Boolean OnlyHeadlessHosts { get => OnlyHeadlessHosts_Element.Data; set => OnlyHeadlessHosts_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OnlyHeadlessHosts_Element = new();
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
public global::System.String ParentSessionId { get => ParentSessionId_Element.Data; set => ParentSessionId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> ParentSessionId_Element = new();
public global::System.Nullable<global::System.Boolean> Visited { get => Visited_Element.Data; set => Visited_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Boolean>>, global::System.Nullable<global::System.Boolean>> Visited_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.LegacyWorldListManager.SortProperty>, global::FrooxEngine.LegacyWorldListManager.SortProperty> SortProperties = new();
public global::System.Boolean IsSearching { get => IsSearching_Element.Data; set => IsSearching_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsSearching_Element = new();
public global::System.Boolean HasMoreResults { get => HasMoreResults_Element.Data; set => HasMoreResults_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> HasMoreResults_Element = new();
public global::System.Int32 TotalResults { get => TotalResults_Element.Data; set => TotalResults_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> TotalResults_Element = new();
public global::System.Int32 FilteredResults { get => FilteredResults_Element.Data; set => FilteredResults_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> FilteredResults_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UpdatingUser", new ResoniteLink.SyncObject() { Members = UpdatingUser.CollectMembers(context) });
members.Add("WorldItemTemplate", WorldItemTemplate_Element.Data.ToResoniteReference(context));
members.Add("WorldItemType", WorldItemType_Element.Data.ToResoniteLinkField());
members.Add("ShowOpenedWorlds", ShowOpenedWorlds_Element.Data.ToResoniteLinkField());
members.Add("ShowSessions", ShowSessions_Element.Data.ToResoniteLinkField());
members.Add("ShowPublishedWorlds", ShowPublishedWorlds_Element.Data.ToResoniteLinkField());
members.Add("ShowLocallySavedWorlds", ShowLocallySavedWorlds_Element.Data.ToResoniteLinkField());
members.Add("MergeSessionsByWorldId", MergeSessionsByWorldId_Element.Data.ToResoniteLinkField());
members.Add("IdleSortDelay", IdleSortDelay_Element.Data.ToResoniteLinkField());
members.Add("InteractingSortDelay", InteractingSortDelay_Element.Data.ToResoniteLinkField());
members.Add("SearchTerm", SearchTerm_Element.Data.ToResoniteLinkField());
members.Add("SubmittedTo", SubmittedTo_Element.Data.ToResoniteLinkField());
members.Add("OnlyFeatured", OnlyFeatured_Element.Data.ToResoniteLinkField());
members.Add("OwnWorlds", OwnWorlds_Element.Data.ToResoniteLinkField());
members.Add("ByOwner", ByOwner_Element.Data.ToResoniteLinkField());
members.Add("OwnerType", OwnerType_Element.Data.ToResoniteLinkField());
members.Add("MinDate", MinDate_Element.Data.ToResoniteLinkField());
members.Add("MaxDate", MaxDate_Element.Data.ToResoniteLinkField());
members.Add("MaxItems", MaxItems_Element.Data.ToResoniteLinkField());
members.Add("SkipItems", SkipItems_Element.Data.ToResoniteLinkField());
members.Add("EmptySessions", EmptySessions_Element.Data.ToResoniteLinkField());
members.Add("IncompatibleSessions", IncompatibleSessions_Element.Data.ToResoniteLinkField());
members.Add("OnlyHeadlessHosts", OnlyHeadlessHosts_Element.Data.ToResoniteLinkField());
members.Add("MinimumTotalUsers", MinimumTotalUsers_Element.Data.ToResoniteLinkField());
members.Add("MinimumTotalContacts", MinimumTotalContacts_Element.Data.ToResoniteLinkField());
members.Add("MinSessionAccessLevel", MinSessionAccessLevel_Element.Data.ToResoniteLinkField());
members.Add("MaxSessionAccessLevel", MaxSessionAccessLevel_Element.Data.ToResoniteLinkField());
members.Add("MinUptime", MinUptime_Element.Data.ToResoniteLinkField());
members.Add("MaxUptime", MaxUptime_Element.Data.ToResoniteLinkField());
members.Add("ParentSessionId", ParentSessionId_Element.Data.ToResoniteLinkField());
members.Add("Visited", Visited_Element.Data.ToResoniteLinkField());
members.Add("SortProperties", new ResoniteLink.SyncList()
{
    Elements = SortProperties.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("IsSearching", IsSearching_Element.Data.ToResoniteLinkField());
members.Add("HasMoreResults", HasMoreResults_Element.Data.ToResoniteLinkField());
members.Add("TotalResults", TotalResults_Element.Data.ToResoniteLinkField());
members.Add("FilteredResults", FilteredResults_Element.Data.ToResoniteLinkField());
}

}
}
