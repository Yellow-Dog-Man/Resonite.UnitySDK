
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.NearestUserNode<>
// Generated on: čtvrtek 19. února 2026 7:59:42
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.NearestUserNode<>")]
public abstract partial class NearestUserNode<D> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>, global::FrooxEngine.FrooxEngine.ProtoFlux.IMappableNode, global::FrooxEngine.ProtoFlux.IProtoFluxNode<global::FrooxEngine.ProtoFlux.IMappableNode>
	where D : struct, global::ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.INearestData

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> Reference;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User> IgnoreUser;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> IgnoreAFK;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.Slot> Slot;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.User> User;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Distance;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Reference", Reference.ToResoniteReference(context));
members.Add("IgnoreUser", IgnoreUser.ToResoniteReference(context));
members.Add("IgnoreAFK", IgnoreAFK.ToResoniteReference(context));
members.Add("Slot", new ResoniteLink.EmptyElement());
members.Add("User", new ResoniteLink.EmptyElement());
members.Add("Distance", new ResoniteLink.EmptyElement());
}

}
}
