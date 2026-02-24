
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ImpulseDemultiplexer
// Generated on: úterý 24. února 2026 18:19:13
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public System.Collections.Generic.List<global::FrooxEngine.ProtoFlux.SyncNodeOperation> Operations;
public global::FrooxEngine.ProtoFlux.INodeOperation OnTriggered;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> Index;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Operations", new ResoniteLink.SyncList()
{
    Elements = Operations.ConvertList(m => new ResoniteLink.EmptyElement())
});
members.Add("OnTriggered", OnTriggered.ToResoniteReference(context));
members.Add("Index", new ResoniteLink.EmptyElement());
}

}
}
