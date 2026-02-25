
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds.UserLeft
// Generated on: středa 25. února 2026 16:14:14
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds.UserLeft")]
public partial class UserLeft : global::FrooxEngine.FrooxEngine.ProtoFlux.ProxyVoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds.UserLeft.Proxy>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> OnlyHost;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnLeft;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.User> LeftUser;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnlyHost", OnlyHost.ToResoniteReference(context));
members.Add("OnLeft", OnLeft.ToResoniteReference(context));
members.Add("LeftUser", new ResoniteLink.EmptyElement());
}

}
}
