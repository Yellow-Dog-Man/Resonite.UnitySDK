
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Binary.BooleanCounter
// Generated on: pátek 6. března 2026 14:19:00
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>> Booleans = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> TrueCount = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> FalseCount = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> TotalCount = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Booleans", Booleans.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("TrueCount", TrueCount.ToLinkEmpty(context));
members.Add("FalseCount", FalseCount.ToLinkEmpty(context));
members.Add("TotalCount", TotalCount.ToLinkEmpty(context));
}

}
}
