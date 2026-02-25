
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.Tools.GetRawDataToolHit
// Generated on: středa 25. února 2026 16:14:10
// Resonite version: 2026.2.25.455
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
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.RawDataTool> Tool;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.ICollider> HitCollider;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> HitPoint;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> HitNormal;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> HitDistance;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> HitTriangleIndex;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Tool", Tool.ToResoniteReference(context));
members.Add("HitCollider", new ResoniteLink.EmptyElement());
members.Add("HitPoint", new ResoniteLink.EmptyElement());
members.Add("HitNormal", new ResoniteLink.EmptyElement());
members.Add("HitDistance", new ResoniteLink.EmptyElement());
members.Add("HitTriangleIndex", new ResoniteLink.EmptyElement());
}

}
}
