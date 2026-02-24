
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.PackSH1<>
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.PackSH1<>")]
public partial class PackSH1<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::Elements.Core.SphericalHarmonicsL1<T>>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH0;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH1;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH2;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH3;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SH0", SH0.ToResoniteReference(context));
members.Add("SH1", SH1.ToResoniteReference(context));
members.Add("SH2", SH2.ToResoniteReference(context));
members.Add("SH3", SH3.ToResoniteReference(context));
}

}
}
