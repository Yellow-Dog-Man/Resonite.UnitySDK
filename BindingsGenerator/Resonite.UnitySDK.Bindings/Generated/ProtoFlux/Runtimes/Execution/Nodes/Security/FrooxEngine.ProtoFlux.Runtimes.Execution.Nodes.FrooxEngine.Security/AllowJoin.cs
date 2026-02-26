
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Security.AllowJoin
// Generated on: čtvrtek 26. února 2026 12:27:54
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Security
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Security.AllowJoin")]
public partial class AllowJoin : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionBreakableFlowNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Security.JoinRequestHandle> Handle { get => Handle_Element.Data; set => Handle_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Security.JoinRequestHandle>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Security.JoinRequestHandle>> Handle_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Handle", Handle_Element.ToLinkReference(context));
}

}
}
