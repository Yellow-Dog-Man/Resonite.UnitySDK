
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quaternions.AngularVelocityDelta_floatQ
// Generated on: pátek 13. února 2026 23:22:38
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quaternions.AngularVelocityDelta_floatQ")]
public partial class AngularVelocityDelta_floatQ : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Quaternion>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> AngularVelocity;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> DeltaTime;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("AngularVelocity", new ResoniteLink.Reference() { });
members.Add("DeltaTime", new ResoniteLink.Reference() { });
}

}
}
