
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quaternions.ToAxisAngle_doubleQ
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quaternions.ToAxisAngle_doubleQ")]
public partial class ToAxisAngle_doubleQ : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.QuaternionDouble> Q;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3Double> Axis;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Double> Angle;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Q", new ResoniteLink.Reference() { });
members.Add("Axis", new ResoniteLink.EmptyElement());
members.Add("Angle", new ResoniteLink.EmptyElement());
}

}
}
