
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_Color
// Generated on: sobota 14. února 2026 8:57:49
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_Color")]
public partial class Unpack_Color : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Color> V;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> R;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> G;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> B;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> A;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("V", V.ToResoniteReference(context));
members.Add("R", new ResoniteLink.EmptyElement());
members.Add("G", new ResoniteLink.EmptyElement());
members.Add("B", new ResoniteLink.EmptyElement());
members.Add("A", new ResoniteLink.EmptyElement());
}

}
}
