
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.OnGrabbableReceiverSurfaceReceived
// Generated on: čtvrtek 26. února 2026 12:27:35
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.OnGrabbableReceiverSurfaceReceived")]
public partial class OnGrabbableReceiverSurfaceReceived : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.GrabbableReceiverSurface> Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.GrabbableReceiverSurface>>, global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.GrabbableReceiverSurface>> Source_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnReceived { get => OnReceived_Element.Data; set => OnReceived_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> OnReceived_Element = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.IGrabbable> ReceivedGrabbable = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.Grabber> FromGrabber = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source_Element.ToLinkReference(context));
members.Add("OnReceived", OnReceived_Element.ToLinkReference(context));
members.Add("ReceivedGrabbable", ReceivedGrabbable.ToLinkEmpty(context));
members.Add("FromGrabber", FromGrabber.ToLinkEmpty(context));
}

}
}
