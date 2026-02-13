
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D.ClosestPointsBetweenLines
// Generated on: pátek 13. února 2026 5:51:58
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D.ClosestPointsBetweenLines")]
public partial class ClosestPointsBetweenLines : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> LinePoint0;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> LineDir0;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> LinePoint1;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> LineDir1;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Point0;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Point1;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("LinePoint0", new ResoniteLink.Reference() { });
members.Add("LineDir0", new ResoniteLink.Reference() { });
members.Add("LinePoint1", new ResoniteLink.Reference() { });
members.Add("LineDir1", new ResoniteLink.Reference() { });
members.Add("Point0", new ResoniteLink.EmptyElement());
members.Add("Point1", new ResoniteLink.EmptyElement());
}

}
}
