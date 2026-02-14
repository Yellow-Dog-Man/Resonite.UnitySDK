
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D.RayPlaneIntersection
// Generated on: sobota 14. února 2026 8:58:05
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D.RayPlaneIntersection")]
public partial class RayPlaneIntersection : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Vector3>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> RayOrigin;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> RayDirection;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> PlanePoint;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> PlaneNormal;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RayOrigin", RayOrigin.ToResoniteReference(context));
members.Add("RayDirection", RayDirection.ToResoniteReference(context));
members.Add("PlanePoint", PlanePoint.ToResoniteReference(context));
members.Add("PlaneNormal", PlaneNormal.ToResoniteReference(context));
}

}
}
