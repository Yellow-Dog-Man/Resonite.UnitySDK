
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ObjectConditional<>
// Generated on: úterý 24. února 2026 18:19:37
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ObjectConditional<>")]
public partial class ObjectConditional<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,T>
	

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T> OnTrue;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T> OnFalse;
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
