
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.References.ReferenceTarget<>
// Generated on: pátek 6. března 2026 14:18:56
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.References
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.References.ReferenceTarget<>")]
public partial class ReferenceTarget<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,T>
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.SyncRef<T>> Reference { get => Reference_Element.Data; set => Reference_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.SyncRef<T>>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.SyncRef<T>>> Reference_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Reference", Reference_Element.ToLinkReference(context));
}

}
}
