
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.AsyncMethodProxy_007D<,,,,,,>
// Generated on: pátek 13. února 2026 23:21:47
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.AsyncMethodProxy_007D<,,,,,,>")]
public partial class AsyncMethodProxy_007D<T0,T1,T2,T3,T4,T5,T6> : global::FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.DataModelAsyncMethodProxy<global::System.Func<T0,T1,T2,T3,T4,T5,T6,global::System.Threading.Tasks.Task>>
	
	
	
	
	
	where T1 : struct
	

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T0> Arg0;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T1> Arg1;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T2> Arg2;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T3> Arg3;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T4> Arg4;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T5> Arg5;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T6> Arg6;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Arg0", new ResoniteLink.Reference() { });
members.Add("Arg1", new ResoniteLink.Reference() { });
members.Add("Arg2", new ResoniteLink.Reference() { });
members.Add("Arg3", new ResoniteLink.Reference() { });
members.Add("Arg4", new ResoniteLink.Reference() { });
members.Add("Arg5", new ResoniteLink.Reference() { });
members.Add("Arg6", new ResoniteLink.Reference() { });
}

}
}
