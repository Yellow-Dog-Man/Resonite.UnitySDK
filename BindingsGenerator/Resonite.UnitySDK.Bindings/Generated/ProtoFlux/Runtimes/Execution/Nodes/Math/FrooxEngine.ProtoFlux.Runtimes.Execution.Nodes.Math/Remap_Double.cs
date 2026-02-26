
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Remap_Double
// Generated on: čtvrtek 26. února 2026 10:04:17
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Remap_Double")]
public partial class Remap_Double : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.Double>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double> InMin { get => InMin_Element.Data; set => InMin_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double>> InMin_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double> InMax { get => InMax_Element.Data; set => InMax_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double>> InMax_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double> OutMin { get => OutMin_Element.Data; set => OutMin_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double>> OutMin_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double> OutMax { get => OutMax_Element.Data; set => OutMax_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double>> OutMax_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double> Value { get => Value_Element.Data; set => Value_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double>> Value_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("InMin", InMin_Element.Data.ToResoniteReference(context));
members.Add("InMax", InMax_Element.Data.ToResoniteReference(context));
members.Add("OutMin", OutMin_Element.Data.ToResoniteReference(context));
members.Add("OutMax", OutMax_Element.Data.ToResoniteReference(context));
members.Add("Value", Value_Element.Data.ToResoniteReference(context));
}

}
}
