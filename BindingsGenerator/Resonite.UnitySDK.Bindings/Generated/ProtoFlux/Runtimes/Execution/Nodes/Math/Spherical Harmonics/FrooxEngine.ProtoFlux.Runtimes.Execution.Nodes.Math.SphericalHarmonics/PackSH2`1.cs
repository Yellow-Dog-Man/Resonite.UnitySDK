
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.PackSH2<>
// Generated on: středa 25. února 2026 16:13:54
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.PackSH2<>")]
public partial class PackSH2<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::Elements.Core.SphericalHarmonicsL2<T>>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH0;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH1;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH2;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH3;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH4;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH5;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH6;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH7;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH8;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SH0", SH0.ToResoniteReference(context));
members.Add("SH1", SH1.ToResoniteReference(context));
members.Add("SH2", SH2.ToResoniteReference(context));
members.Add("SH3", SH3.ToResoniteReference(context));
members.Add("SH4", SH4.ToResoniteReference(context));
members.Add("SH5", SH5.ToResoniteReference(context));
members.Add("SH6", SH6.ToResoniteReference(context));
members.Add("SH7", SH7.ToResoniteReference(context));
members.Add("SH8", SH8.ToResoniteReference(context));
}

}
}
