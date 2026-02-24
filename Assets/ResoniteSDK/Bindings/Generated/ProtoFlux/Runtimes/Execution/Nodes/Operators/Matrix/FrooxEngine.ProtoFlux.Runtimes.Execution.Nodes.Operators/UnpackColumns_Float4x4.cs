
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.UnpackColumns_Float4x4
// Generated on: úterý 24. února 2026 18:19:45
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.UnpackColumns_Float4x4")]
public partial class UnpackColumns_Float4x4 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Matrix4x4> Matrix;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector4> Column0;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector4> Column1;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector4> Column2;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector4> Column3;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Matrix", Matrix.ToResoniteReference(context));
members.Add("Column0", new ResoniteLink.EmptyElement());
members.Add("Column1", new ResoniteLink.EmptyElement());
members.Add("Column2", new ResoniteLink.EmptyElement());
members.Add("Column3", new ResoniteLink.EmptyElement());
}

}
}
