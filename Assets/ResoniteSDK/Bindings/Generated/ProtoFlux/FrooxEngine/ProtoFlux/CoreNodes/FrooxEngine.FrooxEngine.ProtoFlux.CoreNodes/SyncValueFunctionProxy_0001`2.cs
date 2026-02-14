
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.SyncValueFunctionProxy_0001<,>
// Generated on: sobota 14. února 2026 8:57:39
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.SyncValueFunctionProxy_0001<,>")]
public partial class SyncValueFunctionProxy_0001<T0,TResult> : global::FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.DataModelMethodProxy<global::System.Func<T0,TResult>>
	where TResult : struct
	

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T0> Arg0;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<TResult> Result;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Arg0", Arg0.ToResoniteReference(context));
members.Add("Result", new ResoniteLink.EmptyElement());
}

}
}
