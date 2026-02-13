
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.WriteLatchBase<,>
// Generated on: pátek 13. února 2026 5:51:43
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.WriteLatchBase<,>")]
public abstract partial class WriteLatchBase<C,T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<C>
	
	where C : global::ProtoFlux.Runtimes.Execution.ExecutionContext

{
    public global::FrooxEngine.ProtoFlux.INodeOperation OnSet;
public global::FrooxEngine.ProtoFlux.INodeOperation OnReset;
public global::FrooxEngine.ProtoFlux.INodeOperation OnFail;
public global::FrooxEngine.ProtoFlux.SyncNodeOperation Set;
public global::FrooxEngine.ProtoFlux.SyncNodeOperation Reset;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("OnSet", new ResoniteLink.Reference() { });
members.Add("OnReset", new ResoniteLink.Reference() { });
members.Add("OnFail", new ResoniteLink.Reference() { });
members.Add("Set", new ResoniteLink.EmptyElement());
members.Add("Reset", new ResoniteLink.EmptyElement());
}

}
}
