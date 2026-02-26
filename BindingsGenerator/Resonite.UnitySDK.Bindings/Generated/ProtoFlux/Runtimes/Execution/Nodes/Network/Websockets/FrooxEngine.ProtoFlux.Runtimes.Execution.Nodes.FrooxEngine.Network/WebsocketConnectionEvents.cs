
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.WebsocketConnectionEvents
// Generated on: čtvrtek 26. února 2026 12:27:45
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.WebsocketConnectionEvents")]
public partial class WebsocketConnectionEvents : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.WebsocketEvents

{
    public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnConnected { get => OnConnected_Element.Data; set => OnConnected_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> OnConnected_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnDisconnected { get => OnDisconnected_Element.Data; set => OnDisconnected_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> OnDisconnected_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnConnected", OnConnected_Element.ToLinkReference(context));
members.Add("OnDisconnected", OnDisconnected_Element.ToLinkReference(context));
}

}
}
