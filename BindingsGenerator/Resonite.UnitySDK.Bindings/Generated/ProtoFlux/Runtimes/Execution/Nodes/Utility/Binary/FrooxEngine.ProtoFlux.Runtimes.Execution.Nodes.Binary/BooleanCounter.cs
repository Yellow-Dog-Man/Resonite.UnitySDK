
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Binary.BooleanCounter
// Generated on: čtvrtek 26. února 2026 10:04:34
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
    public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>> Booleans = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> TrueCount = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> FalseCount = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> TotalCount = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Booleans", new ResoniteLink.SyncList()
{
    Elements = Booleans.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("TrueCount", new ResoniteLink.EmptyElement());
members.Add("FalseCount", new ResoniteLink.EmptyElement());
members.Add("TotalCount", new ResoniteLink.EmptyElement());
}

}
}
