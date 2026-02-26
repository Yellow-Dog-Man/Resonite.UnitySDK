
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.LeastCommonMultiple_Uint
// Generated on: čtvrtek 26. února 2026 10:04:16
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.LeastCommonMultiple_Uint")]
public partial class LeastCommonMultiple_Uint : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.UInt32>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt32> A { get => A_Element.Data; set => A_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt32>> A_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt32> B { get => B_Element.Data; set => B_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt32>> B_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("A", A_Element.Data.ToResoniteReference(context));
members.Add("B", B_Element.Data.ToResoniteReference(context));
}

}
}
