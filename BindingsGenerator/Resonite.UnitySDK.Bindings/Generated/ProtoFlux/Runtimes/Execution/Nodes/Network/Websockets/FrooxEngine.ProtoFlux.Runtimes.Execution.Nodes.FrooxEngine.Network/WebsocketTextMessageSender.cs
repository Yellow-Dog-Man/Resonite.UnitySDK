
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.WebsocketTextMessageSender
// Generated on: středa 25. února 2026 16:13:55
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.WebsocketTextMessageSender")]
public partial class WebsocketTextMessageSender : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.WebsocketClient> Client;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Data;
public global::FrooxEngine.ProtoFlux.INodeOperation OnSendStart;
public global::FrooxEngine.ProtoFlux.INodeOperation OnSent;
public global::FrooxEngine.ProtoFlux.INodeOperation OnSendError;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Client", Client.ToResoniteReference(context));
members.Add("Data", Data.ToResoniteReference(context));
members.Add("OnSendStart", OnSendStart.ToResoniteReference(context));
members.Add("OnSent", OnSent.ToResoniteReference(context));
members.Add("OnSendError", OnSendError.ToResoniteReference(context));
}

}
}
