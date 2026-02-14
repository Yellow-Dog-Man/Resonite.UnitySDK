
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_Sbyte4
// Generated on: sobota 14. února 2026 8:58:21
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_Sbyte4")]
public partial class Unpack_Sbyte4 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Sbyte> V;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.SByte> X;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.SByte> Y;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.SByte> Z;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.SByte> W;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("V", V.ToResoniteReference(context));
members.Add("X", new ResoniteLink.EmptyElement());
members.Add("Y", new ResoniteLink.EmptyElement());
members.Add("Z", new ResoniteLink.EmptyElement());
members.Add("W", new ResoniteLink.EmptyElement());
}

}
}
