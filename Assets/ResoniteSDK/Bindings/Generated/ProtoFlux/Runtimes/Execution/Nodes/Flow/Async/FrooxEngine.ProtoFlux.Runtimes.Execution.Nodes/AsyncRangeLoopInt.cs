
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.AsyncRangeLoopInt
// Generated on: pátek 13. února 2026 5:51:53
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Start", new ResoniteLink.Reference() { });
members.Add("End", new ResoniteLink.Reference() { });
members.Add("StepSize", new ResoniteLink.Reference() { });
members.Add("LoopStart", new ResoniteLink.Reference() { });
members.Add("LoopIteration", new ResoniteLink.Reference() { });
members.Add("LoopEnd", new ResoniteLink.Reference() { });
members.Add("Current", new ResoniteLink.EmptyElement());
}

}
}
