
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.TimeAndDate.Sub_DateTime_TimeSpan
// Generated on: čtvrtek 26. února 2026 12:27:56
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.TimeAndDate
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.TimeAndDate.Sub_DateTime_TimeSpan")]
public partial class Sub_DateTime_TimeSpan : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.DateTime>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.DateTime> A { get => A_Element.Data; set => A_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.DateTime>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.DateTime>> A_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.TimeSpan> B { get => B_Element.Data; set => B_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.TimeSpan>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.TimeSpan>> B_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("A", A_Element.ToLinkReference(context));
members.Add("B", B_Element.ToLinkReference(context));
}

}
}
