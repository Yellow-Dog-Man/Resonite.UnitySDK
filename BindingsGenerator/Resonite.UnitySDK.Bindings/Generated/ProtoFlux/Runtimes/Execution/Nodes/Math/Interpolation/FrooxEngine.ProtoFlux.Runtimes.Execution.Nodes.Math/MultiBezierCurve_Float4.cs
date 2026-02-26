
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.MultiBezierCurve_Float4
// Generated on: čtvrtek 26. února 2026 12:27:40
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.MultiBezierCurve_Float4")]
public partial class MultiBezierCurve_Float4 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::ProtoFlux.Runtimes.Execution.Nodes.Math.TangentPointFloat4>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::ProtoFlux.Runtimes.Execution.Nodes.Math.TangentPointFloat4>, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::ProtoFlux.Runtimes.Execution.Nodes.Math.TangentPointFloat4>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::ProtoFlux.Runtimes.Execution.Nodes.Math.TangentPointFloat4>>> Operands = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Lerp { get => Lerp_Element.Data; set => Lerp_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> Lerp_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector4> Interpolated = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector4> Tangent = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Operands", Operands.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("Lerp", Lerp_Element.ToLinkReference(context));
members.Add("Interpolated", Interpolated.ToLinkEmpty(context));
members.Add("Tangent", Tangent.ToLinkEmpty(context));
}

}
}
