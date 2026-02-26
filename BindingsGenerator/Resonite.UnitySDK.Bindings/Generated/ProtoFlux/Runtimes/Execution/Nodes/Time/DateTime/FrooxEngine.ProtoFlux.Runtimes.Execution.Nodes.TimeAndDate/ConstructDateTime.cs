
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.TimeAndDate.ConstructDateTime
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.TimeAndDate.ConstructDateTime")]
public partial class ConstructDateTime : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.DateTime>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Year { get => Year_Element.Data; set => Year_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>> Year_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Month { get => Month_Element.Data; set => Month_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>> Month_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Day { get => Day_Element.Data; set => Day_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>> Day_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Hour { get => Hour_Element.Data; set => Hour_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>> Hour_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Minute { get => Minute_Element.Data; set => Minute_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>> Minute_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Second { get => Second_Element.Data; set => Second_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>> Second_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Millisecond { get => Millisecond_Element.Data; set => Millisecond_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>> Millisecond_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.DateTimeKind> Kind { get => Kind_Element.Data; set => Kind_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.DateTimeKind>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.DateTimeKind>> Kind_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Year", Year_Element.ToLinkReference(context));
members.Add("Month", Month_Element.ToLinkReference(context));
members.Add("Day", Day_Element.ToLinkReference(context));
members.Add("Hour", Hour_Element.ToLinkReference(context));
members.Add("Minute", Minute_Element.ToLinkReference(context));
members.Add("Second", Second_Element.ToLinkReference(context));
members.Add("Millisecond", Millisecond_Element.ToLinkReference(context));
members.Add("Kind", Kind_Element.ToLinkReference(context));
}

}
}
