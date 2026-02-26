
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.UserUpdateBase
// Generated on: čtvrtek 26. února 2026 15:08:38
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.User> UpdatingUser { get => UpdatingUser_Element.Data; set => UpdatingUser_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.User>>, global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.User>> UpdatingUser_Element = new();
public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::System.Boolean> SkipIfNull { get => SkipIfNull_Element.Data; set => SkipIfNull_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::System.Boolean>> SkipIfNull_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UpdatingUser", UpdatingUser_Element.ToLinkReference(context));
members.Add("SkipIfNull", SkipIfNull_Element.ToLinkReference(context));
}

}
}
