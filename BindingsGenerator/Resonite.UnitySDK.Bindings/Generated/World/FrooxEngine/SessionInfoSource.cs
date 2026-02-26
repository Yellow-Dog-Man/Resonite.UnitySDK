
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SessionInfoSource
// Generated on: čtvrtek 26. února 2026 12:28:16
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SessionInfoSource")]
public partial class SessionInfoSource : global::FrooxEngine.Component, global::FrooxEngine.IWorldLink

{
    public global::System.String SessionId { get => SessionId_Element.Data; set => SessionId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> SessionId_Element = new();
public global::System.Boolean IsOpen { get => IsOpen_Element.Data; set => IsOpen_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsOpen_Element = new();
public global::System.DateTime LastUpdated { get => LastUpdated_Element.Data; set => LastUpdated_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.DateTime>, global::System.DateTime> LastUpdated_Element = new();
public global::System.String Name { get => Name_Element.Data; set => Name_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Name_Element = new();
public global::System.String Description { get => Description_Element.Data; set => Description_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Description_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::System.String>, global::System.String, Field<global::FrooxEngine.Sync<global::System.String>, global::System.String>> Tags = new();
public global::System.String CorrespondingRecordId { get => CorrespondingRecordId_Element.Data; set => CorrespondingRecordId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> CorrespondingRecordId_Element = new();
public global::System.String CorrespondingOwnerId { get => CorrespondingOwnerId_Element.Data; set => CorrespondingOwnerId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> CorrespondingOwnerId_Element = new();
public global::System.String HostUserId { get => HostUserId_Element.Data; set => HostUserId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> HostUserId_Element = new();
public global::System.String HostUsername { get => HostUsername_Element.Data; set => HostUsername_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> HostUsername_Element = new();
public global::System.String SanitizedHostUsername { get => SanitizedHostUsername_Element.Data; set => SanitizedHostUsername_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> SanitizedHostUsername_Element = new();
public global::System.String AppVersion { get => AppVersion_Element.Data; set => AppVersion_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> AppVersion_Element = new();
public global::System.Boolean HeadlessHost { get => HeadlessHost_Element.Data; set => HeadlessHost_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> HeadlessHost_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::System.String>, global::System.String, Field<global::FrooxEngine.Sync<global::System.String>, global::System.String>> SessionURLs = new();
public global::System.String Thumbnail { get => Thumbnail_Element.Data; set => Thumbnail_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Thumbnail_Element = new();
public global::System.Int32 JoinedUsers { get => JoinedUsers_Element.Data; set => JoinedUsers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> JoinedUsers_Element = new();
public global::System.Int32 ActiveUsers { get => ActiveUsers_Element.Data; set => ActiveUsers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> ActiveUsers_Element = new();
public global::System.Int32 TotalJoinedUsers { get => TotalJoinedUsers_Element.Data; set => TotalJoinedUsers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> TotalJoinedUsers_Element = new();
public global::System.Int32 TotalActiveUsers { get => TotalActiveUsers_Element.Data; set => TotalActiveUsers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> TotalActiveUsers_Element = new();
public global::System.Int32 MaximumUsers { get => MaximumUsers_Element.Data; set => MaximumUsers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MaximumUsers_Element = new();
public global::System.Boolean MobileFriendly { get => MobileFriendly_Element.Data; set => MobileFriendly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MobileFriendly_Element = new();
public global::SkyFrost.Base.SessionAccessLevel AccessLevel { get => AccessLevel_Element.Data; set => AccessLevel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::SkyFrost.Base.SessionAccessLevel>, global::SkyFrost.Base.SessionAccessLevel> AccessLevel_Element = new();
public global::System.Boolean IsOnLAN { get => IsOnLAN_Element.Data; set => IsOnLAN_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsOnLAN_Element = new();
public global::System.Boolean AwayKickEnabled { get => AwayKickEnabled_Element.Data; set => AwayKickEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AwayKickEnabled_Element = new();
public global::System.TimeSpan AwayKickInterval { get => AwayKickInterval_Element.Data; set => AwayKickInterval_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.TimeSpan>, global::System.TimeSpan> AwayKickInterval_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SessionId", SessionId_Element.ToLinkField(context));
members.Add("IsOpen", IsOpen_Element.ToLinkField(context));
members.Add("LastUpdated", LastUpdated_Element.ToLinkField(context));
members.Add("Name", Name_Element.ToLinkField(context));
members.Add("Description", Description_Element.ToLinkField(context));
members.Add("Tags", Tags.ToLinkList(context, m => m.ToLinkField(context)));
members.Add("CorrespondingRecordId", CorrespondingRecordId_Element.ToLinkField(context));
members.Add("CorrespondingOwnerId", CorrespondingOwnerId_Element.ToLinkField(context));
members.Add("HostUserId", HostUserId_Element.ToLinkField(context));
members.Add("HostUsername", HostUsername_Element.ToLinkField(context));
members.Add("SanitizedHostUsername", SanitizedHostUsername_Element.ToLinkField(context));
members.Add("AppVersion", AppVersion_Element.ToLinkField(context));
members.Add("HeadlessHost", HeadlessHost_Element.ToLinkField(context));
members.Add("SessionURLs", SessionURLs.ToLinkList(context, m => m.ToLinkField(context)));
members.Add("Thumbnail", Thumbnail_Element.ToLinkField(context));
members.Add("JoinedUsers", JoinedUsers_Element.ToLinkField(context));
members.Add("ActiveUsers", ActiveUsers_Element.ToLinkField(context));
members.Add("TotalJoinedUsers", TotalJoinedUsers_Element.ToLinkField(context));
members.Add("TotalActiveUsers", TotalActiveUsers_Element.ToLinkField(context));
members.Add("MaximumUsers", MaximumUsers_Element.ToLinkField(context));
members.Add("MobileFriendly", MobileFriendly_Element.ToLinkField(context));
members.Add("AccessLevel", AccessLevel_Element.ToLinkField(context));
members.Add("IsOnLAN", IsOnLAN_Element.ToLinkField(context));
members.Add("AwayKickEnabled", AwayKickEnabled_Element.ToLinkField(context));
members.Add("AwayKickInterval", AwayKickInterval_Element.ToLinkField(context));
}

}
}
