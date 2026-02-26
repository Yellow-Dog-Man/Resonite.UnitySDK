
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D.ClosestPointOnSphericalSectorSurface
// Generated on: čtvrtek 26. února 2026 12:27:39
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D.ClosestPointOnSphericalSectorSurface")]
public partial class ClosestPointOnSphericalSectorSurface : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Center { get => Center_Element.Data; set => Center_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>> Center_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Direction { get => Direction_Element.Data; set => Direction_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>> Direction_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Radius { get => Radius_Element.Data; set => Radius_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> Radius_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Angle { get => Angle_Element.Data; set => Angle_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> Angle_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Point { get => Point_Element.Data; set => Point_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>> Point_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> ClosestPoint = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsPointInside = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Center", Center_Element.ToLinkReference(context));
members.Add("Direction", Direction_Element.ToLinkReference(context));
members.Add("Radius", Radius_Element.ToLinkReference(context));
members.Add("Angle", Angle_Element.ToLinkReference(context));
members.Add("Point", Point_Element.ToLinkReference(context));
members.Add("ClosestPoint", ClosestPoint.ToLinkEmpty(context));
members.Add("IsPointInside", IsPointInside.ToLinkEmpty(context));
}

}
}
