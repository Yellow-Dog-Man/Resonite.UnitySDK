
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.TimeAndDate.IsBetween_DateTime
// Generated on: čtvrtek 19. února 2026 8:00:12
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.TimeAndDate
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.TimeAndDate.IsBetween_DateTime")]
public partial class IsBetween_DateTime : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.Boolean>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.DateTime> Value;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.DateTime> Min;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.DateTime> Max;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value", Value.ToResoniteReference(context));
members.Add("Min", Min.ToResoniteReference(context));
members.Add("Max", Max.ToResoniteReference(context));
}

}
}
