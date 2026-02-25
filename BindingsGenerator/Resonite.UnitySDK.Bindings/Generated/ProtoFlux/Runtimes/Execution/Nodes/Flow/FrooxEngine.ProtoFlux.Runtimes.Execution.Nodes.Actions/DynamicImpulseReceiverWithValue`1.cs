
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.DynamicImpulseReceiverWithValue<>
// Generated on: středa 25. února 2026 16:13:46
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.DynamicImpulseReceiverWithValue<>")]
public partial class DynamicImpulseReceiverWithValue<T> : global::FrooxEngine.FrooxEngine.ProtoFlux.ProxyVoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::ProtoFlux.Runtimes.Execution.Nodes.Actions.DynamicImpulseReceiverWithValue<T>.Proxy>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::System.String> Tag;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnTriggered;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> Value;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Tag", Tag.ToResoniteReference(context));
members.Add("OnTriggered", OnTriggered.ToResoniteReference(context));
members.Add("Value", new ResoniteLink.EmptyElement());
}

}
}
