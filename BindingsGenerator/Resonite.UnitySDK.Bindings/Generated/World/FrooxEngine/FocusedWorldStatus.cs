
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FocusedWorldStatus
// Generated on: středa 25. února 2026 16:14:47
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FocusedWorldStatus")]
public partial class FocusedWorldStatus : global::FrooxEngine.Component

{
    public global::System.String WorldName;
public global::System.String RawWorldName;
public global::System.String SessionId;
public global::System.Boolean IsHost;
public global::System.Boolean CanSave;
public global::System.Boolean ShouldSave;
public global::System.Boolean CanClose;
public global::System.String RoleName;
public global::System.Int32 UserCount;
public global::System.Int32 ActiveUserCount;
public global::System.Int32 MaxUserCount;
public global::SkyFrost.Base.SessionAccessLevel AccessLevel;
public global::System.Boolean HideFromListing;
public global::System.Boolean AwayKickEnabled;
public global::System.Single AwayKickMinutes;
public global::System.Boolean UnsafeMode;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("WorldName", WorldName.ToResoniteLinkField());
members.Add("RawWorldName", RawWorldName.ToResoniteLinkField());
members.Add("SessionId", SessionId.ToResoniteLinkField());
members.Add("IsHost", IsHost.ToResoniteLinkField());
members.Add("CanSave", CanSave.ToResoniteLinkField());
members.Add("ShouldSave", ShouldSave.ToResoniteLinkField());
members.Add("CanClose", CanClose.ToResoniteLinkField());
members.Add("RoleName", RoleName.ToResoniteLinkField());
members.Add("UserCount", UserCount.ToResoniteLinkField());
members.Add("ActiveUserCount", ActiveUserCount.ToResoniteLinkField());
members.Add("MaxUserCount", MaxUserCount.ToResoniteLinkField());
members.Add("AccessLevel", AccessLevel.ToResoniteLinkField());
members.Add("HideFromListing", HideFromListing.ToResoniteLinkField());
members.Add("AwayKickEnabled", AwayKickEnabled.ToResoniteLinkField());
members.Add("AwayKickMinutes", AwayKickMinutes.ToResoniteLinkField());
members.Add("UnsafeMode", UnsafeMode.ToResoniteLinkField());
}

}
}
