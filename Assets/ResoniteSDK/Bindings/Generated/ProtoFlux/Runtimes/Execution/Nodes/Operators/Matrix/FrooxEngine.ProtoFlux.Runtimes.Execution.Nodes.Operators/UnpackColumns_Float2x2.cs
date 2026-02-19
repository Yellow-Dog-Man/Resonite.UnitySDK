
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.UnpackColumns_Float2x2
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.UnpackColumns_Float2x2")]
public partial class UnpackColumns_Float2x2 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Matrix2x2> Matrix;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> Column0;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> Column1;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Matrix", Matrix.ToResoniteReference(context));
members.Add("Column0", new ResoniteLink.EmptyElement());
members.Add("Column1", new ResoniteLink.EmptyElement());
}

}
}
