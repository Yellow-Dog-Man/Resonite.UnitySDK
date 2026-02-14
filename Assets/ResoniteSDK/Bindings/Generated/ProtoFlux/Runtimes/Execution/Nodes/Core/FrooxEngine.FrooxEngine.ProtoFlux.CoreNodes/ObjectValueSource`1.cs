
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.ObjectValueSource<>
// Generated on: sobota 14. února 2026 8:57:49
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.ObjectValueSource<>")]
public partial class ObjectValueSource<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,T>, global::FrooxEngine.ProtoFlux.Runtimes.Execution.IVariable<global::FrooxEngine.ProtoFlux.FrooxEngineContext,T>, global::FrooxEngine.ProtoFlux.IProtoFluxNode<global::ProtoFlux.Runtimes.Execution.IVariable<global::FrooxEngine.ProtoFlux.FrooxEngineContext,T>>, global::FrooxEngine.ProtoFlux.CoreNodes.ISource
	

{
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.IValue<T>> Source;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source.ToResoniteReference(context));
}

}
}
