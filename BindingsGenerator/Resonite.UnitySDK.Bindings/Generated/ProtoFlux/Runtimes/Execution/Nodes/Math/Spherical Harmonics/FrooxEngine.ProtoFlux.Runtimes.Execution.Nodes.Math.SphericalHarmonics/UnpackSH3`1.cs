
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.UnpackSH3<>
// Generated on: čtvrtek 26. února 2026 12:27:42
// Resonite version: 2026.2.26.702
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
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Elements.Core.SphericalHarmonicsL3<T>> SH { get => SH_Element.Data; set => SH_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Elements.Core.SphericalHarmonicsL3<T>>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Elements.Core.SphericalHarmonicsL3<T>>> SH_Element = new();
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SH", SH_Element.ToLinkReference(context));
members.Add("SH0", SH0.ToLinkEmpty(context));
members.Add("SH1", SH1.ToLinkEmpty(context));
members.Add("SH2", SH2.ToLinkEmpty(context));
members.Add("SH3", SH3.ToLinkEmpty(context));
members.Add("SH4", SH4.ToLinkEmpty(context));
members.Add("SH5", SH5.ToLinkEmpty(context));
members.Add("SH6", SH6.ToLinkEmpty(context));
members.Add("SH7", SH7.ToLinkEmpty(context));
members.Add("SH8", SH8.ToLinkEmpty(context));
members.Add("SH9", SH9.ToLinkEmpty(context));
members.Add("SH10", SH10.ToLinkEmpty(context));
members.Add("SH11", SH11.ToLinkEmpty(context));
members.Add("SH12", SH12.ToLinkEmpty(context));
members.Add("SH13", SH13.ToLinkEmpty(context));
members.Add("SH14", SH14.ToLinkEmpty(context));
members.Add("SH15", SH15.ToLinkEmpty(context));
}

}
}
