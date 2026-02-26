
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ObjectWrite<,>
// Generated on: čtvrtek 26. února 2026 12:27:25
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ObjectWrite<,>")]
public partial class ObjectWrite<C,T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.WriteBase<C,T>
	
	where C : global::ProtoFlux.Runtimes.Execution.ExecutionContext

{
    public global::FrooxEngine.ProtoFlux.Runtimes.Execution.IVariable<C,T> Variable { get => Variable_Element.Data; set => Variable_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.Runtimes.Execution.IVariable<C,T>>, global::FrooxEngine.ProtoFlux.Runtimes.Execution.IVariable<C,T>> Variable_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T> Value { get => Value_Element.Data; set => Value_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>> Value_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Variable", Variable_Element.ToLinkReference(context));
members.Add("Value", Value_Element.ToLinkReference(context));
}

}
}
