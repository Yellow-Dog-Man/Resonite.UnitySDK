
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ObjectConditional<>
// Generated on: pátek 13. února 2026 23:22:45
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ObjectConditional<>")]
public partial class ObjectConditional<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,T>
	

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T> OnTrue;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T> OnFalse;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Condition;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("OnTrue", new ResoniteLink.Reference() { });
members.Add("OnFalse", new ResoniteLink.Reference() { });
members.Add("Condition", new ResoniteLink.Reference() { });
}

}
}
