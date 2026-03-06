
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.UnpackColumns_Double3x3
// Generated on: pátek 6. března 2026 14:18:55
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.UnpackColumns_Double3x3")]
public partial class UnpackColumns_Double3x3 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Matrix3x3Double> Matrix { get => Matrix_Element.Data; set => Matrix_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Matrix3x3Double>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Matrix3x3Double>> Matrix_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3Double> Column0 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3Double> Column1 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3Double> Column2 = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Matrix", Matrix_Element.ToLinkReference(context));
members.Add("Column0", Column0.ToLinkEmpty(context));
members.Add("Column1", Column1.ToLinkEmpty(context));
members.Add("Column2", Column2.ToLinkEmpty(context));
}

}
}
