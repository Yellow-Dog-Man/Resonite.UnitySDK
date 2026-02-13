
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.AsyncMethodProxy_0001<>
// Generated on: pátek 13. února 2026 23:21:43
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.AsyncMethodProxy_0001<>")]
public partial class AsyncMethodProxy_0001<T0> : global::FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.DataModelAsyncMethodProxy<global::System.Func<T0,global::System.Threading.Tasks.Task>>
	

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T0> Arg0;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Arg0", new ResoniteLink.Reference() { });
}

}
}
