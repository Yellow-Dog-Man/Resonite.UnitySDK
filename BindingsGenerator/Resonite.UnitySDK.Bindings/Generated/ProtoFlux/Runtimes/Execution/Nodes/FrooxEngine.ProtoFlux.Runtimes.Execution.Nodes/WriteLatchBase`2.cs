
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.WriteLatchBase<,>
// Generated on: čtvrtek 26. února 2026 15:08:29
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.ProtoFlux.INodeOperation OnSet { get => OnSet_Element.Data; set => OnSet_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnSet_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnReset { get => OnReset_Element.Data; set => OnReset_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnReset_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnFail { get => OnFail_Element.Data; set => OnFail_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnFail_Element = new();
public global::FrooxEngine.ProtoFlux.SyncNodeOperation Set = new();
public global::FrooxEngine.ProtoFlux.SyncNodeOperation Reset = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnSet", OnSet_Element.ToLinkReference(context));
members.Add("OnReset", OnReset_Element.ToLinkReference(context));
members.Add("OnFail", OnFail_Element.ToLinkReference(context));
members.Add("Set", Set.ToLinkEmpty(context));
members.Add("Reset", Reset.ToLinkEmpty(context));
}

}
}
