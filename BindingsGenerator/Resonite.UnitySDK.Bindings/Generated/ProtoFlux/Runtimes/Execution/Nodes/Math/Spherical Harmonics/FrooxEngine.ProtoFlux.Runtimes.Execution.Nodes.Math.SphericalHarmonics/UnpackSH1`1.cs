
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.UnpackSH1<>
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.UnpackSH1<>")]
public partial class UnpackSH1<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Elements.Core.SphericalHarmonicsL1<T>> SH { get => SH_Element.Data; set => SH_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Elements.Core.SphericalHarmonicsL1<T>>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Elements.Core.SphericalHarmonicsL1<T>>> SH_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH0 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH1 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH2 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH3 = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SH", SH_Element.ToLinkReference(context));
members.Add("SH0", SH0.ToLinkEmpty(context));
members.Add("SH1", SH1.ToLinkEmpty(context));
members.Add("SH2", SH2.ToLinkEmpty(context));
members.Add("SH3", SH3.ToLinkEmpty(context));
}

}
}
