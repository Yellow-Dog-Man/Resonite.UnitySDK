
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.CosineLerp_Double4
// Generated on: sobota 14. února 2026 8:58:07
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.CosineLerp_Double4")]
public partial class CosineLerp_Double4 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Vector4Double>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double> A;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double> B;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Lerp;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("A", A.ToResoniteReference(context));
members.Add("B", B.ToResoniteReference(context));
members.Add("Lerp", Lerp.ToResoniteReference(context));
}

}
}
