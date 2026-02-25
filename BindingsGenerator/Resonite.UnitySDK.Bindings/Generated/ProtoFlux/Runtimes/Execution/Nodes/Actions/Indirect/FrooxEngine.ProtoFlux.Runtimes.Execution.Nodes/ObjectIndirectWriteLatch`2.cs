
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ObjectIndirectWriteLatch<,>
// Generated on: středa 25. února 2026 16:13:37
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ObjectIndirectWriteLatch<,>")]
public partial class ObjectIndirectWriteLatch<C,T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.WriteLatchBase<C,T>
	
	where C : global::ProtoFlux.Runtimes.Execution.ExecutionContext

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::ProtoFlux.Runtimes.Execution.IVariable<C,T>> Variable;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T> SetValue;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T> ResetValue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Variable", Variable.ToResoniteReference(context));
members.Add("SetValue", SetValue.ToResoniteReference(context));
members.Add("ResetValue", ResetValue.ToResoniteReference(context));
}

}
}
