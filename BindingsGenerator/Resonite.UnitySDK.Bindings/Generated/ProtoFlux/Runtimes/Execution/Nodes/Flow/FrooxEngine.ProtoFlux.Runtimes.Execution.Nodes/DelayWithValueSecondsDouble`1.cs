
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.DelayWithValueSecondsDouble<>
// Generated on: čtvrtek 26. února 2026 12:27:34
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.DelayWithValueSecondsDouble<>")]
public partial class DelayWithValueSecondsDouble<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.DelayTimeWithValue<T>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double> Duration { get => Duration_Element.Data; set => Duration_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double>> Duration_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Duration", Duration_Element.ToLinkReference(context));
}

}
}
