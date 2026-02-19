
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Binary.Adder
// Generated on: čtvrtek 19. února 2026 8:00:15
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Binary
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Binary.Adder")]
public partial class Adder : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> A;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> B;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> CarryIn;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Y;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> CarryOut;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("A", A.ToResoniteReference(context));
members.Add("B", B.ToResoniteReference(context));
members.Add("CarryIn", CarryIn.ToResoniteReference(context));
members.Add("Y", new ResoniteLink.EmptyElement());
members.Add("CarryOut", new ResoniteLink.EmptyElement());
}

}
}
