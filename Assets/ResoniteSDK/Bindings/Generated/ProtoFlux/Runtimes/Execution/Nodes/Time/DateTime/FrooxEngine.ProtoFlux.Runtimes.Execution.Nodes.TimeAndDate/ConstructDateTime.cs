
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.TimeAndDate.ConstructDateTime
// Generated on: čtvrtek 19. února 2026 8:00:13
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.TimeAndDate.ConstructDateTime")]
public partial class ConstructDateTime : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.DateTime>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Year;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Month;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Day;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Hour;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Minute;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Second;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Millisecond;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.DateTimeKind> Kind;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Year", Year.ToResoniteReference(context));
members.Add("Month", Month.ToResoniteReference(context));
members.Add("Day", Day.ToResoniteReference(context));
members.Add("Hour", Hour.ToResoniteReference(context));
members.Add("Minute", Minute.ToResoniteReference(context));
members.Add("Second", Second.ToResoniteReference(context));
members.Add("Millisecond", Millisecond.ToResoniteReference(context));
members.Add("Kind", Kind.ToResoniteReference(context));
}

}
}
