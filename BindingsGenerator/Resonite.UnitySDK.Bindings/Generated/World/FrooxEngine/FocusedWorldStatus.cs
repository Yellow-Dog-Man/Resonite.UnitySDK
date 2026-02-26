
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FocusedWorldStatus
// Generated on: čtvrtek 26. února 2026 15:09:17
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::System.String WorldName { get => WorldName_Element.Data; set => WorldName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> WorldName_Element = new();
public global::System.String RawWorldName { get => RawWorldName_Element.Data; set => RawWorldName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> RawWorldName_Element = new();
public global::System.String SessionId { get => SessionId_Element.Data; set => SessionId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> SessionId_Element = new();
public global::System.Boolean IsHost { get => IsHost_Element.Data; set => IsHost_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsHost_Element = new();
public global::System.Boolean CanSave { get => CanSave_Element.Data; set => CanSave_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CanSave_Element = new();
public global::System.Boolean ShouldSave { get => ShouldSave_Element.Data; set => ShouldSave_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShouldSave_Element = new();
public global::System.Boolean CanClose { get => CanClose_Element.Data; set => CanClose_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CanClose_Element = new();
public global::System.String RoleName { get => RoleName_Element.Data; set => RoleName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> RoleName_Element = new();
public global::System.Int32 UserCount { get => UserCount_Element.Data; set => UserCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> UserCount_Element = new();
public global::System.Int32 ActiveUserCount { get => ActiveUserCount_Element.Data; set => ActiveUserCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> ActiveUserCount_Element = new();
public global::System.Int32 MaxUserCount { get => MaxUserCount_Element.Data; set => MaxUserCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MaxUserCount_Element = new();
public global::SkyFrost.Base.SessionAccessLevel AccessLevel { get => AccessLevel_Element.Data; set => AccessLevel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::SkyFrost.Base.SessionAccessLevel>, global::SkyFrost.Base.SessionAccessLevel> AccessLevel_Element = new();
public global::System.Boolean HideFromListing { get => HideFromListing_Element.Data; set => HideFromListing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> HideFromListing_Element = new();
public global::System.Boolean AwayKickEnabled { get => AwayKickEnabled_Element.Data; set => AwayKickEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AwayKickEnabled_Element = new();
public global::System.Single AwayKickMinutes { get => AwayKickMinutes_Element.Data; set => AwayKickMinutes_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AwayKickMinutes_Element = new();
public global::System.Boolean UnsafeMode { get => UnsafeMode_Element.Data; set => UnsafeMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UnsafeMode_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("WorldName", WorldName_Element.ToLinkField(context));
members.Add("RawWorldName", RawWorldName_Element.ToLinkField(context));
members.Add("SessionId", SessionId_Element.ToLinkField(context));
members.Add("IsHost", IsHost_Element.ToLinkField(context));
members.Add("CanSave", CanSave_Element.ToLinkField(context));
members.Add("ShouldSave", ShouldSave_Element.ToLinkField(context));
members.Add("CanClose", CanClose_Element.ToLinkField(context));
members.Add("RoleName", RoleName_Element.ToLinkField(context));
members.Add("UserCount", UserCount_Element.ToLinkField(context));
members.Add("ActiveUserCount", ActiveUserCount_Element.ToLinkField(context));
members.Add("MaxUserCount", MaxUserCount_Element.ToLinkField(context));
members.Add("AccessLevel", AccessLevel_Element.ToLinkField(context));
members.Add("HideFromListing", HideFromListing_Element.ToLinkField(context));
members.Add("AwayKickEnabled", AwayKickEnabled_Element.ToLinkField(context));
members.Add("AwayKickMinutes", AwayKickMinutes_Element.ToLinkField(context));
members.Add("UnsafeMode", UnsafeMode_Element.ToLinkField(context));
}

}
}
