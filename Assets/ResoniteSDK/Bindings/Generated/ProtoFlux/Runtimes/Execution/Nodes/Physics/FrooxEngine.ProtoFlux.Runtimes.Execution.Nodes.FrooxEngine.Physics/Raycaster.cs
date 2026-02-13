
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.Raycaster
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.Raycaster")]
public partial class Raycaster : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Origin;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Direction;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> MaxDistance;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> HitTriggers;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> UsersOnly;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> Root;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> HasHit;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.ICollider> HitCollider;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> HitDistance;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> HitPoint;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> HitNormal;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> HitTriangleIndex;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Origin", new ResoniteLink.Reference() { });
members.Add("Direction", new ResoniteLink.Reference() { });
members.Add("MaxDistance", new ResoniteLink.Reference() { });
members.Add("HitTriggers", new ResoniteLink.Reference() { });
members.Add("UsersOnly", new ResoniteLink.Reference() { });
members.Add("Root", new ResoniteLink.Reference() { });
members.Add("HasHit", new ResoniteLink.EmptyElement());
members.Add("HitCollider", new ResoniteLink.EmptyElement());
members.Add("HitDistance", new ResoniteLink.EmptyElement());
members.Add("HitPoint", new ResoniteLink.EmptyElement());
members.Add("HitNormal", new ResoniteLink.EmptyElement());
members.Add("HitTriangleIndex", new ResoniteLink.EmptyElement());
}

}
}
