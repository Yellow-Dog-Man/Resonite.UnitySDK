
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.PackSH2<>
// Generated on: čtvrtek 26. února 2026 10:04:20
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.PackSH2<>")]
public partial class PackSH2<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::Elements.Core.SphericalHarmonicsL2<T>>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH0 { get => SH0_Element.Data; set => SH0_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T>> SH0_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH1 { get => SH1_Element.Data; set => SH1_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T>> SH1_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH2 { get => SH2_Element.Data; set => SH2_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T>> SH2_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH3 { get => SH3_Element.Data; set => SH3_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T>> SH3_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH4 { get => SH4_Element.Data; set => SH4_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T>> SH4_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH5 { get => SH5_Element.Data; set => SH5_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T>> SH5_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH6 { get => SH6_Element.Data; set => SH6_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T>> SH6_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH7 { get => SH7_Element.Data; set => SH7_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T>> SH7_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH8 { get => SH8_Element.Data; set => SH8_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T>> SH8_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SH0", SH0_Element.Data.ToResoniteReference(context));
members.Add("SH1", SH1_Element.Data.ToResoniteReference(context));
members.Add("SH2", SH2_Element.Data.ToResoniteReference(context));
members.Add("SH3", SH3_Element.Data.ToResoniteReference(context));
members.Add("SH4", SH4_Element.Data.ToResoniteReference(context));
members.Add("SH5", SH5_Element.Data.ToResoniteReference(context));
members.Add("SH6", SH6_Element.Data.ToResoniteReference(context));
members.Add("SH7", SH7_Element.Data.ToResoniteReference(context));
members.Add("SH8", SH8_Element.Data.ToResoniteReference(context));
}

}
}
