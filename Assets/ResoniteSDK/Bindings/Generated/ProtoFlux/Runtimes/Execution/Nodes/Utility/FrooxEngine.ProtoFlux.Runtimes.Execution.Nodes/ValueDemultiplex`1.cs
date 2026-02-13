
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ValueDemultiplex<>
// Generated on: pátek 13. února 2026 23:22:59
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ValueDemultiplex<>")]
public partial class ValueDemultiplex<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> Value;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> DefaultValue;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Index;
public System.Collections.Generic.List<global::FrooxEngine.ProtoFlux.NodeValueOutput<T>> ValueOutputs;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Value", new ResoniteLink.Reference() { });
members.Add("DefaultValue", new ResoniteLink.Reference() { });
members.Add("Index", new ResoniteLink.Reference() { });
members.Add("ValueOutputs", new ResoniteLink.SyncList()
{
    Elements = ValueOutputs.ConvertList(m => new ResoniteLink.EmptyElement())
});
}

}
}
