
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ImpulseDemultiplexer
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ImpulseDemultiplexer")]
public partial class ImpulseDemultiplexer : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.ProtoFlux.SyncNodeOperation>, global::FrooxEngine.ProtoFlux.SyncNodeOperation> Operations = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnTriggered { get => OnTriggered_Element.Data; set => OnTriggered_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnTriggered_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> Index = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Operations", Operations.ToLinkList(context, m => m.ToLinkEmpty(context)));
members.Add("OnTriggered", OnTriggered_Element.ToLinkReference(context));
members.Add("Index", Index.ToLinkEmpty(context));
}

}
}
