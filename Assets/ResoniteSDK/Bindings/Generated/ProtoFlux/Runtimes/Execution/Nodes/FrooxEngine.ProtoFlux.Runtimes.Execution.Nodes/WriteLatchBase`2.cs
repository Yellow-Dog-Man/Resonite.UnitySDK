
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.WriteLatchBase<,>
// Generated on: sobota 14. února 2026 8:57:44
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnSet", OnSet.ToResoniteReference(context));
members.Add("OnReset", OnReset.ToResoniteReference(context));
members.Add("OnFail", OnFail.ToResoniteReference(context));
members.Add("Set", new ResoniteLink.EmptyElement());
members.Add("Reset", new ResoniteLink.EmptyElement());
}

}
}
