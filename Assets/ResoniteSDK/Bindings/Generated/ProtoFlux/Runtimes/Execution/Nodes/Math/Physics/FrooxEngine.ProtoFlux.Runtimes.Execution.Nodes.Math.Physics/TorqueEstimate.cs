
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Physics.TorqueEstimate
// Generated on: pátek 13. února 2026 5:52:00
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Physics
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Physics.TorqueEstimate")]
public partial class TorqueEstimate : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Quaternion>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> InitialTorque;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Drag;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Time;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("InitialTorque", new ResoniteLink.Reference() { });
members.Add("Drag", new ResoniteLink.Reference() { });
members.Add("Time", new ResoniteLink.Reference() { });
}

}
}
