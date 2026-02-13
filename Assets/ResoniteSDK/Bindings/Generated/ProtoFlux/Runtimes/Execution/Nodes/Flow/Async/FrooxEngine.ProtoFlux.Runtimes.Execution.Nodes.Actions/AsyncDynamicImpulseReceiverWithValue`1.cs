
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.AsyncDynamicImpulseReceiverWithValue<>
// Generated on: pátek 13. února 2026 5:51:53
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.AsyncDynamicImpulseReceiverWithValue<>")]
public partial class AsyncDynamicImpulseReceiverWithValue<T> : global::FrooxEngine.FrooxEngine.ProtoFlux.ProxyVoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::ProtoFlux.Runtimes.Execution.Nodes.Actions.AsyncDynamicImpulseReceiverWithValue<T>.Proxy>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::System.String> Tag;
public global::FrooxEngine.ProtoFlux.INodeOperation OnTriggered;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> Value;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Tag", new ResoniteLink.Reference() { });
members.Add("OnTriggered", new ResoniteLink.Reference() { });
members.Add("Value", new ResoniteLink.EmptyElement());
}

}
}
