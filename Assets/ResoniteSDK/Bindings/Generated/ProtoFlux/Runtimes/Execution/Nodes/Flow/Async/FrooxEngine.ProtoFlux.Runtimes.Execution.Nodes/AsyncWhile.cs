
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.AsyncWhile
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.AsyncWhile")]
public partial class AsyncWhile : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Condition;
public global::FrooxEngine.ProtoFlux.INodeOperation LoopStart;
public global::FrooxEngine.ProtoFlux.INodeOperation LoopIteration;
public global::FrooxEngine.ProtoFlux.INodeOperation LoopEnd;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Condition", Condition.ToResoniteReference(context));
members.Add("LoopStart", LoopStart.ToResoniteReference(context));
members.Add("LoopIteration", LoopIteration.ToResoniteReference(context));
members.Add("LoopEnd", LoopEnd.ToResoniteReference(context));
}

}
}
