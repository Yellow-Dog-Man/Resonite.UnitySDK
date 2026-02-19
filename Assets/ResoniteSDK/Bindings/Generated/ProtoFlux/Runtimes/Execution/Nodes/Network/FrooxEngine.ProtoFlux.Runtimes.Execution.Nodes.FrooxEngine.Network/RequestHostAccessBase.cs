
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.RequestHostAccessBase
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.RequestHostAccessBase")]
public abstract partial class RequestHostAccessBase : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeOperation OnGranted;
public global::FrooxEngine.ProtoFlux.INodeOperation OnDenied;
public global::FrooxEngine.ProtoFlux.INodeOperation OnIgnored;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnGranted", OnGranted.ToResoniteReference(context));
members.Add("OnDenied", OnDenied.ToResoniteReference(context));
members.Add("OnIgnored", OnIgnored.ToResoniteReference(context));
}

}
}
