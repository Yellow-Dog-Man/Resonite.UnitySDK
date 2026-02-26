
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_Short4
// Generated on: čtvrtek 26. února 2026 10:04:28
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_Short4")]
public partial class Unpack_Short4 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Short> V { get => V_Element.Data; set => V_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Short>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Short>> V_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int16> X = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int16> Y = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int16> Z = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int16> W = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("V", V_Element.Data.ToResoniteReference(context));
members.Add("X", new ResoniteLink.EmptyElement());
members.Add("Y", new ResoniteLink.EmptyElement());
members.Add("Z", new ResoniteLink.EmptyElement());
members.Add("W", new ResoniteLink.EmptyElement());
}

}
}
