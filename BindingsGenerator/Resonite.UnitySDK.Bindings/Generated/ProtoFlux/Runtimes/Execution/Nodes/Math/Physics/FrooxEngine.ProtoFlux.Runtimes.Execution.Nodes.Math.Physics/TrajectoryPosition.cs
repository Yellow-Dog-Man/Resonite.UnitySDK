
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Physics.TrajectoryPosition
// Generated on: středa 25. února 2026 16:13:53
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Physics
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Physics.TrajectoryPosition")]
public partial class TrajectoryPosition : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Vector3>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> InitialVelocity;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Gravity;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Drag;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Time;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("InitialVelocity", InitialVelocity.ToResoniteReference(context));
members.Add("Gravity", Gravity.ToResoniteReference(context));
members.Add("Drag", Drag.ToResoniteReference(context));
members.Add("Time", Time.ToResoniteReference(context));
}

}
}
