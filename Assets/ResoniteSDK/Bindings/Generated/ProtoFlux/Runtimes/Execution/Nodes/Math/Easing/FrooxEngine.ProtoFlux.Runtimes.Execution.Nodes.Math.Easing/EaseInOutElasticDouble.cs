
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Easing.EaseInOutElasticDouble
// Generated on: pátek 13. února 2026 23:22:36
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Easing
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Easing.EaseInOutElasticDouble")]
public partial class EaseInOutElasticDouble : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.Double>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double> Time;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double> Amplitude;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double> Period;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Time", new ResoniteLink.Reference() { });
members.Add("Amplitude", new ResoniteLink.Reference() { });
members.Add("Period", new ResoniteLink.Reference() { });
}

}
}
