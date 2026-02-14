
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ObjectDemultiplex<>
// Generated on: sobota 14. února 2026 8:58:29
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ObjectDemultiplex<>")]
public partial class ObjectDemultiplex<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>
	

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T> Value;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T> DefaultValue;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Index;
public System.Collections.Generic.List<global::FrooxEngine.ProtoFlux.NodeObjectOutput<T>> ValueOutputs;

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
