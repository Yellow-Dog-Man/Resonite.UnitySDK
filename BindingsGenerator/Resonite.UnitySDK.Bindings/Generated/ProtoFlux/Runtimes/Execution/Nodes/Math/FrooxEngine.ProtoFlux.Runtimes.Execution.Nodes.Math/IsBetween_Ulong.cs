
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.IsBetween_Ulong
// Generated on: čtvrtek 26. února 2026 12:27:36
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.IsBetween_Ulong")]
public partial class IsBetween_Ulong : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.Boolean>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt64> Value { get => Value_Element.Data; set => Value_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt64>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt64>> Value_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt64> Min { get => Min_Element.Data; set => Min_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt64>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt64>> Min_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt64> Max { get => Max_Element.Data; set => Max_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt64>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt64>> Max_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value", Value_Element.ToLinkReference(context));
members.Add("Min", Min_Element.ToLinkReference(context));
members.Add("Max", Max_Element.ToLinkReference(context));
}

}
}
