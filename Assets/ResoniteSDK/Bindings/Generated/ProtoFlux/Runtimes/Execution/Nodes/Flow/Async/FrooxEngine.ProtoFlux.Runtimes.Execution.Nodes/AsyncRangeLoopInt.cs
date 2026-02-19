
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.AsyncRangeLoopInt
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.AsyncRangeLoopInt")]
public partial class AsyncRangeLoopInt : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Start;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> End;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> StepSize;
public global::FrooxEngine.ProtoFlux.INodeOperation LoopStart;
public global::FrooxEngine.ProtoFlux.INodeOperation LoopIteration;
public global::FrooxEngine.ProtoFlux.INodeOperation LoopEnd;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> Current;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Start", Start.ToResoniteReference(context));
members.Add("End", End.ToResoniteReference(context));
members.Add("StepSize", StepSize.ToResoniteReference(context));
members.Add("LoopStart", LoopStart.ToResoniteReference(context));
members.Add("LoopIteration", LoopIteration.ToResoniteReference(context));
members.Add("LoopEnd", LoopEnd.ToResoniteReference(context));
members.Add("Current", new ResoniteLink.EmptyElement());
}

}
}
