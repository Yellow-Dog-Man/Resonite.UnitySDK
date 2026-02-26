
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Utility.IndexOfFirstObjectMatch<>
// Generated on: čtvrtek 26. února 2026 12:27:59
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Utility
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Utility.IndexOfFirstObjectMatch<>")]
public partial class IndexOfFirstObjectMatch<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>
	

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T> Match { get => Match_Element.Data; set => Match_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>> Match_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>>> Values = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> Index = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> FoundMatch = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Match", Match_Element.ToLinkReference(context));
members.Add("Values", Values.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("Index", Index.ToLinkEmpty(context));
members.Add("FoundMatch", FoundMatch.ToLinkEmpty(context));
}

}
}
