
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch.TwitchChatMessageEvent
// Generated on: čtvrtek 19. února 2026 8:00:01
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch.TwitchChatMessageEvent")]
public partial class TwitchChatMessageEvent : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch.TwitchEventsNode

{
    public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnMessage;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> Message;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> UserId;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> DisplayName;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.ColorX> Color;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsHighlighted;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsSubscriber;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsModerator;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsBroadcaster;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsTurbo;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsVIP;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::TwitchLib.Client.Enums.BadgeColor> CheerBadge;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> CheerAmount;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> Bits;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Double> BitsDollars;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> SubscribedMonthCount;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> CustomRewardId;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnMessage", OnMessage.ToResoniteReference(context));
members.Add("Message", new ResoniteLink.EmptyElement());
members.Add("UserId", new ResoniteLink.EmptyElement());
members.Add("DisplayName", new ResoniteLink.EmptyElement());
members.Add("Color", new ResoniteLink.EmptyElement());
members.Add("IsHighlighted", new ResoniteLink.EmptyElement());
members.Add("IsSubscriber", new ResoniteLink.EmptyElement());
members.Add("IsModerator", new ResoniteLink.EmptyElement());
members.Add("IsBroadcaster", new ResoniteLink.EmptyElement());
members.Add("IsTurbo", new ResoniteLink.EmptyElement());
members.Add("IsVIP", new ResoniteLink.EmptyElement());
members.Add("CheerBadge", new ResoniteLink.EmptyElement());
members.Add("CheerAmount", new ResoniteLink.EmptyElement());
members.Add("Bits", new ResoniteLink.EmptyElement());
members.Add("BitsDollars", new ResoniteLink.EmptyElement());
members.Add("SubscribedMonthCount", new ResoniteLink.EmptyElement());
members.Add("CustomRewardId", new ResoniteLink.EmptyElement());
}

}
}
