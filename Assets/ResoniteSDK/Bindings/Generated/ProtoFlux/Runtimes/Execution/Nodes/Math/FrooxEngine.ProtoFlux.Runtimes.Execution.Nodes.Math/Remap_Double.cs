
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Remap_Double
// Generated on: čtvrtek 19. února 2026 7:59:55
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Remap_Double")]
public partial class Remap_Double : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.Double>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double> InMin;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double> InMax;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double> OutMin;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double> OutMax;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double> Value;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("InMin", InMin.ToResoniteReference(context));
members.Add("InMax", InMax.ToResoniteReference(context));
members.Add("OutMin", OutMin.ToResoniteReference(context));
members.Add("OutMax", OutMax.ToResoniteReference(context));
members.Add("Value", Value.ToResoniteReference(context));
}

}
}
