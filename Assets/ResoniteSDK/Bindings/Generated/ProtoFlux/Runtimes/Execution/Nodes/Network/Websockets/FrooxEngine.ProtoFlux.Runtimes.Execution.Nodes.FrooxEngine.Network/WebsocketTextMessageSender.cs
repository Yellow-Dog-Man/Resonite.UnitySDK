
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.WebsocketTextMessageSender
// Generated on: pátek 13. února 2026 23:22:41
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Client", new ResoniteLink.Reference() { });
members.Add("Data", new ResoniteLink.Reference() { });
members.Add("OnSendStart", new ResoniteLink.Reference() { });
members.Add("OnSent", new ResoniteLink.Reference() { });
members.Add("OnSendError", new ResoniteLink.Reference() { });
}

}
}
