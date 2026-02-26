
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.TimeAndDate.SetDateTimeKind
// Generated on: čtvrtek 26. února 2026 15:08:57
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.DateTime> DateTime { get => DateTime_Element.Data; set => DateTime_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.DateTime>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.DateTime>> DateTime_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.DateTimeKind> Kind { get => Kind_Element.Data; set => Kind_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.DateTimeKind>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.DateTimeKind>> Kind_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DateTime", DateTime_Element.ToLinkReference(context));
members.Add("Kind", Kind_Element.ToLinkReference(context));
}

}
}
