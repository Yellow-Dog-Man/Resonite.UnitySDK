
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.HitUVCoordinate
// Generated on: úterý 24. února 2026 18:19:48
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.HitUVCoordinate")]
public partial class HitUVCoordinate : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.ICollider> HitCollider;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> HitTriangleIndex;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> HitPoint;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> UV;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsValidUV;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HitCollider", HitCollider.ToResoniteReference(context));
members.Add("HitTriangleIndex", HitTriangleIndex.ToResoniteReference(context));
members.Add("HitPoint", HitPoint.ToResoniteReference(context));
members.Add("UV", new ResoniteLink.EmptyElement());
members.Add("IsValidUV", new ResoniteLink.EmptyElement());
}

}
}
