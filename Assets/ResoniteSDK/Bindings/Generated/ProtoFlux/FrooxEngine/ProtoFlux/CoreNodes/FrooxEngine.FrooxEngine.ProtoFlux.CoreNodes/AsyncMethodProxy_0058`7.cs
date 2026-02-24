
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.AsyncMethodProxy_0058<,,,,,,>
// Generated on: úterý 24. února 2026 18:18:01
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.AsyncMethodProxy_0058<,,,,,,>")]
public partial class AsyncMethodProxy_0058<T0,T1,T2,T3,T4,T5,T6> : global::FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.DataModelAsyncMethodProxy<global::System.Func<T0,T1,T2,T3,T4,T5,T6,global::System.Threading.Tasks.Task>>
	
	where T5 : struct
	
	
	where T2 : struct
	where T1 : struct
	where T0 : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<T0> Arg0;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T1> Arg1;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T2> Arg2;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T3> Arg3;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T4> Arg4;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T5> Arg5;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T6> Arg6;

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
}

}
}
