
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Remap_Float
// Generated on: úterý 24. února 2026 18:19:21
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Remap_Float")]
public partial class Remap_Float : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.Single>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> InMin;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> InMax;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> OutMin;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> OutMax;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Value;

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
