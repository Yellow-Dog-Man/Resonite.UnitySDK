
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.GlobalToObjectOutput<>
// Generated on: sobota 14. února 2026 8:57:49
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.GlobalToObjectOutput<>")]
public partial class GlobalToObjectOutput<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,T>, global::FrooxEngine.ProtoFlux.Runtimes.Execution.IVariable<global::ProtoFlux.Runtimes.Execution.ExecutionContext,T>, global::FrooxEngine.ProtoFlux.IProtoFluxNode<global::ProtoFlux.Runtimes.Execution.IVariable<global::ProtoFlux.Runtimes.Execution.ExecutionContext,T>>
	

{
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<T> Global;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Global", Global.ToResoniteReference(context));
}

}
}
