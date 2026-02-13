
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Pack_Color
// Generated on: pátek 13. února 2026 5:51:46
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Pack_Color")]
public partial class Pack_Color : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Color>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> R;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> G;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> B;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> A;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("R", new ResoniteLink.Reference() { });
members.Add("G", new ResoniteLink.Reference() { });
members.Add("B", new ResoniteLink.Reference() { });
members.Add("A", new ResoniteLink.Reference() { });
}

}
}
