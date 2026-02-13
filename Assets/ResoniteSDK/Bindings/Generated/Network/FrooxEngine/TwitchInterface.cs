
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TwitchInterface
// Generated on: pátek 13. února 2026 5:51:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TwitchInterface")]
public partial class TwitchInterface : global::FrooxEngine.Component

{
    public global::FrooxEngine.UserRef TargetUser;
public global::System.String Channel;
public global::System.Boolean Connected;
public global::System.Boolean StreamLive;
public global::System.Int32 ViewerCount;
public global::System.Single FollowTimeoutSeconds;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetUser", new ResoniteLink.SyncObject() { Members = TargetUser.CollectMembers() });
members.Add("Channel", Channel.ToResoniteLinkField());
members.Add("Connected", Connected.ToResoniteLinkField());
members.Add("StreamLive", StreamLive.ToResoniteLinkField());
members.Add("ViewerCount", ViewerCount.ToResoniteLinkField());
members.Add("FollowTimeoutSeconds", FollowTimeoutSeconds.ToResoniteLinkField());
}

}
}
