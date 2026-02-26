
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch.TwitchSubscriptionEvent
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch.TwitchSubscriptionEvent")]
public partial class TwitchSubscriptionEvent : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch.TwitchEventsNode

{
    public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnSubscription { get => OnSubscription_Element.Data; set => OnSubscription_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> OnSubscription_Element = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> UserId = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> DisplayName = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> Message = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> Months = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::TwitchLib.Client.Enums.SubscriptionPlan> Plan = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsResub = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsGifted = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> GiftedBy = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsAnonymous = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnSubscription", OnSubscription_Element.ToLinkReference(context));
members.Add("UserId", UserId.ToLinkEmpty(context));
members.Add("DisplayName", DisplayName.ToLinkEmpty(context));
members.Add("Message", Message.ToLinkEmpty(context));
members.Add("Months", Months.ToLinkEmpty(context));
members.Add("Plan", Plan.ToLinkEmpty(context));
members.Add("IsResub", IsResub.ToLinkEmpty(context));
members.Add("IsGifted", IsGifted.ToLinkEmpty(context));
members.Add("GiftedBy", GiftedBy.ToLinkEmpty(context));
members.Add("IsAnonymous", IsAnonymous.ToLinkEmpty(context));
}

}
}
