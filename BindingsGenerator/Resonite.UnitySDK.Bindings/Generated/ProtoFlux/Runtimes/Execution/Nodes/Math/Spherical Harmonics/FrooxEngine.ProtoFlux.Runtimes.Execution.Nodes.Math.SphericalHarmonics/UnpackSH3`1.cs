
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.UnpackSH3<>
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.UnpackSH3<>")]
public partial class UnpackSH3<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Elements.Core.SphericalHarmonicsL3<T>> SH;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH0;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH1;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH2;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH3;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH4;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH5;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH6;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH7;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH8;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH9;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH10;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH11;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH12;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH13;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH14;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH15;

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
members.Add("SH9", new ResoniteLink.EmptyElement());
members.Add("SH10", new ResoniteLink.EmptyElement());
members.Add("SH11", new ResoniteLink.EmptyElement());
members.Add("SH12", new ResoniteLink.EmptyElement());
members.Add("SH13", new ResoniteLink.EmptyElement());
members.Add("SH14", new ResoniteLink.EmptyElement());
members.Add("SH15", new ResoniteLink.EmptyElement());
}

}
}
