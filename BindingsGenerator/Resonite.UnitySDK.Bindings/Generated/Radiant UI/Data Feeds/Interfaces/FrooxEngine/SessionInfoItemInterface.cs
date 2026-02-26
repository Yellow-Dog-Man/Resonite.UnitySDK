
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SessionInfoItemInterface
// Generated on: čtvrtek 26. února 2026 12:28:01
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SessionInfoItemInterface")]
public partial class SessionInfoItemInterface : global::FrooxEngine.FeedItemInterface

{
    public global::FrooxEngine.IField<global::System.String> SessionName { get => SessionName_Element.Data; set => SessionName_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> SessionName_Element = new();
public global::FrooxEngine.IField<global::System.String> Description { get => Description_Element.Data; set => Description_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> Description_Element = new();
public global::FrooxEngine.IField<System.Uri> ThumbnailUrl { get => ThumbnailUrl_Element.Data; set => ThumbnailUrl_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<System.Uri>>, global::FrooxEngine.IField<System.Uri>> ThumbnailUrl_Element = new();
public global::FrooxEngine.IField<global::System.String> SessionId { get => SessionId_Element.Data; set => SessionId_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> SessionId_Element = new();
public global::FrooxEngine.SyncFieldList<System.Uri> SessionURLs { get => SessionURLs_Element.Data; set => SessionURLs_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncFieldList<System.Uri>>, global::FrooxEngine.SyncFieldList<System.Uri>> SessionURLs_Element = new();
public global::FrooxEngine.IField<global::System.String> HostUserId { get => HostUserId_Element.Data; set => HostUserId_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> HostUserId_Element = new();
public global::FrooxEngine.IField<global::System.String> HostUserSessionId { get => HostUserSessionId_Element.Data; set => HostUserSessionId_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> HostUserSessionId_Element = new();
public global::FrooxEngine.IField<global::System.String> HostMachineId { get => HostMachineId_Element.Data; set => HostMachineId_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> HostMachineId_Element = new();
public global::FrooxEngine.IField<global::System.String> HostUsername { get => HostUsername_Element.Data; set => HostUsername_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> HostUsername_Element = new();
public global::FrooxEngine.IField<global::System.String> CompatibilityHash { get => CompatibilityHash_Element.Data; set => CompatibilityHash_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> CompatibilityHash_Element = new();
public global::FrooxEngine.IField<global::System.String> UniverseId { get => UniverseId_Element.Data; set => UniverseId_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> UniverseId_Element = new();
public global::FrooxEngine.IField<global::System.String> AppVersion { get => AppVersion_Element.Data; set => AppVersion_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> AppVersion_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> IsHeadlessHost { get => IsHeadlessHost_Element.Data; set => IsHeadlessHost_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> IsHeadlessHost_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> IsOnLAN { get => IsOnLAN_Element.Data; set => IsOnLAN_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> IsOnLAN_Element = new();
public global::FrooxEngine.IField<global::System.Int32> JoinedUsers { get => JoinedUsers_Element.Data; set => JoinedUsers_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> JoinedUsers_Element = new();
public global::FrooxEngine.IField<global::System.Int32> ActiveUsers { get => ActiveUsers_Element.Data; set => ActiveUsers_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> ActiveUsers_Element = new();
public global::FrooxEngine.IField<global::System.Int32> TotalJoinedUsers { get => TotalJoinedUsers_Element.Data; set => TotalJoinedUsers_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> TotalJoinedUsers_Element = new();
public global::FrooxEngine.IField<global::System.Int32> TotalActiveUsers { get => TotalActiveUsers_Element.Data; set => TotalActiveUsers_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> TotalActiveUsers_Element = new();
public global::FrooxEngine.IField<global::System.Int32> MaximumUsers { get => MaximumUsers_Element.Data; set => MaximumUsers_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> MaximumUsers_Element = new();
public global::FrooxEngine.IField<global::System.DateTime> SessionBeginTime { get => SessionBeginTime_Element.Data; set => SessionBeginTime_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.DateTime>>, global::FrooxEngine.IField<global::System.DateTime>> SessionBeginTime_Element = new();
public global::FrooxEngine.IField<global::System.DateTime> LastUpdate { get => LastUpdate_Element.Data; set => LastUpdate_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.DateTime>>, global::FrooxEngine.IField<global::System.DateTime>> LastUpdate_Element = new();
public global::FrooxEngine.IField<global::SkyFrost.Base.SessionAccessLevel> AccessLevel { get => AccessLevel_Element.Data; set => AccessLevel_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::SkyFrost.Base.SessionAccessLevel>>, global::FrooxEngine.IField<global::SkyFrost.Base.SessionAccessLevel>> AccessLevel_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> HideFromListing { get => HideFromListing_Element.Data; set => HideFromListing_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> HideFromListing_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> AwayKickEnabled { get => AwayKickEnabled_Element.Data; set => AwayKickEnabled_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> AwayKickEnabled_Element = new();
public global::FrooxEngine.IField<global::System.TimeSpan> AwayKickInterval { get => AwayKickInterval_Element.Data; set => AwayKickInterval_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.TimeSpan>>, global::FrooxEngine.IField<global::System.TimeSpan>> AwayKickInterval_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SessionName", SessionName_Element.ToLinkReference(context));
members.Add("Description", Description_Element.ToLinkReference(context));
members.Add("ThumbnailUrl", ThumbnailUrl_Element.ToLinkReference(context));
members.Add("SessionId", SessionId_Element.ToLinkReference(context));
members.Add("SessionURLs", SessionURLs_Element.ToLinkReference(context));
members.Add("HostUserId", HostUserId_Element.ToLinkReference(context));
members.Add("HostUserSessionId", HostUserSessionId_Element.ToLinkReference(context));
members.Add("HostMachineId", HostMachineId_Element.ToLinkReference(context));
members.Add("HostUsername", HostUsername_Element.ToLinkReference(context));
members.Add("CompatibilityHash", CompatibilityHash_Element.ToLinkReference(context));
members.Add("UniverseId", UniverseId_Element.ToLinkReference(context));
members.Add("AppVersion", AppVersion_Element.ToLinkReference(context));
members.Add("IsHeadlessHost", IsHeadlessHost_Element.ToLinkReference(context));
members.Add("IsOnLAN", IsOnLAN_Element.ToLinkReference(context));
members.Add("JoinedUsers", JoinedUsers_Element.ToLinkReference(context));
members.Add("ActiveUsers", ActiveUsers_Element.ToLinkReference(context));
members.Add("TotalJoinedUsers", TotalJoinedUsers_Element.ToLinkReference(context));
members.Add("TotalActiveUsers", TotalActiveUsers_Element.ToLinkReference(context));
members.Add("MaximumUsers", MaximumUsers_Element.ToLinkReference(context));
members.Add("SessionBeginTime", SessionBeginTime_Element.ToLinkReference(context));
members.Add("LastUpdate", LastUpdate_Element.ToLinkReference(context));
members.Add("AccessLevel", AccessLevel_Element.ToLinkReference(context));
members.Add("HideFromListing", HideFromListing_Element.ToLinkReference(context));
members.Add("AwayKickEnabled", AwayKickEnabled_Element.ToLinkReference(context));
members.Add("AwayKickInterval", AwayKickInterval_Element.ToLinkReference(context));
}

}
}
