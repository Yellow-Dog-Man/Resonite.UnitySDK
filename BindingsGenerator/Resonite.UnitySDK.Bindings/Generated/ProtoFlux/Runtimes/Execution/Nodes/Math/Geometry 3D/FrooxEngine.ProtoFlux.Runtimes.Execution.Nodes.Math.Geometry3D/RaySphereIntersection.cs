
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D.RaySphereIntersection
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D.RaySphereIntersection")]
public partial class RaySphereIntersection : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Center;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Radius;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> RayOrigin;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> RayDirection;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Point;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsIntersecting;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Center", Center.ToResoniteReference(context));
members.Add("Radius", Radius.ToResoniteReference(context));
members.Add("RayOrigin", RayOrigin.ToResoniteReference(context));
members.Add("RayDirection", RayDirection.ToResoniteReference(context));
members.Add("Point", new ResoniteLink.EmptyElement());
members.Add("IsIntersecting", new ResoniteLink.EmptyElement());
}

}
}
