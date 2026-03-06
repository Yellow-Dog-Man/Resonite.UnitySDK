
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quantity.ParseQuantity<>
// Generated on: pátek 6. března 2026 14:18:48
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Str { get => Str_Element.Data; set => Str_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> Str_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> DefaultUnit { get => DefaultUnit_Element.Data; set => DefaultUnit_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> DefaultUnit_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<U> Value = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsParsed = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Str", Str_Element.ToLinkReference(context));
members.Add("DefaultUnit", DefaultUnit_Element.ToLinkReference(context));
members.Add("Value", Value.ToLinkEmpty(context));
members.Add("IsParsed", IsParsed.ToLinkEmpty(context));
}

}
}
