
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.SyncMethodProxy_000F<,,,>
// Generated on: čtvrtek 19. února 2026 7:59:22
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.SyncMethodProxy_000F<,,,>")]
public partial class SyncMethodProxy_000F<T0,T1,T2,T3> : global::FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.DataModelMethodProxy<global::System.Action<T0,T1,T2,T3>>
	
	
	
	

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T0> Arg0;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T1> Arg1;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T2> Arg2;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T3> Arg3;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Arg0", Arg0.ToResoniteReference(context));
members.Add("Arg1", Arg1.ToResoniteReference(context));
members.Add("Arg2", Arg2.ToResoniteReference(context));
members.Add("Arg3", Arg3.ToResoniteReference(context));
}

}
}
