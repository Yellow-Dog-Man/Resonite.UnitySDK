
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.LocomotionGripEvent
// Generated on: čtvrtek 19. února 2026 8:00:09
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnEvent", OnEvent.ToResoniteReference(context));
members.Add("GrippedSlot", new ResoniteLink.EmptyElement());
members.Add("GrippedPoint", new ResoniteLink.EmptyElement());
members.Add("GrippingHand", new ResoniteLink.EmptyElement());
}

}
}
