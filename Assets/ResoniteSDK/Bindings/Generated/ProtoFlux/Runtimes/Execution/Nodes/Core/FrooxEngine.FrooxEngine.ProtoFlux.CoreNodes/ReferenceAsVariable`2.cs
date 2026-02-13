
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.ReferenceAsVariable<,>
// Generated on: pátek 13. února 2026 23:22:21
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.ReferenceAsVariable<,>")]
public abstract partial class ReferenceAsVariable<T,R> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::ProtoFlux.Runtimes.Execution.IVariable<global::FrooxEngine.ProtoFlux.FrooxEngineContext,T>>, global::FrooxEngine.ProtoFlux.Runtimes.Execution.IVariable<global::FrooxEngine.ProtoFlux.FrooxEngineContext,T>, global::FrooxEngine.ProtoFlux.IProtoFluxNode<global::ProtoFlux.Runtimes.Execution.IVariable<global::FrooxEngine.ProtoFlux.FrooxEngineContext,T>>
	where R : global::FrooxEngine.ISyncRef<T>
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<R> Reference;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Reference", new ResoniteLink.Reference() { });
}

}
}
