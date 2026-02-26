
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.WebsocketTextMessageSender
// Generated on: čtvrtek 26. února 2026 15:08:47
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.WebsocketClient> Client { get => Client_Element.Data; set => Client_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.WebsocketClient>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.WebsocketClient>> Client_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Data { get => Data_Element.Data; set => Data_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> Data_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnSendStart { get => OnSendStart_Element.Data; set => OnSendStart_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnSendStart_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnSent { get => OnSent_Element.Data; set => OnSent_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnSent_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnSendError { get => OnSendError_Element.Data; set => OnSendError_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnSendError_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Client", Client_Element.ToLinkReference(context));
members.Add("Data", Data_Element.ToLinkReference(context));
members.Add("OnSendStart", OnSendStart_Element.ToLinkReference(context));
members.Add("OnSent", OnSent_Element.ToLinkReference(context));
members.Add("OnSendError", OnSendError_Element.ToLinkReference(context));
}

}
}
