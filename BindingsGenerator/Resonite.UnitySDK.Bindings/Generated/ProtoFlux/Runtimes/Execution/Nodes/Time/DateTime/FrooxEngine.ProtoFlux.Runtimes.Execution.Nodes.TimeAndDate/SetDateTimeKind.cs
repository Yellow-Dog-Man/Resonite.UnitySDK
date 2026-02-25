
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.TimeAndDate.SetDateTimeKind
// Generated on: středa 25. února 2026 16:14:08
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.TimeAndDate.SetDateTimeKind")]
public partial class SetDateTimeKind : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.DateTime>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.DateTime> DateTime;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.DateTimeKind> Kind;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DateTime", DateTime.ToResoniteReference(context));
members.Add("Kind", Kind.ToResoniteReference(context));
}

}
}
