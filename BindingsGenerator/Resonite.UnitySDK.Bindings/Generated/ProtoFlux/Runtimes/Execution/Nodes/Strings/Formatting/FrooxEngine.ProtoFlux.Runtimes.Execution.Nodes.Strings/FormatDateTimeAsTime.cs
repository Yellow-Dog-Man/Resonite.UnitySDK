
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings.FormatDateTimeAsTime
// Generated on: čtvrtek 26. února 2026 12:27:55
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings.FormatDateTimeAsTime")]
public partial class FormatDateTimeAsTime : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.String>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.DateTime> Date { get => Date_Element.Data; set => Date_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.DateTime>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.DateTime>> Date_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Use24HourClock { get => Use24HourClock_Element.Data; set => Use24HourClock_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> Use24HourClock_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> ShowSeconds { get => ShowSeconds_Element.Data; set => ShowSeconds_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> ShowSeconds_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> ShowMilliseconds { get => ShowMilliseconds_Element.Data; set => ShowMilliseconds_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> ShowMilliseconds_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.IFormatProvider> FormatProvider { get => FormatProvider_Element.Data; set => FormatProvider_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.IFormatProvider>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.IFormatProvider>> FormatProvider_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Date", Date_Element.ToLinkReference(context));
members.Add("Use24HourClock", Use24HourClock_Element.ToLinkReference(context));
members.Add("ShowSeconds", ShowSeconds_Element.ToLinkReference(context));
members.Add("ShowMilliseconds", ShowMilliseconds_Element.ToLinkReference(context));
members.Add("FormatProvider", FormatProvider_Element.ToLinkReference(context));
}

}
}
