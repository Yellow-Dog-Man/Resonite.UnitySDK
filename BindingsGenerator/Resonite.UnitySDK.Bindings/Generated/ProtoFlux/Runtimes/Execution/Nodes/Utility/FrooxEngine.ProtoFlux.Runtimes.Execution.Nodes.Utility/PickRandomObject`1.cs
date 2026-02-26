
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Utility.PickRandomObject<>
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Utility.PickRandomObject<>")]
public partial class PickRandomObject<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,T>
	

{
    public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>>> Operands = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Operands", Operands.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
