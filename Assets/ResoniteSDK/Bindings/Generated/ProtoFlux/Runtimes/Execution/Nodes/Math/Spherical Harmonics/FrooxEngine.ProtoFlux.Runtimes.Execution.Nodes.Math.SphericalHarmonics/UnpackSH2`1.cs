
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.UnpackSH2<>
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.UnpackSH2<>")]
public partial class UnpackSH2<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Elements.Core.SphericalHarmonicsL2<T>> SH;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH0;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH1;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH2;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH3;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH4;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH5;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH6;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH7;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH8;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SH", SH.ToResoniteReference(context));
members.Add("SH0", new ResoniteLink.EmptyElement());
members.Add("SH1", new ResoniteLink.EmptyElement());
members.Add("SH2", new ResoniteLink.EmptyElement());
members.Add("SH3", new ResoniteLink.EmptyElement());
members.Add("SH4", new ResoniteLink.EmptyElement());
members.Add("SH5", new ResoniteLink.EmptyElement());
members.Add("SH6", new ResoniteLink.EmptyElement());
members.Add("SH7", new ResoniteLink.EmptyElement());
members.Add("SH8", new ResoniteLink.EmptyElement());
}

}
}
