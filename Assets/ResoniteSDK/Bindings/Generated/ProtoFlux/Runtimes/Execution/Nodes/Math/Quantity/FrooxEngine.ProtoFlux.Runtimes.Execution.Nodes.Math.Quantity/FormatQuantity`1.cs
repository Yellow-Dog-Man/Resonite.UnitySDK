
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quantity.FormatQuantity<>
// Generated on: úterý 24. února 2026 18:19:27
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quantity
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quantity.FormatQuantity<>")]
public partial class FormatQuantity<U> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.String>
	where U : struct, global::Elements.Quantity.IQuantity<U>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<U> Value;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> FormatUnit;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> FormatNumber;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> UseLongNames;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value", Value.ToResoniteReference(context));
members.Add("FormatUnit", FormatUnit.ToResoniteReference(context));
members.Add("FormatNumber", FormatNumber.ToResoniteReference(context));
members.Add("UseLongNames", UseLongNames.ToResoniteReference(context));
}

}
}
