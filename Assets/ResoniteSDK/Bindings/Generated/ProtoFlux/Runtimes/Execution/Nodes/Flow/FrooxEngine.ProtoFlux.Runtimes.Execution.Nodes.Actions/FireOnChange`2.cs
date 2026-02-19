
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.FireOnChange<,>
// Generated on: čtvrtek 19. února 2026 7:59:51
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User> OnlyForUser;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnChanged;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnlyForUser", OnlyForUser.ToResoniteReference(context));
members.Add("OnChanged", OnChanged.ToResoniteReference(context));
}

}
}
