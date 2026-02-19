
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.ScaleOrdersSH2<>
// Generated on: čtvrtek 19. února 2026 7:59:59
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.ScaleOrdersSH2<>")]
public partial class ScaleOrdersSH2<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::Elements.Core.SphericalHarmonicsL2<T>>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Elements.Core.SphericalHarmonicsL2<T>> SH;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Order0;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Order1;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Order2;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SH", SH.ToResoniteReference(context));
members.Add("Order0", Order0.ToResoniteReference(context));
members.Add("Order1", Order1.ToResoniteReference(context));
members.Add("Order2", Order2.ToResoniteReference(context));
}

}
}
