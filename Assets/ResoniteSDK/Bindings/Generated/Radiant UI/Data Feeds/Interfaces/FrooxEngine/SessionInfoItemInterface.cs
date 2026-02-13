
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SessionInfoItemInterface
// Generated on: pátek 13. února 2026 5:52:19
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SessionInfoItemInterface")]
public partial class SessionInfoItemInterface : global::FrooxEngine.FeedItemInterface

{
    public global::FrooxEngine.IField<global::System.String> SessionName;
public global::FrooxEngine.IField<global::System.String> Description;
public global::FrooxEngine.IField<System.Uri> ThumbnailUrl;
public global::FrooxEngine.IField<global::System.String> SessionId;
public global::FrooxEngine.SyncFieldList<System.Uri> SessionURLs;
public global::FrooxEngine.IField<global::System.String> HostUserId;
public global::FrooxEngine.IField<global::System.String> HostUserSessionId;
public global::FrooxEngine.IField<global::System.String> HostMachineId;
public global::FrooxEngine.IField<global::System.String> HostUsername;
public global::FrooxEngine.IField<global::System.String> CompatibilityHash;
public global::FrooxEngine.IField<global::System.String> UniverseId;
public global::FrooxEngine.IField<global::System.String> AppVersion;
public global::FrooxEngine.IField<global::System.Boolean> IsHeadlessHost;
public global::FrooxEngine.IField<global::System.Boolean> IsOnLAN;
public global::FrooxEngine.IField<global::System.Int32> JoinedUsers;
public global::FrooxEngine.IField<global::System.Int32> ActiveUsers;
public global::FrooxEngine.IField<global::System.Int32> TotalJoinedUsers;
public global::FrooxEngine.IField<global::System.Int32> TotalActiveUsers;
public global::FrooxEngine.IField<global::System.Int32> MaximumUsers;
public global::FrooxEngine.IField<global::System.DateTime> SessionBeginTime;
public global::FrooxEngine.IField<global::System.DateTime> LastUpdate;
public global::FrooxEngine.IField<global::SkyFrost.Base.SessionAccessLevel> AccessLevel;
public global::FrooxEngine.IField<global::System.Boolean> HideFromListing;
public global::FrooxEngine.IField<global::System.Boolean> AwayKickEnabled;
public global::FrooxEngine.IField<global::System.TimeSpan> AwayKickInterval;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("SessionName", new ResoniteLink.Reference() { });
members.Add("Description", new ResoniteLink.Reference() { });
members.Add("ThumbnailUrl", new ResoniteLink.Reference() { });
members.Add("SessionId", new ResoniteLink.Reference() { });
members.Add("SessionURLs", new ResoniteLink.Reference() { });
members.Add("HostUserId", new ResoniteLink.Reference() { });
members.Add("HostUserSessionId", new ResoniteLink.Reference() { });
members.Add("HostMachineId", new ResoniteLink.Reference() { });
members.Add("HostUsername", new ResoniteLink.Reference() { });
members.Add("CompatibilityHash", new ResoniteLink.Reference() { });
members.Add("UniverseId", new ResoniteLink.Reference() { });
members.Add("AppVersion", new ResoniteLink.Reference() { });
members.Add("IsHeadlessHost", new ResoniteLink.Reference() { });
members.Add("IsOnLAN", new ResoniteLink.Reference() { });
members.Add("JoinedUsers", new ResoniteLink.Reference() { });
members.Add("ActiveUsers", new ResoniteLink.Reference() { });
members.Add("TotalJoinedUsers", new ResoniteLink.Reference() { });
members.Add("TotalActiveUsers", new ResoniteLink.Reference() { });
members.Add("MaximumUsers", new ResoniteLink.Reference() { });
members.Add("SessionBeginTime", new ResoniteLink.Reference() { });
members.Add("LastUpdate", new ResoniteLink.Reference() { });
members.Add("AccessLevel", new ResoniteLink.Reference() { });
members.Add("HideFromListing", new ResoniteLink.Reference() { });
members.Add("AwayKickEnabled", new ResoniteLink.Reference() { });
members.Add("AwayKickInterval", new ResoniteLink.Reference() { });
}

}
}
