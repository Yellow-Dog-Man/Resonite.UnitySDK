
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Pack_Color32
// Generated on: sobota 14. února 2026 8:58:20
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Pack_Color32")]
public partial class Pack_Color32 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Color32>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Byte> R;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Byte> G;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Byte> B;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Byte> A;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("R", R.ToResoniteReference(context));
members.Add("G", G.ToResoniteReference(context));
members.Add("B", B.ToResoniteReference(context));
members.Add("A", A.ToResoniteReference(context));
}

}
}
