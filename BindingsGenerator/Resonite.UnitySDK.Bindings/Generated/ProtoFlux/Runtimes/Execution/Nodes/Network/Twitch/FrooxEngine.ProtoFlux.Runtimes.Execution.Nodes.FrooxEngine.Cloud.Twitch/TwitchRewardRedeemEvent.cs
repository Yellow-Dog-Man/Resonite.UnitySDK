
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch.TwitchRewardRedeemEvent
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch.TwitchRewardRedeemEvent")]
public partial class TwitchRewardRedeemEvent : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch.TwitchEventsNode

{
    public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnRedeem { get => OnRedeem_Element.Data; set => OnRedeem_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> OnRedeem_Element = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> DisplayName = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> Message = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.DateTime> TimeStamp = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> RewardId = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> RewardTitle = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> RewardPrompt = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> Status = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> RewardCost = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnRedeem", OnRedeem_Element.ToLinkReference(context));
members.Add("DisplayName", DisplayName.ToLinkEmpty(context));
members.Add("Message", Message.ToLinkEmpty(context));
members.Add("TimeStamp", TimeStamp.ToLinkEmpty(context));
members.Add("RewardId", RewardId.ToLinkEmpty(context));
members.Add("RewardTitle", RewardTitle.ToLinkEmpty(context));
members.Add("RewardPrompt", RewardPrompt.ToLinkEmpty(context));
members.Add("Status", Status.ToLinkEmpty(context));
members.Add("RewardCost", RewardCost.ToLinkEmpty(context));
}

}
}
