
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.HitUVCoordinate
// Generated on: pátek 13. února 2026 23:22:52
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("HitCollider", new ResoniteLink.Reference() { });
members.Add("HitTriangleIndex", new ResoniteLink.Reference() { });
members.Add("HitPoint", new ResoniteLink.Reference() { });
members.Add("UV", new ResoniteLink.EmptyElement());
members.Add("IsValidUV", new ResoniteLink.EmptyElement());
}

}
}
