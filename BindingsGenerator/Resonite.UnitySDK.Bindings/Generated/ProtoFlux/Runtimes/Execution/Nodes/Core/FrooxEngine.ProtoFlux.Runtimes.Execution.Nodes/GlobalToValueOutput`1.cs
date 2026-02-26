
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.GlobalToValueOutput<>
// Generated on: čtvrtek 26. února 2026 12:27:28
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.GlobalToValueOutput<>")]
public partial class GlobalToValueOutput<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,T>, global::FrooxEngine.ProtoFlux.Runtimes.Execution.IVariable<global::ProtoFlux.Runtimes.Execution.ExecutionContext,T>, global::FrooxEngine.ProtoFlux.IProtoFluxNode<global::ProtoFlux.Runtimes.Execution.IVariable<global::ProtoFlux.Runtimes.Execution.ExecutionContext,T>>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<T> Global { get => Global_Element.Data; set => Global_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.IGlobalValueProxy<T>>, global::FrooxEngine.ProtoFlux.IGlobalValueProxy<T>> Global_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Global", Global_Element.ToLinkReference(context));
}

}
}
