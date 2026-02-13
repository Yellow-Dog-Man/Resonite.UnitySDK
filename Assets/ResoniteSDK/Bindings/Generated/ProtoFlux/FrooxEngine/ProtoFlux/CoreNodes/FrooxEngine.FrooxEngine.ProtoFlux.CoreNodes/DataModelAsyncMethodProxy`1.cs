
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.DataModelAsyncMethodProxy<>
// Generated on: pátek 13. února 2026 23:21:43
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.DataModelAsyncMethodProxy<>")]
public abstract partial class DataModelAsyncMethodProxy<D> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionBreakableFlowNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>
	where D : global::System.Delegate

{
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<D> Method;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Method", new ResoniteLink.Reference() { });
}

}
}
