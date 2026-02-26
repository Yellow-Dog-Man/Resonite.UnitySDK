
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.WebRequestBase
// Generated on: čtvrtek 26. února 2026 15:08:46
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.WebRequestBase")]
public abstract partial class WebRequestBase : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<System.Uri> URL { get => URL_Element.Data; set => URL_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<System.Uri>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<System.Uri>> URL_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Net.HttpStatusCode> StatusCode = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnSent { get => OnSent_Element.Data; set => OnSent_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnSent_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnResponse { get => OnResponse_Element.Data; set => OnResponse_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnResponse_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnError { get => OnError_Element.Data; set => OnError_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnError_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnDenied { get => OnDenied_Element.Data; set => OnDenied_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnDenied_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("URL", URL_Element.ToLinkReference(context));
members.Add("StatusCode", StatusCode.ToLinkEmpty(context));
members.Add("OnSent", OnSent_Element.ToLinkReference(context));
members.Add("OnResponse", OnResponse_Element.ToLinkReference(context));
members.Add("OnError", OnError_Element.ToLinkReference(context));
members.Add("OnDenied", OnDenied_Element.ToLinkReference(context));
}

}
}
