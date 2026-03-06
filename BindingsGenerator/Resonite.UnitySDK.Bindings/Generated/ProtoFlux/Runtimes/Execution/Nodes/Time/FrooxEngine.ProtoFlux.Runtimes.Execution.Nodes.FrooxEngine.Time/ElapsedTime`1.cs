
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Time.ElapsedTime<>
// Generated on: pátek 6. března 2026 14:18:58
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public global::FrooxEngine.ProtoFlux.SyncNodeOperation Reset = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnReset { get => OnReset_Element.Data; set => OnReset_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnReset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Reset", Reset.ToLinkEmpty(context));
members.Add("OnReset", OnReset_Element.ToLinkReference(context));
}

}
}
