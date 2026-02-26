
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Binary.Adder
// Generated on: čtvrtek 26. února 2026 10:04:34
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> A { get => A_Element.Data; set => A_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> A_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> B { get => B_Element.Data; set => B_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> B_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> CarryIn { get => CarryIn_Element.Data; set => CarryIn_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> CarryIn_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Y = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> CarryOut = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("A", A_Element.Data.ToResoniteReference(context));
members.Add("B", B_Element.Data.ToResoniteReference(context));
members.Add("CarryIn", CarryIn_Element.Data.ToResoniteReference(context));
members.Add("Y", new ResoniteLink.EmptyElement());
members.Add("CarryOut", new ResoniteLink.EmptyElement());
}

}
}
