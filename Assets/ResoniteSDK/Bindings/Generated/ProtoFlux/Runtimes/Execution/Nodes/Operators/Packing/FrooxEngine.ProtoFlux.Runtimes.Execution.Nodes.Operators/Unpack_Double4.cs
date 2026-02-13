
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_Double4
// Generated on: pátek 13. února 2026 5:52:10
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_Double4")]
public partial class Unpack_Double4 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double> V;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Double> X;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Double> Y;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Double> Z;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Double> W;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("V", new ResoniteLink.Reference() { });
members.Add("X", new ResoniteLink.EmptyElement());
members.Add("Y", new ResoniteLink.EmptyElement());
members.Add("Z", new ResoniteLink.EmptyElement());
members.Add("W", new ResoniteLink.EmptyElement());
}

}
}
