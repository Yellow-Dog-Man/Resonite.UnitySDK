
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch.TwitchRaidEvent
// Generated on: sobota 14. února 2026 8:58:11
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch.TwitchRaidEvent")]
public partial class TwitchRaidEvent : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch.TwitchEventsNode

{
    public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnRaid;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> UserId;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> DisplayName;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.ColorX> Color;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> ViewerCount;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsSubscriber;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnRaid", OnRaid.ToResoniteReference(context));
members.Add("UserId", new ResoniteLink.EmptyElement());
members.Add("DisplayName", new ResoniteLink.EmptyElement());
members.Add("Color", new ResoniteLink.EmptyElement());
members.Add("ViewerCount", new ResoniteLink.EmptyElement());
members.Add("IsSubscriber", new ResoniteLink.EmptyElement());
}

}
}
