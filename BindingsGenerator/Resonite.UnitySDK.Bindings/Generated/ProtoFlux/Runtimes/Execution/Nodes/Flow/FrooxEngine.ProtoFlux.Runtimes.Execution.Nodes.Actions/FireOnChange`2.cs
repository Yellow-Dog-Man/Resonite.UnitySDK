
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.FireOnChange<,>
// Generated on: čtvrtek 26. února 2026 12:27:34
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.FireOnChange<,>")]
public abstract partial class FireOnChange<T,P> : global::FrooxEngine.FrooxEngine.ProtoFlux.ProxyVoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,P>
	where P : global::FrooxEngine.ProtoFlux.ProtoFluxEngineProxy, global::ProtoFlux.Runtimes.Execution.Nodes.Actions.ILastValueProxy<T>
	

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User> OnlyForUser { get => OnlyForUser_Element.Data; set => OnlyForUser_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User>> OnlyForUser_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnChanged { get => OnChanged_Element.Data; set => OnChanged_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> OnChanged_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnlyForUser", OnlyForUser_Element.ToLinkReference(context));
members.Add("OnChanged", OnChanged_Element.ToLinkReference(context));
}

}
}
