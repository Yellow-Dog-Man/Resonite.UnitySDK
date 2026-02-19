
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.WebRequestBase
// Generated on: čtvrtek 19. února 2026 8:00:00
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("URL", URL.ToResoniteReference(context));
members.Add("StatusCode", new ResoniteLink.EmptyElement());
members.Add("OnSent", OnSent.ToResoniteReference(context));
members.Add("OnResponse", OnResponse.ToResoniteReference(context));
members.Add("OnError", OnError.ToResoniteReference(context));
members.Add("OnDenied", OnDenied.ToResoniteReference(context));
}

}
}
