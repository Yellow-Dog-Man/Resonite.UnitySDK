
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.AsyncValueFunctionProxy_0035<,,,,,,,>
// Generated on: středa 25. února 2026 16:13:21
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.AsyncValueFunctionProxy_0035<,,,,,,,>")]
public partial class AsyncValueFunctionProxy_0035<T0,T1,T2,T3,T4,T5,T6,TResult> : global::FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.DataModelAsyncMethodProxy<global::System.Func<T0,T1,T2,T3,T4,T5,T6,global::System.Threading.Tasks.Task<TResult>>>
	where TResult : struct
	where T6 : struct
	
	
	where T3 : struct
	
	where T1 : struct
	

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T0> Arg0;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T1> Arg1;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T2> Arg2;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T3> Arg3;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T4> Arg4;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T5> Arg5;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T6> Arg6;
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
members.Add("Arg6", Arg6.ToResoniteReference(context));
members.Add("Result", new ResoniteLink.EmptyElement());
}

}
}
