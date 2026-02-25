
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.UnpackNullable<>
// Generated on: středa 25. února 2026 16:14:03
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.Nullable<T>> Nullable;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> Value;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> HasValue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Nullable", Nullable.ToResoniteReference(context));
members.Add("Value", new ResoniteLink.EmptyElement());
members.Add("HasValue", new ResoniteLink.EmptyElement());
}

}
}
