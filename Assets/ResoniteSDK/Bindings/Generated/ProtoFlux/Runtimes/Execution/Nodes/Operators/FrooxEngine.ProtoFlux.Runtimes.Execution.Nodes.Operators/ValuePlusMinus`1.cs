
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.ValuePlusMinus<>
// Generated on: pátek 13. února 2026 23:22:46
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.ValuePlusMinus<>")]
public partial class ValuePlusMinus<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> Value;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> Offset;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> Plus;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> Minus;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Value", new ResoniteLink.Reference() { });
members.Add("Offset", new ResoniteLink.Reference() { });
members.Add("Plus", new ResoniteLink.EmptyElement());
members.Add("Minus", new ResoniteLink.EmptyElement());
}

}
}
