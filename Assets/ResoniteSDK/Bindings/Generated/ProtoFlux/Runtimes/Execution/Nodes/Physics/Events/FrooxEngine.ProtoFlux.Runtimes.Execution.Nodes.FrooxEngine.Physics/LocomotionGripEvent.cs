
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.LocomotionGripEvent
// Generated on: pátek 13. února 2026 23:22:52
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.LocomotionGripEvent")]
public abstract partial class LocomotionGripEvent : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.LocomotionEvents

{
    public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnEvent;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.Slot> GrippedSlot;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> GrippedPoint;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::Renderite.Shared.Chirality> GrippingHand;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("OnEvent", new ResoniteLink.Reference() { });
members.Add("GrippedSlot", new ResoniteLink.EmptyElement());
members.Add("GrippedPoint", new ResoniteLink.EmptyElement());
members.Add("GrippingHand", new ResoniteLink.EmptyElement());
}

}
}
