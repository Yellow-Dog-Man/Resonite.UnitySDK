
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Pack_Sbyte4
// Generated on: pátek 13. února 2026 23:22:50
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Pack_Sbyte4")]
public partial class Pack_Sbyte4 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Vector4Sbyte>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.SByte> X;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.SByte> Y;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.SByte> Z;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.SByte> W;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("X", new ResoniteLink.Reference() { });
members.Add("Y", new ResoniteLink.Reference() { });
members.Add("Z", new ResoniteLink.Reference() { });
members.Add("W", new ResoniteLink.Reference() { });
}

}
}
