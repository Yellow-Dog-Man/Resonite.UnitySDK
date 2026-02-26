
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Easing.EaseOutElasticDouble
// Generated on: čtvrtek 26. února 2026 15:08:42
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Easing
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Easing.EaseOutElasticDouble")]
public partial class EaseOutElasticDouble : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.Double>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double> Time { get => Time_Element.Data; set => Time_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double>> Time_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double> Amplitude { get => Amplitude_Element.Data; set => Amplitude_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double>> Amplitude_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double> Period { get => Period_Element.Data; set => Period_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double>> Period_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Time", Time_Element.ToLinkReference(context));
members.Add("Amplitude", Amplitude_Element.ToLinkReference(context));
members.Add("Period", Period_Element.ToLinkReference(context));
}

}
}
