
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.RequestHostAccessUrl
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.RequestHostAccessUrl")]
public partial class RequestHostAccessUrl : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.RequestHostAccessBase

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<System.Uri> Host;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Reason;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.HostAccessScope> Scope;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Host", new ResoniteLink.Reference() { });
members.Add("Reason", new ResoniteLink.Reference() { });
members.Add("Scope", new ResoniteLink.Reference() { });
}

}
}
