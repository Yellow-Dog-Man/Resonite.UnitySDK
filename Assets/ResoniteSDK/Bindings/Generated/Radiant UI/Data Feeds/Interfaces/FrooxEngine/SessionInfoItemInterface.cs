
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SessionInfoItemInterface
// Generated on: úterý 24. února 2026 18:20:02
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SessionName", SessionName.ToResoniteReference(context));
members.Add("Description", Description.ToResoniteReference(context));
members.Add("ThumbnailUrl", ThumbnailUrl.ToResoniteReference(context));
members.Add("SessionId", SessionId.ToResoniteReference(context));
members.Add("SessionURLs", SessionURLs.ToResoniteReference(context));
members.Add("HostUserId", HostUserId.ToResoniteReference(context));
members.Add("HostUserSessionId", HostUserSessionId.ToResoniteReference(context));
members.Add("HostMachineId", HostMachineId.ToResoniteReference(context));
members.Add("HostUsername", HostUsername.ToResoniteReference(context));
members.Add("CompatibilityHash", CompatibilityHash.ToResoniteReference(context));
members.Add("UniverseId", UniverseId.ToResoniteReference(context));
members.Add("AppVersion", AppVersion.ToResoniteReference(context));
members.Add("IsHeadlessHost", IsHeadlessHost.ToResoniteReference(context));
members.Add("IsOnLAN", IsOnLAN.ToResoniteReference(context));
members.Add("JoinedUsers", JoinedUsers.ToResoniteReference(context));
members.Add("ActiveUsers", ActiveUsers.ToResoniteReference(context));
members.Add("TotalJoinedUsers", TotalJoinedUsers.ToResoniteReference(context));
members.Add("TotalActiveUsers", TotalActiveUsers.ToResoniteReference(context));
members.Add("MaximumUsers", MaximumUsers.ToResoniteReference(context));
members.Add("SessionBeginTime", SessionBeginTime.ToResoniteReference(context));
members.Add("LastUpdate", LastUpdate.ToResoniteReference(context));
members.Add("AccessLevel", AccessLevel.ToResoniteReference(context));
members.Add("HideFromListing", HideFromListing.ToResoniteReference(context));
members.Add("AwayKickEnabled", AwayKickEnabled.ToResoniteReference(context));
members.Add("AwayKickInterval", AwayKickInterval.ToResoniteReference(context));
}

}
}
