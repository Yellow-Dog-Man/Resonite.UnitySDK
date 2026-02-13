
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quaternions.FromToRotation_doubleQ
// Generated on: pátek 13. února 2026 23:22:39
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quaternions
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quaternions.FromToRotation_doubleQ")]
public partial class FromToRotation_doubleQ : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.QuaternionDouble>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Double> From;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Double> To;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("From", new ResoniteLink.Reference() { });
members.Add("To", new ResoniteLink.Reference() { });
}

}
}
