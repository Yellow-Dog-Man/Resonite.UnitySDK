
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Locomotion.FootstepEvents
// Generated on: pátek 13. února 2026 23:22:31
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.IFootstepEventRelay> Source;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation Footstep;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::Renderite.Shared.Chirality> Side;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Position;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Quaternion> Rotation;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> ImpactVelocity;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> HasLanded;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.ICollider> HitCollider;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> HitTriangleIndex;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Source", new ResoniteLink.Reference() { });
members.Add("Footstep", new ResoniteLink.Reference() { });
members.Add("Side", new ResoniteLink.EmptyElement());
members.Add("Position", new ResoniteLink.EmptyElement());
members.Add("Rotation", new ResoniteLink.EmptyElement());
members.Add("ImpactVelocity", new ResoniteLink.EmptyElement());
members.Add("HasLanded", new ResoniteLink.EmptyElement());
members.Add("HitCollider", new ResoniteLink.EmptyElement());
members.Add("HitTriangleIndex", new ResoniteLink.EmptyElement());
}

}
}
