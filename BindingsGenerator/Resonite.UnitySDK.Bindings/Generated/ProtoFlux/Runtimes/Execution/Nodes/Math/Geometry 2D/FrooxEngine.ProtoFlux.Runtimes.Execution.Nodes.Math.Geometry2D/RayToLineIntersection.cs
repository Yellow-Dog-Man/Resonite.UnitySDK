
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry2D.RayToLineIntersection
// Generated on: čtvrtek 26. února 2026 12:27:39
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry2D.RayToLineIntersection")]
public partial class RayToLineIntersection : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2> Origin { get => Origin_Element.Data; set => Origin_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2>> Origin_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2> Direction { get => Direction_Element.Data; set => Direction_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2>> Direction_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2> LinePoint0 { get => LinePoint0_Element.Data; set => LinePoint0_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2>> LinePoint0_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2> LinePoint1 { get => LinePoint1_Element.Data; set => LinePoint1_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2>> LinePoint1_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> Intersection = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Intersects = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Origin", Origin_Element.ToLinkReference(context));
members.Add("Direction", Direction_Element.ToLinkReference(context));
members.Add("LinePoint0", LinePoint0_Element.ToLinkReference(context));
members.Add("LinePoint1", LinePoint1_Element.ToLinkReference(context));
members.Add("Intersection", Intersection.ToLinkEmpty(context));
members.Add("Intersects", Intersects.ToLinkEmpty(context));
}

}
}
