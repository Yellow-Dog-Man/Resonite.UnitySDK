
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quaternions.ToAxisAngle_floatQ
// Generated on: pátek 13. února 2026 5:52:01
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quaternions.ToAxisAngle_floatQ")]
public partial class ToAxisAngle_floatQ : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Quaternion> Q;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Axis;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Angle;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Q", new ResoniteLink.Reference() { });
members.Add("Axis", new ResoniteLink.EmptyElement());
members.Add("Angle", new ResoniteLink.EmptyElement());
}

}
}
