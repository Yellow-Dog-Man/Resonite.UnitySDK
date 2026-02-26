
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.ActionBreakableFlowNode<>
// Generated on: čtvrtek 26. února 2026 12:27:12
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.ActionBreakableFlowNode<>")]
public abstract partial class ActionBreakableFlowNode<C> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionNode<C>
	where C : global::ProtoFlux.Runtimes.Execution.ExecutionContext

{
    public global::FrooxEngine.ProtoFlux.INodeOperation Next { get => Next_Element.Data; set => Next_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> Next_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Next", Next_Element.ToLinkReference(context));
}

}
}
