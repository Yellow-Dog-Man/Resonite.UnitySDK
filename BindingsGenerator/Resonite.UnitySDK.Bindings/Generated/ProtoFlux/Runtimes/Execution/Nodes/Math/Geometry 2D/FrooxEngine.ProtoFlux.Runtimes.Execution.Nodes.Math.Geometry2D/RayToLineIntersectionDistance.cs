
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry2D.RayToLineIntersectionDistance
// Generated on: středa 25. února 2026 16:13:51
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry2D
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry2D.RayToLineIntersectionDistance")]
public partial class RayToLineIntersectionDistance : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2> Origin;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2> Direction;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2> LinePoint0;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2> LinePoint1;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Distance;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Intersects;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Origin", Origin.ToResoniteReference(context));
members.Add("Direction", Direction.ToResoniteReference(context));
members.Add("LinePoint0", LinePoint0.ToResoniteReference(context));
members.Add("LinePoint1", LinePoint1.ToResoniteReference(context));
members.Add("Distance", new ResoniteLink.EmptyElement());
members.Add("Intersects", new ResoniteLink.EmptyElement());
}

}
}
