
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.AsyncRangeLoopInt
// Generated on: čtvrtek 26. února 2026 15:08:38
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.AsyncRangeLoopInt")]
public partial class AsyncRangeLoopInt : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Start { get => Start_Element.Data; set => Start_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>> Start_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> End { get => End_Element.Data; set => End_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>> End_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> StepSize { get => StepSize_Element.Data; set => StepSize_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>> StepSize_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation LoopStart { get => LoopStart_Element.Data; set => LoopStart_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> LoopStart_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation LoopIteration { get => LoopIteration_Element.Data; set => LoopIteration_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> LoopIteration_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation LoopEnd { get => LoopEnd_Element.Data; set => LoopEnd_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> LoopEnd_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> Current = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Start", Start_Element.ToLinkReference(context));
members.Add("End", End_Element.ToLinkReference(context));
members.Add("StepSize", StepSize_Element.ToLinkReference(context));
members.Add("LoopStart", LoopStart_Element.ToLinkReference(context));
members.Add("LoopIteration", LoopIteration_Element.ToLinkReference(context));
members.Add("LoopEnd", LoopEnd_Element.ToLinkReference(context));
members.Add("Current", Current.ToLinkEmpty(context));
}

}
}
