
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D.TriangleNormal
// Generated on: středa 25. února 2026 16:13:52
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D.TriangleNormal")]
public partial class TriangleNormal : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Point0;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Point1;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Point2;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Normal;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsValid;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Point0", Point0.ToResoniteReference(context));
members.Add("Point1", Point1.ToResoniteReference(context));
members.Add("Point2", Point2.ToResoniteReference(context));
members.Add("Normal", new ResoniteLink.EmptyElement());
members.Add("IsValid", new ResoniteLink.EmptyElement());
}

}
}
