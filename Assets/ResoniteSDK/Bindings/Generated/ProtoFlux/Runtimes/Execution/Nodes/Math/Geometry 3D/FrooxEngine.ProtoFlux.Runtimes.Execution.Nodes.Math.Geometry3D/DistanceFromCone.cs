
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D.DistanceFromCone
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D.DistanceFromCone")]
public partial class DistanceFromCone : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.Single>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> ConeCenter;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Quaternion> ConeOrientation;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> ConeHeight;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> ConeBaseRadius;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Point;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ConeCenter", ConeCenter.ToResoniteReference(context));
members.Add("ConeOrientation", ConeOrientation.ToResoniteReference(context));
members.Add("ConeHeight", ConeHeight.ToResoniteReference(context));
members.Add("ConeBaseRadius", ConeBaseRadius.ToResoniteReference(context));
members.Add("Point", Point.ToResoniteReference(context));
}

}
}
