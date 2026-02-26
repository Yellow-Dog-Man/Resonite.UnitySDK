
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ObjectDemultiplex<>
// Generated on: čtvrtek 26. února 2026 15:09:00
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T> Value { get => Value_Element.Data; set => Value_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>> Value_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T> DefaultValue { get => DefaultValue_Element.Data; set => DefaultValue_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>> DefaultValue_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Index { get => Index_Element.Data; set => Index_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>> Index_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.ProtoFlux.NodeObjectOutput<T>>, global::FrooxEngine.ProtoFlux.NodeObjectOutput<T>> ValueOutputs = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value", Value_Element.ToLinkReference(context));
members.Add("DefaultValue", DefaultValue_Element.ToLinkReference(context));
members.Add("Index", Index_Element.ToLinkReference(context));
members.Add("ValueOutputs", ValueOutputs.ToLinkList(context, m => m.ToLinkEmpty(context)));
}

}
}
