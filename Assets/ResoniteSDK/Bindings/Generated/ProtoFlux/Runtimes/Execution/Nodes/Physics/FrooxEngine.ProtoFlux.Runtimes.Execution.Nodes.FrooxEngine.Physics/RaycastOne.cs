
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.RaycastOne
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.RaycastOne")]
public partial class RaycastOne : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Origin;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Direction;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> MaxDistance;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> HitTriggers;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> UsersOnly;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> DebugDuration;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> Root;
public global::FrooxEngine.ProtoFlux.INodeOperation OnHit;
public global::FrooxEngine.ProtoFlux.INodeOperation OnMiss;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.ICollider> HitCollider;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> HitDistance;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> HitPoint;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> HitNormal;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> HitTriangleIndex;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Origin", Origin.ToResoniteReference(context));
members.Add("Direction", Direction.ToResoniteReference(context));
members.Add("MaxDistance", MaxDistance.ToResoniteReference(context));
members.Add("HitTriggers", HitTriggers.ToResoniteReference(context));
members.Add("UsersOnly", UsersOnly.ToResoniteReference(context));
members.Add("DebugDuration", DebugDuration.ToResoniteReference(context));
members.Add("Root", Root.ToResoniteReference(context));
members.Add("OnHit", OnHit.ToResoniteReference(context));
members.Add("OnMiss", OnMiss.ToResoniteReference(context));
members.Add("HitCollider", new ResoniteLink.EmptyElement());
members.Add("HitDistance", new ResoniteLink.EmptyElement());
members.Add("HitPoint", new ResoniteLink.EmptyElement());
members.Add("HitNormal", new ResoniteLink.EmptyElement());
members.Add("HitTriangleIndex", new ResoniteLink.EmptyElement());
}

}
}
