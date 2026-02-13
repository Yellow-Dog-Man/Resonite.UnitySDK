
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ObjectMultiplex<>
// Generated on: pátek 13. února 2026 5:52:17
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ObjectMultiplex<>")]
public partial class ObjectMultiplex<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>
	

{
    public System.Collections.Generic.List<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>> Inputs;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Index;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<T> Output;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> InputCount;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Inputs", new ResoniteLink.SyncList()
{
    Elements = Inputs.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("Index", new ResoniteLink.Reference() { });
members.Add("Output", new ResoniteLink.EmptyElement());
members.Add("InputCount", new ResoniteLink.EmptyElement());
}

}
}
