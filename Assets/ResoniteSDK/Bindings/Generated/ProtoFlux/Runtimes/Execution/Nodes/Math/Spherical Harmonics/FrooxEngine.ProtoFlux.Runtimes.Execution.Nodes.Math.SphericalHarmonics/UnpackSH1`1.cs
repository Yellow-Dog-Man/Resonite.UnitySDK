
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.UnpackSH1<>
// Generated on: sobota 14. února 2026 8:58:09
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Elements.Core.SphericalHarmonicsL1<T>> SH;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH0;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH1;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH2;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> SH3;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SH", SH.ToResoniteReference(context));
members.Add("SH0", new ResoniteLink.EmptyElement());
members.Add("SH1", new ResoniteLink.EmptyElement());
members.Add("SH2", new ResoniteLink.EmptyElement());
members.Add("SH3", new ResoniteLink.EmptyElement());
}

}
}
