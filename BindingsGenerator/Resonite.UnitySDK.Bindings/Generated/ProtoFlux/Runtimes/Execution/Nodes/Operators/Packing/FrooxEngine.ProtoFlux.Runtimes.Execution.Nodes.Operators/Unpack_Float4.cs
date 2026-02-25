
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_Float4
// Generated on: středa 25. února 2026 16:14:03
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_Float4")]
public partial class Unpack_Float4 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4> V;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> X;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Y;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Z;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> W;

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
