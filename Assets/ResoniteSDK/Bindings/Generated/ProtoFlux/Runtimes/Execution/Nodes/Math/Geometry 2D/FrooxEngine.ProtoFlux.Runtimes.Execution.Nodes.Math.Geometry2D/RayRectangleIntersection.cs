
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry2D.RayRectangleIntersection
// Generated on: sobota 14. února 2026 8:58:05
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry2D
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry2D.RayRectangleIntersection")]
public partial class RayRectangleIntersection : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2> Origin;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2> Direction;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Rect> Rectangle;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> Intersection;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Intersects;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Origin", Origin.ToResoniteReference(context));
members.Add("Direction", Direction.ToResoniteReference(context));
members.Add("Rectangle", Rectangle.ToResoniteReference(context));
members.Add("Intersection", new ResoniteLink.EmptyElement());
members.Add("Intersects", new ResoniteLink.EmptyElement());
}

}
}
