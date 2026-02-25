
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.DataModelAsyncMethodProxy<>
// Generated on: středa 25. února 2026 16:13:12
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.DataModelAsyncMethodProxy<>")]
public abstract partial class DataModelAsyncMethodProxy<D> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionBreakableFlowNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>
	where D : global::System.Delegate

{
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<D> Method;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Method", Method.ToResoniteReference(context));
}

}
}
