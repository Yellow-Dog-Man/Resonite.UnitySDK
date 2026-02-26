
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.ScaleOrdersSH4<>
// Generated on: čtvrtek 26. února 2026 12:27:42
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.ScaleOrdersSH4<>")]
public partial class ScaleOrdersSH4<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::Elements.Core.SphericalHarmonicsL4<T>>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Elements.Core.SphericalHarmonicsL4<T>> SH { get => SH_Element.Data; set => SH_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Elements.Core.SphericalHarmonicsL4<T>>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Elements.Core.SphericalHarmonicsL4<T>>> SH_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Order0 { get => Order0_Element.Data; set => Order0_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> Order0_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Order1 { get => Order1_Element.Data; set => Order1_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> Order1_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Order2 { get => Order2_Element.Data; set => Order2_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> Order2_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Order3 { get => Order3_Element.Data; set => Order3_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> Order3_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Order4 { get => Order4_Element.Data; set => Order4_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> Order4_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SH", SH_Element.ToLinkReference(context));
members.Add("Order0", Order0_Element.ToLinkReference(context));
members.Add("Order1", Order1_Element.ToLinkReference(context));
members.Add("Order2", Order2_Element.ToLinkReference(context));
members.Add("Order3", Order3_Element.ToLinkReference(context));
members.Add("Order4", Order4_Element.ToLinkReference(context));
}

}
}
