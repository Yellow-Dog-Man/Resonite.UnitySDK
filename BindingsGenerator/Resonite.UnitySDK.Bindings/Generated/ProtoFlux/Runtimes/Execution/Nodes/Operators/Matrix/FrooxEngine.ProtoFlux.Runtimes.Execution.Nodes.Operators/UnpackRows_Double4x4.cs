
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.UnpackRows_Double4x4
// Generated on: čtvrtek 26. února 2026 10:04:27
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.UnpackRows_Double4x4")]
public partial class UnpackRows_Double4x4 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Matrix4x4Double> Matrix { get => Matrix_Element.Data; set => Matrix_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Matrix4x4Double>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Matrix4x4Double>> Matrix_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector4Double> Row0 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector4Double> Row1 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector4Double> Row2 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector4Double> Row3 = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Matrix", Matrix_Element.Data.ToResoniteReference(context));
members.Add("Row0", new ResoniteLink.EmptyElement());
members.Add("Row1", new ResoniteLink.EmptyElement());
members.Add("Row2", new ResoniteLink.EmptyElement());
members.Add("Row3", new ResoniteLink.EmptyElement());
}

}
}
