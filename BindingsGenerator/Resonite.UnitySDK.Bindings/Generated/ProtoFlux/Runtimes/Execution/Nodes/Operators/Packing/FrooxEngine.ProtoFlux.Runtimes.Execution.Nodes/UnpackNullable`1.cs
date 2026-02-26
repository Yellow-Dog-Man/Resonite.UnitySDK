
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.UnpackNullable<>
// Generated on: čtvrtek 26. února 2026 15:08:54
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.UnpackNullable<>")]
public partial class UnpackNullable<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.Nullable<T>> Nullable { get => Nullable_Element.Data; set => Nullable_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.Nullable<T>>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.Nullable<T>>> Nullable_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> Value = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> HasValue = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Nullable", Nullable_Element.ToLinkReference(context));
members.Add("Value", Value.ToLinkEmpty(context));
members.Add("HasValue", HasValue.ToLinkEmpty(context));
}

}
}
