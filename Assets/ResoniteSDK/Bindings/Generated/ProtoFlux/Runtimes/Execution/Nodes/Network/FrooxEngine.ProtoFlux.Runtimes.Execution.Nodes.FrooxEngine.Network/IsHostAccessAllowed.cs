
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.IsHostAccessAllowed
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.IsHostAccessAllowed")]
public partial class IsHostAccessAllowed : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::System.Boolean>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Host;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Port;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.HostAccessScope> Scope;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Host", new ResoniteLink.Reference() { });
members.Add("Port", new ResoniteLink.Reference() { });
members.Add("Scope", new ResoniteLink.Reference() { });
}

}
}
