
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch.TwitchChatMessageEvent
// Generated on: čtvrtek 26. února 2026 10:04:21
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnMessage { get => OnMessage_Element.Data; set => OnMessage_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> OnMessage_Element = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> Message = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> UserId = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> DisplayName = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.ColorX> Color = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsHighlighted = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsSubscriber = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsModerator = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsBroadcaster = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsTurbo = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsVIP = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::TwitchLib.Client.Enums.BadgeColor> CheerBadge = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> CheerAmount = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> Bits = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Double> BitsDollars = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> SubscribedMonthCount = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> CustomRewardId = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnMessage", OnMessage_Element.Data.ToResoniteReference(context));
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
