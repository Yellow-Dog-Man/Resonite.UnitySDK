
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.UnpackRows_Double4x4
// Generated on: čtvrtek 19. února 2026 8:00:07
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Matrix4x4Double> Matrix;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector4Double> Row0;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector4Double> Row1;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector4Double> Row2;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector4Double> Row3;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Matrix", Matrix.ToResoniteReference(context));
members.Add("Row0", new ResoniteLink.EmptyElement());
members.Add("Row1", new ResoniteLink.EmptyElement());
members.Add("Row2", new ResoniteLink.EmptyElement());
members.Add("Row3", new ResoniteLink.EmptyElement());
}

}
}
