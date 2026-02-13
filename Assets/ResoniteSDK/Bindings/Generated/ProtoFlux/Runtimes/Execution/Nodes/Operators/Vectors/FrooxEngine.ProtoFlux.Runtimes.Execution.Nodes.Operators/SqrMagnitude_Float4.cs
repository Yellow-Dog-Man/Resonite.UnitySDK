
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.SqrMagnitude_Float4
// Generated on: pátek 13. února 2026 23:22:52
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.SqrMagnitude_Float4")]
public partial class SqrMagnitude_Float4 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.Single>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4> A;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("A", new ResoniteLink.Reference() { });
}

}
}
