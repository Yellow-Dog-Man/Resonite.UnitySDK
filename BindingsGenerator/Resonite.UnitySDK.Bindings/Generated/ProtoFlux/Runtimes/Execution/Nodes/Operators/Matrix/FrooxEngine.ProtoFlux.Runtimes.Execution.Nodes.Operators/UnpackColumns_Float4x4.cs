
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.UnpackColumns_Float4x4
// Generated on: čtvrtek 26. února 2026 15:08:53
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Matrix4x4> Matrix { get => Matrix_Element.Data; set => Matrix_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Matrix4x4>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Matrix4x4>> Matrix_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector4> Column0 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector4> Column1 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector4> Column2 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector4> Column3 = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Matrix", Matrix_Element.ToLinkReference(context));
members.Add("Column0", Column0.ToLinkEmpty(context));
members.Add("Column1", Column1.ToLinkEmpty(context));
members.Add("Column2", Column2.ToLinkEmpty(context));
members.Add("Column3", Column3.ToLinkEmpty(context));
}

}
}
