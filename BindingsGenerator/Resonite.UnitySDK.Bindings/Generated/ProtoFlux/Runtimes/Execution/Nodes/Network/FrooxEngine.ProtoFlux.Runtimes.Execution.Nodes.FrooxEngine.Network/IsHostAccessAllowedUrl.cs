
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.IsHostAccessAllowedUrl
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.IsHostAccessAllowedUrl")]
public partial class IsHostAccessAllowedUrl : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::System.Boolean>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<System.Uri> Host { get => Host_Element.Data; set => Host_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<System.Uri>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<System.Uri>> Host_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.HostAccessScope> Scope { get => Scope_Element.Data; set => Scope_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.HostAccessScope>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.HostAccessScope>> Scope_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Host", Host_Element.ToLinkReference(context));
members.Add("Scope", Scope_Element.ToLinkReference(context));
}

}
}
