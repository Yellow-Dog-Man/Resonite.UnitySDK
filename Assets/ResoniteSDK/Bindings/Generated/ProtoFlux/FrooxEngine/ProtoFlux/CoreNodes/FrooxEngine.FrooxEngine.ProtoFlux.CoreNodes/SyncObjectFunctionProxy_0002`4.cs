
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.SyncObjectFunctionProxy_0002<,,,>
// Generated on: sobota 14. února 2026 8:57:33
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.SyncObjectFunctionProxy_0002<,,,>")]
public partial class SyncObjectFunctionProxy_0002<T0,T1,T2,TResult> : global::FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.DataModelMethodProxy<global::System.Func<T0,T1,T2,TResult>>
	
	where T2 : struct
	
	where T0 : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<T0> Arg0;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T1> Arg1;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T2> Arg2;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<TResult> Result;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Arg0", Arg0.ToResoniteReference(context));
members.Add("Arg1", Arg1.ToResoniteReference(context));
members.Add("Arg2", Arg2.ToResoniteReference(context));
members.Add("Result", new ResoniteLink.EmptyElement());
}

}
}
