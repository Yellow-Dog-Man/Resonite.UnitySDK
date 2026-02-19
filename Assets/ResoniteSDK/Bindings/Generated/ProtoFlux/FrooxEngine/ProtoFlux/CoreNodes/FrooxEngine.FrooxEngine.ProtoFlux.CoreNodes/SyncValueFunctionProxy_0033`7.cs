
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.SyncValueFunctionProxy_0033<,,,,,,>
// Generated on: čtvrtek 19. února 2026 7:59:37
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.SyncValueFunctionProxy_0033<,,,,,,>")]
public partial class SyncValueFunctionProxy_0033<T0,T1,T2,T3,T4,T5,TResult> : global::FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.DataModelMethodProxy<global::System.Func<T0,T1,T2,T3,T4,T5,TResult>>
	where TResult : struct
	
	
	where T3 : struct
	where T2 : struct
	
	

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T0> Arg0;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T1> Arg1;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T2> Arg2;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T3> Arg3;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T4> Arg4;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T5> Arg5;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<TResult> Result;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Arg0", Arg0.ToResoniteReference(context));
members.Add("Arg1", Arg1.ToResoniteReference(context));
members.Add("Arg2", Arg2.ToResoniteReference(context));
members.Add("Arg3", Arg3.ToResoniteReference(context));
members.Add("Arg4", Arg4.ToResoniteReference(context));
members.Add("Arg5", Arg5.ToResoniteReference(context));
members.Add("Result", new ResoniteLink.EmptyElement());
}

}
}
