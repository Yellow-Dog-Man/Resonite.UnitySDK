
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.UserUpdateBase
// Generated on: pátek 13. února 2026 5:51:53
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("UpdatingUser", new ResoniteLink.Reference() { });
members.Add("SkipIfNull", new ResoniteLink.Reference() { });
}

}
}
