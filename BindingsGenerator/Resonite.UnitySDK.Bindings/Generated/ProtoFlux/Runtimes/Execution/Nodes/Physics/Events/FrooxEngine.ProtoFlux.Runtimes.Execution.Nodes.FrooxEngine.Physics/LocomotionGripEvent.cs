
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.LocomotionGripEvent
// Generated on: čtvrtek 26. února 2026 15:08:55
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.LocomotionGripEvent")]
public abstract partial class LocomotionGripEvent : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.LocomotionEvents

{
    public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnEvent { get => OnEvent_Element.Data; set => OnEvent_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> OnEvent_Element = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.Slot> GrippedSlot = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> GrippedPoint = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::Renderite.Shared.Chirality> GrippingHand = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnEvent", OnEvent_Element.ToLinkReference(context));
members.Add("GrippedSlot", GrippedSlot.ToLinkEmpty(context));
members.Add("GrippedPoint", GrippedPoint.ToLinkEmpty(context));
members.Add("GrippingHand", GrippingHand.ToLinkEmpty(context));
}

}
}
