
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.WebRequestBase
// Generated on: pátek 13. února 2026 5:52:02
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.WebRequestBase")]
public abstract partial class WebRequestBase : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<System.Uri> URL;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Net.HttpStatusCode> StatusCode;
public global::FrooxEngine.ProtoFlux.INodeOperation OnSent;
public global::FrooxEngine.ProtoFlux.INodeOperation OnResponse;
public global::FrooxEngine.ProtoFlux.INodeOperation OnError;
public global::FrooxEngine.ProtoFlux.INodeOperation OnDenied;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("URL", new ResoniteLink.Reference() { });
members.Add("StatusCode", new ResoniteLink.EmptyElement());
members.Add("OnSent", new ResoniteLink.Reference() { });
members.Add("OnResponse", new ResoniteLink.Reference() { });
members.Add("OnError", new ResoniteLink.Reference() { });
members.Add("OnDenied", new ResoniteLink.Reference() { });
}

}
}
