
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SessionInfoSource
// Generated on: pátek 13. února 2026 5:52:40
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SessionInfoSource")]
public partial class SessionInfoSource : global::FrooxEngine.Component, global::FrooxEngine.IWorldLink

{
    public global::System.String SessionId;
public global::System.Boolean IsOpen;
public global::System.DateTime LastUpdated;
public global::System.String Name;
public global::System.String Description;
public System.Collections.Generic.List<global::System.String> Tags;
public global::System.String CorrespondingRecordId;
public global::System.String CorrespondingOwnerId;
public global::System.String HostUserId;
public global::System.String HostUsername;
public global::System.String SanitizedHostUsername;
public global::System.String AppVersion;
public global::System.Boolean HeadlessHost;
public System.Collections.Generic.List<global::System.String> SessionURLs;
public global::System.String Thumbnail;
public global::System.Int32 JoinedUsers;
public global::System.Int32 ActiveUsers;
public global::System.Int32 TotalJoinedUsers;
public global::System.Int32 TotalActiveUsers;
public global::System.Int32 MaximumUsers;
public global::System.Boolean MobileFriendly;
public global::SkyFrost.Base.SessionAccessLevel AccessLevel;
public global::System.Boolean IsOnLAN;
public global::System.Boolean AwayKickEnabled;
public global::System.TimeSpan AwayKickInterval;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("SessionId", SessionId.ToResoniteLinkField());
members.Add("IsOpen", IsOpen.ToResoniteLinkField());
members.Add("LastUpdated", LastUpdated.ToResoniteLinkField());
members.Add("Name", Name.ToResoniteLinkField());
members.Add("Description", Description.ToResoniteLinkField());
members.Add("Tags", new ResoniteLink.SyncList()
{
    Elements = Tags.Select(m => m.ToResoniteLinkField()).ToList<ResoniteLink.Member>()
});
members.Add("CorrespondingRecordId", CorrespondingRecordId.ToResoniteLinkField());
members.Add("CorrespondingOwnerId", CorrespondingOwnerId.ToResoniteLinkField());
members.Add("HostUserId", HostUserId.ToResoniteLinkField());
members.Add("HostUsername", HostUsername.ToResoniteLinkField());
members.Add("SanitizedHostUsername", SanitizedHostUsername.ToResoniteLinkField());
members.Add("AppVersion", AppVersion.ToResoniteLinkField());
members.Add("HeadlessHost", HeadlessHost.ToResoniteLinkField());
members.Add("SessionURLs", new ResoniteLink.SyncList()
{
    Elements = SessionURLs.Select(m => m.ToResoniteLinkField()).ToList<ResoniteLink.Member>()
});
members.Add("Thumbnail", Thumbnail.ToResoniteLinkField());
members.Add("JoinedUsers", JoinedUsers.ToResoniteLinkField());
members.Add("ActiveUsers", ActiveUsers.ToResoniteLinkField());
members.Add("TotalJoinedUsers", TotalJoinedUsers.ToResoniteLinkField());
members.Add("TotalActiveUsers", TotalActiveUsers.ToResoniteLinkField());
members.Add("MaximumUsers", MaximumUsers.ToResoniteLinkField());
members.Add("MobileFriendly", MobileFriendly.ToResoniteLinkField());
members.Add("AccessLevel", AccessLevel.ToResoniteLinkField());
members.Add("IsOnLAN", IsOnLAN.ToResoniteLinkField());
members.Add("AwayKickEnabled", AwayKickEnabled.ToResoniteLinkField());
members.Add("AwayKickInterval", AwayKickInterval.ToResoniteLinkField());
}

}
}
