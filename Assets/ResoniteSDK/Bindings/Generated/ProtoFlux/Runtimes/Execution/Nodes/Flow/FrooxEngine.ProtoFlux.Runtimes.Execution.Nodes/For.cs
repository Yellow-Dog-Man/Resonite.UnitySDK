
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.For
// Generated on: čtvrtek 19. února 2026 7:59:51
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.For")]
public partial class For : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Count;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Reverse;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation LoopStart;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation LoopIteration;
public global::FrooxEngine.ProtoFlux.INodeOperation LoopEnd;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> Iteration;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Count", Count.ToResoniteReference(context));
members.Add("Reverse", Reverse.ToResoniteReference(context));
members.Add("LoopStart", LoopStart.ToResoniteReference(context));
members.Add("LoopIteration", LoopIteration.ToResoniteReference(context));
members.Add("LoopEnd", LoopEnd.ToResoniteReference(context));
members.Add("Iteration", new ResoniteLink.EmptyElement());
}

}
}
