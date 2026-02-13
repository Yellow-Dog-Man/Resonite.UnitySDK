
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Pack_Color32
// Generated on: pátek 13. února 2026 5:52:09
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Pack_Color32")]
public partial class Pack_Color32 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Color32>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Byte> R;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Byte> G;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Byte> B;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Byte> A;

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
