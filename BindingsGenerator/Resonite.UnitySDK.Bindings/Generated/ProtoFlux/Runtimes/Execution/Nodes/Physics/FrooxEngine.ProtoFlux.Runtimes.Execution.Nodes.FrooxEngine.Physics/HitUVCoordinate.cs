
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.HitUVCoordinate
// Generated on: čtvrtek 26. února 2026 15:08:54
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.HitUVCoordinate")]
public partial class HitUVCoordinate : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.ICollider> HitCollider { get => HitCollider_Element.Data; set => HitCollider_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.ICollider>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.ICollider>> HitCollider_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> HitTriangleIndex { get => HitTriangleIndex_Element.Data; set => HitTriangleIndex_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>> HitTriangleIndex_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> HitPoint { get => HitPoint_Element.Data; set => HitPoint_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>> HitPoint_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> UV = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsValidUV = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HitCollider", HitCollider_Element.ToLinkReference(context));
members.Add("HitTriangleIndex", HitTriangleIndex_Element.ToLinkReference(context));
members.Add("HitPoint", HitPoint_Element.ToLinkReference(context));
members.Add("UV", UV.ToLinkEmpty(context));
members.Add("IsValidUV", IsValidUV.ToLinkEmpty(context));
}

}
}
