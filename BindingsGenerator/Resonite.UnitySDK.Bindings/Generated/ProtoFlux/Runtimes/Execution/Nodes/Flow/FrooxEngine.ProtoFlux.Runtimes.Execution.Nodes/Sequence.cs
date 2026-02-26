
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Sequence
// Generated on: čtvrtek 26. února 2026 12:27:34
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Sequence")]
public partial class Sequence : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation>> Calls = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Calls", Calls.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
