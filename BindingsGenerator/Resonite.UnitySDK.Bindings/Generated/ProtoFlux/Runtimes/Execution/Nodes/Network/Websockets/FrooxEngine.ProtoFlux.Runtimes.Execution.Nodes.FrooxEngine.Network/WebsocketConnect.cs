
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.WebsocketConnect
// Generated on: pátek 6. března 2026 14:18:50
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.WebsocketConnect")]
public partial class WebsocketConnect : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionBreakableFlowNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.WebsocketClient> Client { get => Client_Element.Data; set => Client_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.WebsocketClient>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.WebsocketClient>> Client_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<System.Uri> URL { get => URL_Element.Data; set => URL_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<System.Uri>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<System.Uri>> URL_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User> HandlingUser { get => HandlingUser_Element.Data; set => HandlingUser_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User>> HandlingUser_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Client", Client_Element.ToLinkReference(context));
members.Add("URL", URL_Element.ToLinkReference(context));
members.Add("HandlingUser", HandlingUser_Element.ToLinkReference(context));
}

}
}
