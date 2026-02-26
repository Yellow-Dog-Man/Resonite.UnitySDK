
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.ReleaseAllGrabbed
// Generated on: čtvrtek 26. února 2026 12:27:35
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.ReleaseAllGrabbed")]
public partial class ReleaseAllGrabbed : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionBreakableFlowNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.BodyNode> Node { get => Node_Element.Data; set => Node_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.BodyNode>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.BodyNode>> Node_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> SupressEvents { get => SupressEvents_Element.Data; set => SupressEvents_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> SupressEvents_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Node", Node_Element.ToLinkReference(context));
members.Add("SupressEvents", SupressEvents_Element.ToLinkReference(context));
}

}
}
