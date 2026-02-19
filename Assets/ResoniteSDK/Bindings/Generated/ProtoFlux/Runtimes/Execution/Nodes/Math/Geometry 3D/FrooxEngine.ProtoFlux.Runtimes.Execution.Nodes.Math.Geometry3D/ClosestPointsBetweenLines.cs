
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D.ClosestPointsBetweenLines
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D.ClosestPointsBetweenLines")]
public partial class ClosestPointsBetweenLines : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> LinePoint0;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> LineDir0;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> LinePoint1;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> LineDir1;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Point0;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Point1;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LinePoint0", LinePoint0.ToResoniteReference(context));
members.Add("LineDir0", LineDir0.ToResoniteReference(context));
members.Add("LinePoint1", LinePoint1.ToResoniteReference(context));
members.Add("LineDir1", LineDir1.ToResoniteReference(context));
members.Add("Point0", new ResoniteLink.EmptyElement());
members.Add("Point1", new ResoniteLink.EmptyElement());
}

}
}
