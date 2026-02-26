
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.DelayWithObjectTimeSpan<>
// Generated on: čtvrtek 26. února 2026 15:08:37
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.DelayWithObjectTimeSpan<>")]
public partial class DelayWithObjectTimeSpan<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.DelayTimeWithObject<T>
	

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.TimeSpan> Duration { get => Duration_Element.Data; set => Duration_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.TimeSpan>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.TimeSpan>> Duration_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Duration", Duration_Element.ToLinkReference(context));
}

}
}
