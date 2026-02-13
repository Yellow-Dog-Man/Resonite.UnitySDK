
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.PingPong_Double2_Double
// Generated on: pátek 13. února 2026 23:22:34
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.PingPong_Double2_Double")]
public partial class PingPong_Double2_Double : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Vector2Double>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2Double> N;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double> Length;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("N", new ResoniteLink.Reference() { });
members.Add("Length", new ResoniteLink.Reference() { });
}

}
}
