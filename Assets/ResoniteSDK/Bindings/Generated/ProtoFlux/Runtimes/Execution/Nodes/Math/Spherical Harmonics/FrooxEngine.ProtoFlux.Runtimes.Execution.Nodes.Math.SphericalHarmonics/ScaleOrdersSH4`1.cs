
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.ScaleOrdersSH4<>
// Generated on: pátek 13. února 2026 5:52:01
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Elements.Core.SphericalHarmonicsL4<T>> SH;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Order0;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Order1;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Order2;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Order3;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Order4;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("SH", new ResoniteLink.Reference() { });
members.Add("Order0", new ResoniteLink.Reference() { });
members.Add("Order1", new ResoniteLink.Reference() { });
members.Add("Order2", new ResoniteLink.Reference() { });
members.Add("Order3", new ResoniteLink.Reference() { });
members.Add("Order4", new ResoniteLink.Reference() { });
}

}
}
