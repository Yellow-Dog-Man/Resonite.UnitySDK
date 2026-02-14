
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.UserUpdateBase
// Generated on: sobota 14. února 2026 8:57:58
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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
