
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.NOR_Multi_Bool3
// Generated on: čtvrtek 26. února 2026 12:27:50
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.NOR_Multi_Bool3")]
public partial class NOR_Multi_Bool3 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Vector3Bool>

{
    public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Bool>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Bool>, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Bool>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Bool>>> Operands = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Operands", Operands.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
