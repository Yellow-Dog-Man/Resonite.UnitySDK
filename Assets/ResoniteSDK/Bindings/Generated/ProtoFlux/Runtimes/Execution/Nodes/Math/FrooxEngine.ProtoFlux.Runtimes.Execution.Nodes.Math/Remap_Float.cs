
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Remap_Float
// Generated on: pátek 13. února 2026 23:22:35
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Remap_Float")]
public partial class Remap_Float : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.Single>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> InMin;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> InMax;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> OutMin;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> OutMax;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Value;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("InMin", new ResoniteLink.Reference() { });
members.Add("InMax", new ResoniteLink.Reference() { });
members.Add("OutMin", new ResoniteLink.Reference() { });
members.Add("OutMax", new ResoniteLink.Reference() { });
members.Add("Value", new ResoniteLink.Reference() { });
}

}
}
