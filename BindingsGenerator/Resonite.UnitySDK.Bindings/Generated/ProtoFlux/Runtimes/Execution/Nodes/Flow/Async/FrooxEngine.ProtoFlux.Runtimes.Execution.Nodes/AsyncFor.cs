
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.AsyncFor
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.AsyncFor")]
public partial class AsyncFor : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Count { get => Count_Element.Data; set => Count_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>> Count_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Reverse { get => Reverse_Element.Data; set => Reverse_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> Reverse_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation LoopStart { get => LoopStart_Element.Data; set => LoopStart_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> LoopStart_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation LoopIteration { get => LoopIteration_Element.Data; set => LoopIteration_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> LoopIteration_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation LoopEnd { get => LoopEnd_Element.Data; set => LoopEnd_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> LoopEnd_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> Iteration = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Count", Count_Element.ToLinkReference(context));
members.Add("Reverse", Reverse_Element.ToLinkReference(context));
members.Add("LoopStart", LoopStart_Element.ToLinkReference(context));
members.Add("LoopIteration", LoopIteration_Element.ToLinkReference(context));
members.Add("LoopEnd", LoopEnd_Element.ToLinkReference(context));
members.Add("Iteration", Iteration.ToLinkEmpty(context));
}

}
}
