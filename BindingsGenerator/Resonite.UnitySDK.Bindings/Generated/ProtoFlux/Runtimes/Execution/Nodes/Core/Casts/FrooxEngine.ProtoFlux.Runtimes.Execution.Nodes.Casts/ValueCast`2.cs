
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Casts.ValueCast<,>
// Generated on: pátek 6. března 2026 14:18:38
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Casts
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Casts.ValueCast<,>")]
public abstract partial class ValueCast<I,O> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,O>, global::FrooxEngine.ProtoFlux.Core.ICast, global::FrooxEngine.ProtoFlux.IProtoFluxNode<global::ProtoFlux.Core.ICast>
	where O : struct
	where I : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<I> Input { get => Input_Element.Data; set => Input_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<I>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<I>> Input_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Input", Input_Element.ToLinkReference(context));
}

}
}
