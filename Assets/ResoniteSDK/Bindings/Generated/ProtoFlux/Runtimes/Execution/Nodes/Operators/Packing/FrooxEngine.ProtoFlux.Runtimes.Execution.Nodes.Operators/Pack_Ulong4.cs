
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Pack_Ulong4
// Generated on: úterý 24. února 2026 18:19:45
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Pack_Ulong4")]
public partial class Pack_Ulong4 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Vector4Ulong>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt64> X;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt64> Y;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt64> Z;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt64> W;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("X", X.ToResoniteReference(context));
members.Add("Y", Y.ToResoniteReference(context));
members.Add("Z", Z.ToResoniteReference(context));
members.Add("W", W.ToResoniteReference(context));
}

}
}
