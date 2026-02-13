
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.LessThan_Ulong4
// Generated on: pátek 13. února 2026 23:22:44
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.LessThan_Ulong4")]
public partial class LessThan_Ulong4 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Vector4Bool>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Ulong> A;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Ulong> B;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("A", new ResoniteLink.Reference() { });
members.Add("B", new ResoniteLink.Reference() { });
}

}
}
