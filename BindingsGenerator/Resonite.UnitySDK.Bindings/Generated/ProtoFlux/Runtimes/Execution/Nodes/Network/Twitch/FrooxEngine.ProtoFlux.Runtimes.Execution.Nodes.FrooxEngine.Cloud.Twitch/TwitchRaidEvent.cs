
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch.TwitchRaidEvent
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch.TwitchRaidEvent")]
public partial class TwitchRaidEvent : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.Twitch.TwitchEventsNode

{
    public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnRaid { get => OnRaid_Element.Data; set => OnRaid_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> OnRaid_Element = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> UserId = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.String> DisplayName = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.ColorX> Color = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> ViewerCount = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsSubscriber = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnRaid", OnRaid_Element.ToLinkReference(context));
members.Add("UserId", UserId.ToLinkEmpty(context));
members.Add("DisplayName", DisplayName.ToLinkEmpty(context));
members.Add("Color", Color.ToLinkEmpty(context));
members.Add("ViewerCount", ViewerCount.ToLinkEmpty(context));
members.Add("IsSubscriber", IsSubscriber.ToLinkEmpty(context));
}

}
}
