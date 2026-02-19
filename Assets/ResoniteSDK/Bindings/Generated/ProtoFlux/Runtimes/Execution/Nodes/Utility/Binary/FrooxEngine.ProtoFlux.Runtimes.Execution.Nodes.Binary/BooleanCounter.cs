
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Binary.BooleanCounter
// Generated on: čtvrtek 19. února 2026 8:00:15
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Binary
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Binary.BooleanCounter")]
public partial class BooleanCounter : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public System.Collections.Generic.List<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> Booleans;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> TrueCount;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> FalseCount;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> TotalCount;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Booleans", new ResoniteLink.SyncList()
{
    Elements = Booleans.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("TrueCount", new ResoniteLink.EmptyElement());
members.Add("FalseCount", new ResoniteLink.EmptyElement());
members.Add("TotalCount", new ResoniteLink.EmptyElement());
}

}
}
