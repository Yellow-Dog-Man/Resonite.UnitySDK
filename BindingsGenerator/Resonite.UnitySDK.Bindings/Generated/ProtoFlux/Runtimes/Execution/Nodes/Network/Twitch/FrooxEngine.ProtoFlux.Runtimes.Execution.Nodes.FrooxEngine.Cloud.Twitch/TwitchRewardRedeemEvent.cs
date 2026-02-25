
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch.TwitchRewardRedeemEvent
// Generated on: středa 25. února 2026 16:13:55
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch.TwitchRewardRedeemEvent")]
public partial class TwitchRewardRedeemEvent : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch.TwitchEventsNode

{
    public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnRedeem;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> DisplayName;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> Message;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.DateTime> TimeStamp;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> RewardId;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> RewardTitle;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> RewardPrompt;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> Status;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> RewardCost;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnRedeem", OnRedeem.ToResoniteReference(context));
members.Add("DisplayName", new ResoniteLink.EmptyElement());
members.Add("Message", new ResoniteLink.EmptyElement());
members.Add("TimeStamp", new ResoniteLink.EmptyElement());
members.Add("RewardId", new ResoniteLink.EmptyElement());
members.Add("RewardTitle", new ResoniteLink.EmptyElement());
members.Add("RewardPrompt", new ResoniteLink.EmptyElement());
members.Add("Status", new ResoniteLink.EmptyElement());
members.Add("RewardCost", new ResoniteLink.EmptyElement());
}

}
}
