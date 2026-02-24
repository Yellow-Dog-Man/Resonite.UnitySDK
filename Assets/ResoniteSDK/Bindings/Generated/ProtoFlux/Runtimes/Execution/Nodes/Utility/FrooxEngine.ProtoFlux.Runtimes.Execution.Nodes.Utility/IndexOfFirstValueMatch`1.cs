
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Utility.IndexOfFirstValueMatch<>
// Generated on: úterý 24. února 2026 18:19:59
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Utility
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Utility.IndexOfFirstValueMatch<>")]
public partial class IndexOfFirstValueMatch<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> Match;
public System.Collections.Generic.List<global::FrooxEngine.ProtoFlux.INodeValueOutput<T>> Values;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> Index;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> FoundMatch;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Match", Match.ToResoniteReference(context));
members.Add("Values", new ResoniteLink.SyncList()
{
    Elements = Values.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("Index", new ResoniteLink.EmptyElement());
members.Add("FoundMatch", new ResoniteLink.EmptyElement());
}

}
}
