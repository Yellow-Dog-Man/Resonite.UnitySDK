
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ValueConditional<>
// Generated on: čtvrtek 26. února 2026 12:27:48
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ValueConditional<>")]
public partial class ValueConditional<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,T>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> OnTrue { get => OnTrue_Element.Data; set => OnTrue_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T>> OnTrue_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> OnFalse { get => OnFalse_Element.Data; set => OnFalse_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T>> OnFalse_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Condition { get => Condition_Element.Data; set => Condition_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> Condition_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnTrue", OnTrue_Element.ToLinkReference(context));
members.Add("OnFalse", OnFalse_Element.ToLinkReference(context));
members.Add("Condition", Condition_Element.ToLinkReference(context));
}

}
}
