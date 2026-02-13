
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MergedWorldDataItemInterface
// Generated on: pátek 13. února 2026 23:23:02
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("IsMerged", new ResoniteLink.Reference() { });
members.Add("SessionCount", new ResoniteLink.Reference() { });
members.Add("WorldCount", new ResoniteLink.Reference() { });
members.Add("MainName", new ResoniteLink.Reference() { });
members.Add("MainThumbnail", new ResoniteLink.Reference() { });
members.Add("WorldOrSessionId", new ResoniteLink.Reference() { });
members.Add("TotalAggregateActiveUsers", new ResoniteLink.Reference() { });
members.Add("TotalAggregateContacts", new ResoniteLink.Reference() { });
members.Add("Sessions", new ResoniteLink.SyncObject() { Members = Sessions.CollectMembers() });
members.Add("Worlds", new ResoniteLink.SyncObject() { Members = Worlds.CollectMembers() });
}

}
}
