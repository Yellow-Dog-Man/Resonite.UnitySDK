
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry2D.LineCircleIntersections
// Generated on: pátek 13. února 2026 23:22:36
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry2D.LineCircleIntersections")]
public partial class LineCircleIntersections : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2> Center;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Radius;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2> LinePoint0;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2> LinePoint1;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> IntersectionCount;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> Intersection0;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> Intersection1;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Center", new ResoniteLink.Reference() { });
members.Add("Radius", new ResoniteLink.Reference() { });
members.Add("LinePoint0", new ResoniteLink.Reference() { });
members.Add("LinePoint1", new ResoniteLink.Reference() { });
members.Add("IntersectionCount", new ResoniteLink.EmptyElement());
members.Add("Intersection0", new ResoniteLink.EmptyElement());
members.Add("Intersection1", new ResoniteLink.EmptyElement());
}

}
}
