
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ValueConditional<>
// Generated on: čtvrtek 19. února 2026 8:00:04
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> OnTrue;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> OnFalse;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Condition;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnTrue", OnTrue.ToResoniteReference(context));
members.Add("OnFalse", OnFalse.ToResoniteReference(context));
members.Add("Condition", Condition.ToResoniteReference(context));
}

}
}
