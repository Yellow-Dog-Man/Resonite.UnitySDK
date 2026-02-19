
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.UserUpdateBase
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.UserUpdateBase")]
public abstract partial class UserUpdateBase : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.UpdateBase

{
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.User> UpdatingUser;
public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::System.Boolean> SkipIfNull;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UpdatingUser", UpdatingUser.ToResoniteReference(context));
members.Add("SkipIfNull", SkipIfNull.ToResoniteReference(context));
}

}
}
