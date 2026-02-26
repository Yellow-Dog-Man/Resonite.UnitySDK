
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.AsyncObjectFunctionProxy<>
// Generated on: čtvrtek 26. února 2026 12:27:07
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.AsyncObjectFunctionProxy<>")]
public partial class AsyncObjectFunctionProxy<TResult> : global::FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.DataModelAsyncMethodProxy<global::System.Func<global::System.Threading.Tasks.Task<TResult>>>
	

{
    public global::FrooxEngine.ProtoFlux.NodeObjectOutput<TResult> Result = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Result", Result.ToLinkEmpty(context));
}

}
}
