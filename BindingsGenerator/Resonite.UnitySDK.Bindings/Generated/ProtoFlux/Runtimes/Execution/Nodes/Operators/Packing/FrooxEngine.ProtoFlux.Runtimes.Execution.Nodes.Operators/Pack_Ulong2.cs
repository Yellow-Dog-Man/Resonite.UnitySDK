
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Pack_Ulong2
// Generated on: čtvrtek 26. února 2026 12:27:52
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Pack_Ulong2")]
public partial class Pack_Ulong2 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Vector2Ulong>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt64> X { get => X_Element.Data; set => X_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt64>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt64>> X_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt64> Y { get => Y_Element.Data; set => Y_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt64>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt64>> Y_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("X", X_Element.ToLinkReference(context));
members.Add("Y", Y_Element.ToLinkReference(context));
}

}
}
