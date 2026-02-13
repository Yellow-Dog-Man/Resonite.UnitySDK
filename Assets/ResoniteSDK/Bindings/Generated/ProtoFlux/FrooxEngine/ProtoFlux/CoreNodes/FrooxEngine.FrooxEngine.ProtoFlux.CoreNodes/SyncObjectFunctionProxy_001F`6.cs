
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.SyncObjectFunctionProxy_001F<,,,,,>
// Generated on: pátek 13. února 2026 23:22:07
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.SyncObjectFunctionProxy_001F<,,,,,>")]
public partial class SyncObjectFunctionProxy_001F<T0,T1,T2,T3,T4,TResult> : global::FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.DataModelMethodProxy<global::System.Func<T0,T1,T2,T3,T4,TResult>>
	
	
	
	
	
	

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T0> Arg0;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T1> Arg1;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T2> Arg2;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T3> Arg3;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T4> Arg4;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<TResult> Result;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Arg0", new ResoniteLink.Reference() { });
members.Add("Arg1", new ResoniteLink.Reference() { });
members.Add("Arg2", new ResoniteLink.Reference() { });
members.Add("Arg3", new ResoniteLink.Reference() { });
members.Add("Arg4", new ResoniteLink.Reference() { });
members.Add("Result", new ResoniteLink.EmptyElement());
}

}
}
