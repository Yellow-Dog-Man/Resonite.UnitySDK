
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.RequestHostAccessUrl
// Generated on: čtvrtek 19. února 2026 8:00:01
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.RequestHostAccessUrl")]
public partial class RequestHostAccessUrl : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.RequestHostAccessBase

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<System.Uri> Host;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Reason;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.HostAccessScope> Scope;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Host", Host.ToResoniteReference(context));
members.Add("Reason", Reason.ToResoniteReference(context));
members.Add("Scope", Scope.ToResoniteReference(context));
}

}
}
