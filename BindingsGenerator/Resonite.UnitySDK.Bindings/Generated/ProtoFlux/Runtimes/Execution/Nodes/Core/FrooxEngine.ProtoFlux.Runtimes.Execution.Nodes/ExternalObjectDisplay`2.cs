
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ExternalObjectDisplay<,>
// Generated on: čtvrtek 26. února 2026 15:08:31
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ExternalObjectDisplay<,>")]
public partial class ExternalObjectDisplay<C,T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<C>
	
	where C : global::ProtoFlux.Runtimes.Execution.ExtendedExecutionContext<C>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T> Input { get => Input_Element.Data; set => Input_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>> Input_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Input", Input_Element.ToLinkReference(context));
}

}
}
