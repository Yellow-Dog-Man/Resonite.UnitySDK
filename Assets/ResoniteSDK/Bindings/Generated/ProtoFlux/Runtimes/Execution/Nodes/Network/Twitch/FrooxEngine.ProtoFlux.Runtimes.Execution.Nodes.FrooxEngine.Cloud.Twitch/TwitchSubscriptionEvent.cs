
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch.TwitchSubscriptionEvent
// Generated on: pátek 13. února 2026 23:22:41
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("OnSubscription", new ResoniteLink.Reference() { });
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
