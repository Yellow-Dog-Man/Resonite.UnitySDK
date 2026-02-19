
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Users.UserNumericNetworkStatistic<>
// Generated on: čtvrtek 19. února 2026 8:00:14
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Users
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Users.UserNumericNetworkStatistic<>")]
public partial class UserNumericNetworkStatistic<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::System.Nullable<T>>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Name;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User> User;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Name", Name.ToResoniteReference(context));
members.Add("User", User.ToResoniteReference(context));
}

}
}
