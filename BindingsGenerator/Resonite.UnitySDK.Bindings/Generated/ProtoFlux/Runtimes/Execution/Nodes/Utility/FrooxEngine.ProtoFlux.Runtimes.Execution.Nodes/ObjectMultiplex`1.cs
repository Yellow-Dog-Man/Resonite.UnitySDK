
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ObjectMultiplex<>
// Generated on: čtvrtek 26. února 2026 12:27:59
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ObjectMultiplex<>")]
public partial class ObjectMultiplex<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>
	

{
    public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>>> Inputs = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Index { get => Index_Element.Data; set => Index_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>> Index_Element = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<T> Output = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> InputCount = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Inputs", Inputs.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("Index", Index_Element.ToLinkReference(context));
members.Add("Output", Output.ToLinkEmpty(context));
members.Add("InputCount", InputCount.ToLinkEmpty(context));
}

}
}
