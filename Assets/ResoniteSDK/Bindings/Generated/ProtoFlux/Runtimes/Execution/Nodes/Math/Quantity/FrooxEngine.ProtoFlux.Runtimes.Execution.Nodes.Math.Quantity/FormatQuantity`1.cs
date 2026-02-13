
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quantity.FormatQuantity<>
// Generated on: pátek 13. února 2026 23:22:38
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quantity.FormatQuantity<>")]
public partial class FormatQuantity<U> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.String>
	where U : struct, global::Elements.Quantity.IQuantity<U>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<U> Value;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> FormatUnit;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> FormatNumber;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> UseLongNames;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Value", new ResoniteLink.Reference() { });
members.Add("FormatUnit", new ResoniteLink.Reference() { });
members.Add("FormatNumber", new ResoniteLink.Reference() { });
members.Add("UseLongNames", new ResoniteLink.Reference() { });
}

}
}
