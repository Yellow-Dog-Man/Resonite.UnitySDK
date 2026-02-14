
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Async.DelayUpdatesOrTimeWithValueTimeSpan<>
// Generated on: sobota 14. února 2026 8:57:59
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Async
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Async.DelayUpdatesOrTimeWithValueTimeSpan<>")]
public partial class DelayUpdatesOrTimeWithValueTimeSpan<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Async.DelayUpdatesOrTimeWithValue<T>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.TimeSpan> Duration;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Duration", Duration.ToResoniteReference(context));
}

}
}
