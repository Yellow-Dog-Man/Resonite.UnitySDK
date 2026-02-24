
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.ScaleOrdersSH4<>
// Generated on: úterý 24. února 2026 18:19:28
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.ScaleOrdersSH4<>")]
public partial class ScaleOrdersSH4<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::Elements.Core.SphericalHarmonicsL4<T>>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Elements.Core.SphericalHarmonicsL4<T>> SH;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Order0;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Order1;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Order2;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Order3;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Order4;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SH", SH.ToResoniteReference(context));
members.Add("Order0", Order0.ToResoniteReference(context));
members.Add("Order1", Order1.ToResoniteReference(context));
members.Add("Order2", Order2.ToResoniteReference(context));
members.Add("Order3", Order3.ToResoniteReference(context));
members.Add("Order4", Order4.ToResoniteReference(context));
}

}
}
