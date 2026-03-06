
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.ReferenceDrive<>
// Generated on: pátek 6. března 2026 14:18:37
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.ReferenceDrive<>")]
public partial class ReferenceDrive<T> : global::FrooxEngine.FrooxEngine.ProtoFlux.ProxyVoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::FrooxEngine.ProtoFlux.CoreNodes.ReferenceDrive<T>.Proxy>, global::FrooxEngine.ProtoFlux.CoreNodes.IDrive
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>> Target_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
}

}
}
