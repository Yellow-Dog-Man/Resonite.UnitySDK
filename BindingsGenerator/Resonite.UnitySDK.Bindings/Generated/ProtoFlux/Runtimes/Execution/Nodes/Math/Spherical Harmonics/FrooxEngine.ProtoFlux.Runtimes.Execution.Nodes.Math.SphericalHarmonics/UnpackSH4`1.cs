
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.UnpackSH4<>
// Generated on: čtvrtek 26. února 2026 10:04:20
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.UnpackSH4<>")]
public partial class UnpackSH4<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Elements.Core.SphericalHarmonicsL4<T>> SH { get => SH_Element.Data; set => SH_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Elements.Core.SphericalHarmonicsL4<T>>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Elements.Core.SphericalHarmonicsL4<T>>> SH_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH0 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH1 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH2 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH3 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH4 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH5 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH6 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH7 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH8 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH9 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH10 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH11 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH12 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH13 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH14 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH15 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH16 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH17 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH18 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH19 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH20 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH21 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH22 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH23 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH24 = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SH", SH_Element.Data.ToResoniteReference(context));
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
members.Add("SH16", new ResoniteLink.EmptyElement());
members.Add("SH17", new ResoniteLink.EmptyElement());
members.Add("SH18", new ResoniteLink.EmptyElement());
members.Add("SH19", new ResoniteLink.EmptyElement());
members.Add("SH20", new ResoniteLink.EmptyElement());
members.Add("SH21", new ResoniteLink.EmptyElement());
members.Add("SH22", new ResoniteLink.EmptyElement());
members.Add("SH23", new ResoniteLink.EmptyElement());
members.Add("SH24", new ResoniteLink.EmptyElement());
}

}
}
