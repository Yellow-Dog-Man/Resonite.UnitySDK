
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.PackTangentPointFloat
// Generated on: čtvrtek 19. února 2026 8:00:00
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.PackTangentPointFloat")]
public partial class PackTangentPointFloat : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::ProtoFlux.Runtimes.Execution.Nodes.Math.TangentPointFloat>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Value;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Tangent;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value", Value.ToResoniteReference(context));
members.Add("Tangent", Tangent.ToResoniteReference(context));
}

}
}
