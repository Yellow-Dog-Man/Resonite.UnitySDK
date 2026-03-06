
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.FingerPose
// Generated on: pátek 6. března 2026 14:18:36
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IFingerPoseSourceComponent> PoseSource { get => PoseSource_Element.Data; set => PoseSource_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IFingerPoseSourceComponent>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IFingerPoseSourceComponent>> PoseSource_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.BodyNode> FingerNode { get => FingerNode_Element.Data; set => FingerNode_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.BodyNode>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.BodyNode>> FingerNode_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Position = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Quaternion> Rotation = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PoseSource", PoseSource_Element.ToLinkReference(context));
members.Add("FingerNode", FingerNode_Element.ToLinkReference(context));
members.Add("Position", Position.ToLinkEmpty(context));
members.Add("Rotation", Rotation.ToLinkEmpty(context));
}

}
}
