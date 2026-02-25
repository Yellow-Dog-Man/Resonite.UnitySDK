
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.UnpackRows_Double3x3
// Generated on: středa 25. února 2026 16:14:02
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.UnpackRows_Double3x3")]
public partial class UnpackRows_Double3x3 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Matrix3x3Double> Matrix;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3Double> Row0;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3Double> Row1;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3Double> Row2;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Matrix", Matrix.ToResoniteReference(context));
members.Add("Row0", new ResoniteLink.EmptyElement());
members.Add("Row1", new ResoniteLink.EmptyElement());
members.Add("Row2", new ResoniteLink.EmptyElement());
}

}
}
