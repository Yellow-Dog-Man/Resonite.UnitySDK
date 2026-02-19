
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ValueDemultiplex<>
// Generated on: čtvrtek 19. února 2026 8:00:15
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ValueDemultiplex<>")]
public partial class ValueDemultiplex<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> Value;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> DefaultValue;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Index;
public System.Collections.Generic.List<global::FrooxEngine.ProtoFlux.NodeValueOutput<T>> ValueOutputs;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value", Value.ToResoniteReference(context));
members.Add("DefaultValue", DefaultValue.ToResoniteReference(context));
members.Add("Index", Index.ToResoniteReference(context));
members.Add("ValueOutputs", new ResoniteLink.SyncList()
{
    Elements = ValueOutputs.ConvertList(m => new ResoniteLink.EmptyElement())
});
}

}
}
