
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.AsyncObjectFunctionProxy_0002<,,>
// Generated on: pátek 13. února 2026 23:21:49
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.AsyncObjectFunctionProxy_0002<,,>")]
public partial class AsyncObjectFunctionProxy_0002<T0,T1,TResult> : global::FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.DataModelAsyncMethodProxy<global::System.Func<T0,T1,global::System.Threading.Tasks.Task<TResult>>>
	
	
	where T0 : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<T0> Arg0;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T1> Arg1;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<TResult> Result;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Arg0", new ResoniteLink.Reference() { });
members.Add("Arg1", new ResoniteLink.Reference() { });
members.Add("Result", new ResoniteLink.EmptyElement());
}

}
}
