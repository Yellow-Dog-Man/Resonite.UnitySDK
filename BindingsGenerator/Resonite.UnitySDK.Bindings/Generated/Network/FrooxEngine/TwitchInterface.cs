
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TwitchInterface
// Generated on: čtvrtek 26. února 2026 10:03:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TwitchInterface")]
public partial class TwitchInterface : global::FrooxEngine.Component

{
    public global::FrooxEngine.UserRef TargetUser = new();
public global::System.String Channel { get => Channel_Element.Data; set => Channel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Channel_Element = new();
public global::System.Boolean Connected { get => Connected_Element.Data; set => Connected_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Connected_Element = new();
public global::System.Boolean StreamLive { get => StreamLive_Element.Data; set => StreamLive_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> StreamLive_Element = new();
public global::System.Int32 ViewerCount { get => ViewerCount_Element.Data; set => ViewerCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> ViewerCount_Element = new();
public global::System.Single FollowTimeoutSeconds { get => FollowTimeoutSeconds_Element.Data; set => FollowTimeoutSeconds_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FollowTimeoutSeconds_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetUser", new ResoniteLink.SyncObject() { Members = TargetUser.CollectMembers(context) });
members.Add("Channel", Channel_Element.Data.ToResoniteLinkField());
members.Add("Connected", Connected_Element.Data.ToResoniteLinkField());
members.Add("StreamLive", StreamLive_Element.Data.ToResoniteLinkField());
members.Add("ViewerCount", ViewerCount_Element.Data.ToResoniteLinkField());
members.Add("FollowTimeoutSeconds", FollowTimeoutSeconds_Element.Data.ToResoniteLinkField());
}

}
}
