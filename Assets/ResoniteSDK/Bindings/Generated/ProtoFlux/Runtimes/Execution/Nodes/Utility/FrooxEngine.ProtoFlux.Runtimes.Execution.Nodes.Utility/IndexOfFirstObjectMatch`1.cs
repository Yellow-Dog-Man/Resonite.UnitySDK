
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Utility.IndexOfFirstObjectMatch<>
// Generated on: čtvrtek 19. února 2026 8:00:15
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Utility
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Utility.IndexOfFirstObjectMatch<>")]
public partial class IndexOfFirstObjectMatch<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>
	

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T> Match;
public System.Collections.Generic.List<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>> Values;
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
