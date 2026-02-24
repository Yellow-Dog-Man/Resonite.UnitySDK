
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.PackSH3<>
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.PackSH3<>")]
public partial class PackSH3<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::Elements.Core.SphericalHarmonicsL3<T>>
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
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH9;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH10;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH11;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH12;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH13;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH14;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH15;

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
members.Add("SH9", SH9.ToResoniteReference(context));
members.Add("SH10", SH10.ToResoniteReference(context));
members.Add("SH11", SH11.ToResoniteReference(context));
members.Add("SH12", SH12.ToResoniteReference(context));
members.Add("SH13", SH13.ToResoniteReference(context));
members.Add("SH14", SH14.ToResoniteReference(context));
members.Add("SH15", SH15.ToResoniteReference(context));
}

}
}
