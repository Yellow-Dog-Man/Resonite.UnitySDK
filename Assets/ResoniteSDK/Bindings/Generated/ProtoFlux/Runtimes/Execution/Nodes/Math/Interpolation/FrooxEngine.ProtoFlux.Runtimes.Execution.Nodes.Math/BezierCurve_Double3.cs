
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.BezierCurve_Double3
// Generated on: sobota 14. února 2026 8:58:06
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.BezierCurve_Double3")]
public partial class BezierCurve_Double3 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::ProtoFlux.Runtimes.Execution.Nodes.Math.TangentPointDouble3> From;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::ProtoFlux.Runtimes.Execution.Nodes.Math.TangentPointDouble3> To;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Lerp;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3Double> Interpolated;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3Double> Tangent;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("From", From.ToResoniteReference(context));
members.Add("To", To.ToResoniteReference(context));
members.Add("Lerp", Lerp.ToResoniteReference(context));
members.Add("Interpolated", new ResoniteLink.EmptyElement());
members.Add("Tangent", new ResoniteLink.EmptyElement());
}

}
}
