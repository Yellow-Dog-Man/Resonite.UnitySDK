
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch.TwitchSubscriptionEvent
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch.TwitchSubscriptionEvent")]
public partial class TwitchSubscriptionEvent : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch.TwitchEventsNode

{
    public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnSubscription;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> UserId;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> DisplayName;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> Message;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> Months;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::TwitchLib.Client.Enums.SubscriptionPlan> Plan;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsResub;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsGifted;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> GiftedBy;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsAnonymous;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnSubscription", OnSubscription.ToResoniteReference(context));
members.Add("UserId", new ResoniteLink.EmptyElement());
members.Add("DisplayName", new ResoniteLink.EmptyElement());
members.Add("Message", new ResoniteLink.EmptyElement());
members.Add("Months", new ResoniteLink.EmptyElement());
members.Add("Plan", new ResoniteLink.EmptyElement());
members.Add("IsResub", new ResoniteLink.EmptyElement());
members.Add("IsGifted", new ResoniteLink.EmptyElement());
members.Add("GiftedBy", new ResoniteLink.EmptyElement());
members.Add("IsAnonymous", new ResoniteLink.EmptyElement());
}

}
}
