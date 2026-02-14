
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quantity.ParseQuantity<>
// Generated on: sobota 14. února 2026 8:58:08
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quantity
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quantity.ParseQuantity<>")]
public partial class ParseQuantity<U> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>
	where U : struct, global::Elements.Quantity.IQuantity<U>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Str;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> DefaultUnit;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<U> Value;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsParsed;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Str", Str.ToResoniteReference(context));
members.Add("DefaultUnit", DefaultUnit.ToResoniteReference(context));
members.Add("Value", new ResoniteLink.EmptyElement());
members.Add("IsParsed", new ResoniteLink.EmptyElement());
}

}
}
