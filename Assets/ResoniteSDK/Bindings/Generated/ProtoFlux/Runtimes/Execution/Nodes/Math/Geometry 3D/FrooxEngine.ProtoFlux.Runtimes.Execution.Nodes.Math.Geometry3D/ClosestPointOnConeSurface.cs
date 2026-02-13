
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D.ClosestPointOnConeSurface
// Generated on: pátek 13. února 2026 5:51:58
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D.ClosestPointOnConeSurface")]
public partial class ClosestPointOnConeSurface : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> ConeCenter;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Quaternion> ConeOrientation;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> ConeHeight;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> ConeBaseRadius;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Point;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> ClosestPoint;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsPointInside;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ConeCenter", new ResoniteLink.Reference() { });
members.Add("ConeOrientation", new ResoniteLink.Reference() { });
members.Add("ConeHeight", new ResoniteLink.Reference() { });
members.Add("ConeBaseRadius", new ResoniteLink.Reference() { });
members.Add("Point", new ResoniteLink.Reference() { });
members.Add("ClosestPoint", new ResoniteLink.EmptyElement());
members.Add("IsPointInside", new ResoniteLink.EmptyElement());
}

}
}
