
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds.UserJoined
// Generated on: úterý 24. února 2026 18:20:01
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds.UserJoined")]
public partial class UserJoined : global::FrooxEngine.FrooxEngine.ProtoFlux.ProxyVoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds.UserJoined.Proxy>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> OnlyHost;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnJoined;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.User> JoinedUser;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnlyHost", OnlyHost.ToResoniteReference(context));
members.Add("OnJoined", OnJoined.ToResoniteReference(context));
members.Add("JoinedUser", new ResoniteLink.EmptyElement());
}

}
}
