
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TwitchInterface
// Generated on: středa 25. února 2026 16:13:11
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
    public global::FrooxEngine.UserRef TargetUser;
public global::System.String Channel;
public global::System.Boolean Connected;
public global::System.Boolean StreamLive;
public global::System.Int32 ViewerCount;
public global::System.Single FollowTimeoutSeconds;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetUser", new ResoniteLink.SyncObject() { Members = TargetUser.CollectMembers(context) });
members.Add("Channel", Channel.ToResoniteLinkField());
members.Add("Connected", Connected.ToResoniteLinkField());
members.Add("StreamLive", StreamLive.ToResoniteLinkField());
members.Add("ViewerCount", ViewerCount.ToResoniteLinkField());
members.Add("FollowTimeoutSeconds", FollowTimeoutSeconds.ToResoniteLinkField());
}

}
}
