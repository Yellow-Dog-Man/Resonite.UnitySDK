
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Time.ElapsedTime<>
// Generated on: pátek 13. února 2026 23:22:56
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Time
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Time.ElapsedTime<>")]
public abstract partial class ElapsedTime<T> : global::FrooxEngine.FrooxEngine.ProtoFlux.ProxyValueFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Time.ElapsedTime<T>.Proxy,T>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.SyncNodeOperation Reset;
public global::FrooxEngine.ProtoFlux.INodeOperation OnReset;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Reset", new ResoniteLink.EmptyElement());
members.Add("OnReset", new ResoniteLink.Reference() { });
}

}
}
