
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.Tools.GetRawDataToolHit
// Generated on: čtvrtek 26. února 2026 12:27:57
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.Tools
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.Tools.GetRawDataToolHit")]
public partial class GetRawDataToolHit : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.RawDataTool> Tool { get => Tool_Element.Data; set => Tool_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.RawDataTool>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.RawDataTool>> Tool_Element = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.ICollider> HitCollider = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> HitPoint = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> HitNormal = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> HitDistance = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> HitTriangleIndex = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Tool", Tool_Element.ToLinkReference(context));
members.Add("HitCollider", HitCollider.ToLinkEmpty(context));
members.Add("HitPoint", HitPoint.ToLinkEmpty(context));
members.Add("HitNormal", HitNormal.ToLinkEmpty(context));
members.Add("HitDistance", HitDistance.ToLinkEmpty(context));
members.Add("HitTriangleIndex", HitTriangleIndex.ToLinkEmpty(context));
}

}
}
