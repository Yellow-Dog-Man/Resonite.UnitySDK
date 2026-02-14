
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MergedWorldDataItemInterface
// Generated on: sobota 14. února 2026 8:58:31
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MergedWorldDataItemInterface")]
public partial class MergedWorldDataItemInterface : global::FrooxEngine.FeedItemInterface

{
    public global::FrooxEngine.IField<global::System.Boolean> IsMerged;
public global::FrooxEngine.IField<global::System.Int32> SessionCount;
public global::FrooxEngine.IField<global::System.Int32> WorldCount;
public global::FrooxEngine.IField<global::System.String> MainName;
public global::FrooxEngine.IField<System.Uri> MainThumbnail;
public global::FrooxEngine.IField<global::System.String> WorldOrSessionId;
public global::FrooxEngine.IField<global::System.Int32> TotalAggregateActiveUsers;
public global::FrooxEngine.IField<global::System.Int32> TotalAggregateContacts;
public global::FrooxEngine.FeedSubTemplate<global::FrooxEngine.DataFeedEntity<global::SkyFrost.Base.SessionInfo>,global::FrooxEngine.SessionInfoItemInterface> Sessions;
public global::FrooxEngine.FeedSubTemplate<global::FrooxEngine.DataFeedEntity<global::FrooxEngine.World>,global::FrooxEngine.WorldItemInterface> Worlds;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsMerged", IsMerged.ToResoniteReference(context));
members.Add("SessionCount", SessionCount.ToResoniteReference(context));
members.Add("WorldCount", WorldCount.ToResoniteReference(context));
members.Add("MainName", MainName.ToResoniteReference(context));
members.Add("MainThumbnail", MainThumbnail.ToResoniteReference(context));
members.Add("WorldOrSessionId", WorldOrSessionId.ToResoniteReference(context));
members.Add("TotalAggregateActiveUsers", TotalAggregateActiveUsers.ToResoniteReference(context));
members.Add("TotalAggregateContacts", TotalAggregateContacts.ToResoniteReference(context));
members.Add("Sessions", new ResoniteLink.SyncObject() { Members = Sessions.CollectMembers(context) });
members.Add("Worlds", new ResoniteLink.SyncObject() { Members = Worlds.CollectMembers(context) });
}

}
}
