
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.FingerPose
// Generated on: úterý 24. února 2026 18:18:57
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.FingerPose")]
public partial class FingerPose : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IFingerPoseSourceComponent> PoseSource;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.BodyNode> FingerNode;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Position;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Quaternion> Rotation;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PoseSource", PoseSource.ToResoniteReference(context));
members.Add("FingerNode", FingerNode.ToResoniteReference(context));
members.Add("Position", new ResoniteLink.EmptyElement());
members.Add("Rotation", new ResoniteLink.EmptyElement());
}

}
}
