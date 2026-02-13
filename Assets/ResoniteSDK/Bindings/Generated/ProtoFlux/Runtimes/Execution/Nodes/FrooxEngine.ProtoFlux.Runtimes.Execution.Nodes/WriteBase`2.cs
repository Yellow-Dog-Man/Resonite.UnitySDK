
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.WriteBase<,>
// Generated on: pátek 13. února 2026 5:51:43
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.WriteBase<,>")]
public abstract partial class WriteBase<C,T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionNode<C>
	
	where C : global::ProtoFlux.Runtimes.Execution.ExecutionContext

{
    public global::FrooxEngine.ProtoFlux.INodeOperation OnWritten;
public global::FrooxEngine.ProtoFlux.INodeOperation OnFail;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("OnWritten", new ResoniteLink.Reference() { });
members.Add("OnFail", new ResoniteLink.Reference() { });
}

}
}
