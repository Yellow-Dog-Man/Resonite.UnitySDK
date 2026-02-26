
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Casts.ObjectCast<,>
// Generated on: čtvrtek 26. února 2026 15:08:36
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Casts
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Casts.ObjectCast<,>")]
public partial class ObjectCast<I,O> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,O>, global::FrooxEngine.ProtoFlux.Core.ICast, global::FrooxEngine.ProtoFlux.IProtoFluxNode<global::ProtoFlux.Core.ICast>
	where O : class
	where I : class

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<I> Input { get => Input_Element.Data; set => Input_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<I>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<I>> Input_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Input", Input_Element.ToLinkReference(context));
}

}
}
