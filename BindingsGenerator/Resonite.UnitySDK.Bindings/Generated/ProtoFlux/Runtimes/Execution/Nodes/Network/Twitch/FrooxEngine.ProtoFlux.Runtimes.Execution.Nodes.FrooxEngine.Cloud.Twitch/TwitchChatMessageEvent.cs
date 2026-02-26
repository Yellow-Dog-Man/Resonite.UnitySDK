
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch.TwitchChatMessageEvent
// Generated on: čtvrtek 26. února 2026 12:27:45
// Resonite version: 2026.2.26.702
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
members.Add("OnMessage", OnMessage_Element.ToLinkReference(context));
members.Add("Message", Message.ToLinkEmpty(context));
members.Add("UserId", UserId.ToLinkEmpty(context));
members.Add("DisplayName", DisplayName.ToLinkEmpty(context));
members.Add("Color", Color.ToLinkEmpty(context));
members.Add("IsHighlighted", IsHighlighted.ToLinkEmpty(context));
members.Add("IsSubscriber", IsSubscriber.ToLinkEmpty(context));
members.Add("IsModerator", IsModerator.ToLinkEmpty(context));
members.Add("IsBroadcaster", IsBroadcaster.ToLinkEmpty(context));
members.Add("IsTurbo", IsTurbo.ToLinkEmpty(context));
members.Add("IsVIP", IsVIP.ToLinkEmpty(context));
members.Add("CheerBadge", CheerBadge.ToLinkEmpty(context));
members.Add("CheerAmount", CheerAmount.ToLinkEmpty(context));
members.Add("Bits", Bits.ToLinkEmpty(context));
members.Add("BitsDollars", BitsDollars.ToLinkEmpty(context));
members.Add("SubscribedMonthCount", SubscribedMonthCount.ToLinkEmpty(context));
members.Add("CustomRewardId", CustomRewardId.ToLinkEmpty(context));
}

}
}
