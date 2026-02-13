
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.SyncMethodProxy_0012<,,,,>
// Generated on: pátek 13. února 2026 23:22:01
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.SyncMethodProxy_0012<,,,,>")]
public partial class SyncMethodProxy_0012<T0,T1,T2,T3,T4> : global::FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.DataModelMethodProxy<global::System.Action<T0,T1,T2,T3,T4>>
	
	where T3 : struct
	where T2 : struct
	
	where T0 : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<T0> Arg0;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T1> Arg1;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T2> Arg2;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T3> Arg3;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T4> Arg4;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Arg0", new ResoniteLink.Reference() { });
members.Add("Arg1", new ResoniteLink.Reference() { });
members.Add("Arg2", new ResoniteLink.Reference() { });
members.Add("Arg3", new ResoniteLink.Reference() { });
members.Add("Arg4", new ResoniteLink.Reference() { });
}

}
}
