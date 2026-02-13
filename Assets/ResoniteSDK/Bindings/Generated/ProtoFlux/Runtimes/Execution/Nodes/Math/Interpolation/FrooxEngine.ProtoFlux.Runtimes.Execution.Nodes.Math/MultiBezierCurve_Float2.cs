
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.MultiBezierCurve_Float2
// Generated on: pátek 13. února 2026 5:51:59
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.MultiBezierCurve_Float2")]
public partial class MultiBezierCurve_Float2 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public System.Collections.Generic.List<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::ProtoFlux.Runtimes.Execution.Nodes.Math.TangentPointFloat2>> Operands;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Lerp;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> Interpolated;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> Tangent;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Operands", new ResoniteLink.SyncList()
{
    Elements = Operands.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("Lerp", new ResoniteLink.Reference() { });
members.Add("Interpolated", new ResoniteLink.EmptyElement());
members.Add("Tangent", new ResoniteLink.EmptyElement());
}

}
}
