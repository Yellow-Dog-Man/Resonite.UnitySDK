
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Users.UserFromUsername
// Generated on: sobota 14. února 2026 8:58:28
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Users
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Users.UserFromUsername")]
public partial class UserFromUsername : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::FrooxEngine.User>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Username;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> IgnoreCase;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> AllowPartialMatch;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Username", Username.ToResoniteReference(context));
members.Add("IgnoreCase", IgnoreCase.ToResoniteReference(context));
members.Add("AllowPartialMatch", AllowPartialMatch.ToResoniteReference(context));
}

}
}
