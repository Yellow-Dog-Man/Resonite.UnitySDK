
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D.SphereForTangentLine
// Generated on: středa 25. února 2026 16:13:52
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D.SphereForTangentLine")]
public partial class SphereForTangentLine : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> LinePoint;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> LineDirection;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> SphereCenter;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> TangentPoint;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Radius;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LinePoint", LinePoint.ToResoniteReference(context));
members.Add("LineDirection", LineDirection.ToResoniteReference(context));
members.Add("SphereCenter", SphereCenter.ToResoniteReference(context));
members.Add("TangentPoint", new ResoniteLink.EmptyElement());
members.Add("Radius", new ResoniteLink.EmptyElement());
}

}
}
