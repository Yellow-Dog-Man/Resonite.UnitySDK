
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quantity.ParseQuantity<>
// Generated on: pátek 13. února 2026 5:52:00
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Str", new ResoniteLink.Reference() { });
members.Add("DefaultUnit", new ResoniteLink.Reference() { });
members.Add("Value", new ResoniteLink.EmptyElement());
members.Add("IsParsed", new ResoniteLink.EmptyElement());
}

}
}
