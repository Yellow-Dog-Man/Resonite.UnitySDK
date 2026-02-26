
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Undo.CreateTypeFieldUndoStep
// Generated on: čtvrtek 26. února 2026 12:27:58
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Undo
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Undo.CreateTypeFieldUndoStep")]
public partial class CreateTypeFieldUndoStep : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionBreakableFlowNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.SyncType> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.SyncType>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.SyncType>> Target_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> ForceNew { get => ForceNew_Element.Data; set => ForceNew_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> ForceNew_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("ForceNew", ForceNew_Element.ToLinkReference(context));
}

}
}
