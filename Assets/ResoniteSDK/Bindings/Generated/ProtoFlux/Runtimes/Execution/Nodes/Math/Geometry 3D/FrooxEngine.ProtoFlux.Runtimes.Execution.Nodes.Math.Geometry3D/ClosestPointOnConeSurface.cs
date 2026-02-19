
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D.ClosestPointOnConeSurface
// Generated on: čtvrtek 19. února 2026 7:59:56
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ConeCenter", ConeCenter.ToResoniteReference(context));
members.Add("ConeOrientation", ConeOrientation.ToResoniteReference(context));
members.Add("ConeHeight", ConeHeight.ToResoniteReference(context));
members.Add("ConeBaseRadius", ConeBaseRadius.ToResoniteReference(context));
members.Add("Point", Point.ToResoniteReference(context));
members.Add("ClosestPoint", new ResoniteLink.EmptyElement());
members.Add("IsPointInside", new ResoniteLink.EmptyElement());
}

}
}
