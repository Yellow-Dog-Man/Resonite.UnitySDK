
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry2D.LineCircleIntersections
// Generated on: čtvrtek 26. února 2026 15:08:42
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2> Center { get => Center_Element.Data; set => Center_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2>> Center_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Radius { get => Radius_Element.Data; set => Radius_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> Radius_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2> LinePoint0 { get => LinePoint0_Element.Data; set => LinePoint0_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2>> LinePoint0_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2> LinePoint1 { get => LinePoint1_Element.Data; set => LinePoint1_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2>> LinePoint1_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> IntersectionCount = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> Intersection0 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> Intersection1 = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Center", Center_Element.ToLinkReference(context));
members.Add("Radius", Radius_Element.ToLinkReference(context));
members.Add("LinePoint0", LinePoint0_Element.ToLinkReference(context));
members.Add("LinePoint1", LinePoint1_Element.ToLinkReference(context));
members.Add("IntersectionCount", IntersectionCount.ToLinkEmpty(context));
members.Add("Intersection0", Intersection0.ToLinkEmpty(context));
members.Add("Intersection1", Intersection1.ToLinkEmpty(context));
}

}
}
