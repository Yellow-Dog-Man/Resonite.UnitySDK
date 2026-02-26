
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Add_Long_Long4
// Generated on: čtvrtek 26. února 2026 12:27:45
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Add_Long_Long4")]
public partial class Add_Long_Long4 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Vector4Long>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int64> A { get => A_Element.Data; set => A_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int64>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int64>> A_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Long> B { get => B_Element.Data; set => B_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Long>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Long>> B_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("A", A_Element.ToLinkReference(context));
members.Add("B", B_Element.ToLinkReference(context));
}

}
}
