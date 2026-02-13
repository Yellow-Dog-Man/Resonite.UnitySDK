
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D.RaySphereIntersection
// Generated on: pátek 13. února 2026 23:22:36
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Center", new ResoniteLink.Reference() { });
members.Add("Radius", new ResoniteLink.Reference() { });
members.Add("RayOrigin", new ResoniteLink.Reference() { });
members.Add("RayDirection", new ResoniteLink.Reference() { });
members.Add("Point", new ResoniteLink.EmptyElement());
members.Add("IsIntersecting", new ResoniteLink.EmptyElement());
}

}
}
