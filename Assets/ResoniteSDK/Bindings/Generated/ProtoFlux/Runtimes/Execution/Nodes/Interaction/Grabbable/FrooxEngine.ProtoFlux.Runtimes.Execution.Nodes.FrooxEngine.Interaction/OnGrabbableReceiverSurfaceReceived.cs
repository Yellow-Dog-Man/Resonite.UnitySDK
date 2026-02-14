
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.OnGrabbableReceiverSurfaceReceived
// Generated on: sobota 14. února 2026 8:58:00
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.GrabbableReceiverSurface> Source;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnReceived;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.IGrabbable> ReceivedGrabbable;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.Grabber> FromGrabber;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source.ToResoniteReference(context));
members.Add("OnReceived", OnReceived.ToResoniteReference(context));
members.Add("ReceivedGrabbable", new ResoniteLink.EmptyElement());
members.Add("FromGrabber", new ResoniteLink.EmptyElement());
}

}
}
