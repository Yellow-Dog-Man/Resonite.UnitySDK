
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.CubicLerp_Float
// Generated on: pátek 13. února 2026 5:51:59
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.CubicLerp_Float")]
public partial class CubicLerp_Float : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.Single>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::ProtoFlux.Runtimes.Execution.Nodes.Math.TangentPointFloat> From;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::ProtoFlux.Runtimes.Execution.Nodes.Math.TangentPointFloat> To;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Lerp;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("From", new ResoniteLink.Reference() { });
members.Add("To", new ResoniteLink.Reference() { });
members.Add("Lerp", new ResoniteLink.Reference() { });
}

}
}
