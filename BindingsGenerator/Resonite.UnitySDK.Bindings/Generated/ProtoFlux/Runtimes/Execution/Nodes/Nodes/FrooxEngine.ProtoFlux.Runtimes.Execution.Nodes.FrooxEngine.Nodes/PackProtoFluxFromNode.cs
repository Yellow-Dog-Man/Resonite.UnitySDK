
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Nodes.PackProtoFluxFromNode
// Generated on: čtvrtek 26. února 2026 12:27:45
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Nodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Nodes.PackProtoFluxFromNode")]
public partial class PackProtoFluxFromNode : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionBreakableFlowNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.ProtoFlux.ProtoFluxNode> StartNode { get => StartNode_Element.Data; set => StartNode_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.ProtoFlux.ProtoFluxNode>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.ProtoFlux.ProtoFluxNode>> StartNode_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot>> Target_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("StartNode", StartNode_Element.ToLinkReference(context));
members.Add("Target", Target_Element.ToLinkReference(context));
}

}
}
