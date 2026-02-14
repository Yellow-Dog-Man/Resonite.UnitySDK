
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Pack_Sbyte4
// Generated on: sobota 14. února 2026 8:58:21
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Pack_Sbyte4")]
public partial class Pack_Sbyte4 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Vector4Sbyte>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.SByte> X;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.SByte> Y;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.SByte> Z;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.SByte> W;

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
