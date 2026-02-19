
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Transform.LocalTransform
// Generated on: čtvrtek 19. února 2026 8:00:14
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Transform
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Transform.LocalTransform")]
public partial class LocalTransform : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> Instance;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> LocalPosition;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Quaternion> LocalRotation;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> LocalScale;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Instance", Instance.ToResoniteReference(context));
members.Add("LocalPosition", new ResoniteLink.EmptyElement());
members.Add("LocalRotation", new ResoniteLink.EmptyElement());
members.Add("LocalScale", new ResoniteLink.EmptyElement());
}

}
}
