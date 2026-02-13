
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.ValueIndirectDecrement<,>
// Generated on: pátek 13. února 2026 23:22:18
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.ValueIndirectDecrement<,>")]
public partial class ValueIndirectDecrement<C,T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.DecrementBase<C,T>
	where T : struct
	where C : global::ProtoFlux.Runtimes.Execution.ExecutionContext

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::ProtoFlux.Runtimes.Execution.IVariable<C,T>> Variable;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Variable", new ResoniteLink.Reference() { });
}

}
}
