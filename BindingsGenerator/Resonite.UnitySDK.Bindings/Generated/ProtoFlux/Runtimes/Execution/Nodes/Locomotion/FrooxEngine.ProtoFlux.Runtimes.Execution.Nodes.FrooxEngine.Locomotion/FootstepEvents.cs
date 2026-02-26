
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Locomotion.FootstepEvents
// Generated on: čtvrtek 26. února 2026 12:27:35
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Locomotion
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Locomotion.FootstepEvents")]
public partial class FootstepEvents : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.IFootstepEventRelay> Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.IFootstepEventRelay>>, global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.IFootstepEventRelay>> Source_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation Footstep { get => Footstep_Element.Data; set => Footstep_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> Footstep_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::Renderite.Shared.Chirality> Side = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Position = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Quaternion> Rotation = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> ImpactVelocity = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> HasLanded = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.ICollider> HitCollider = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> HitTriangleIndex = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source_Element.ToLinkReference(context));
members.Add("Footstep", Footstep_Element.ToLinkReference(context));
members.Add("Side", Side.ToLinkEmpty(context));
members.Add("Position", Position.ToLinkEmpty(context));
members.Add("Rotation", Rotation.ToLinkEmpty(context));
members.Add("ImpactVelocity", ImpactVelocity.ToLinkEmpty(context));
members.Add("HasLanded", HasLanded.ToLinkEmpty(context));
members.Add("HitCollider", HitCollider.ToLinkEmpty(context));
members.Add("HitTriangleIndex", HitTriangleIndex.ToLinkEmpty(context));
}

}
}
