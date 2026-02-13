
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.PackSH1<>
// Generated on: pátek 13. února 2026 23:22:39
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.PackSH1<>")]
public partial class PackSH1<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::Elements.Core.SphericalHarmonicsL1<T>>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH0;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH1;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH2;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SH3;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("SH0", new ResoniteLink.Reference() { });
members.Add("SH1", new ResoniteLink.Reference() { });
members.Add("SH2", new ResoniteLink.Reference() { });
members.Add("SH3", new ResoniteLink.Reference() { });
}

}
}
