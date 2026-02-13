
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Users.UserFromUsername
// Generated on: pátek 13. února 2026 5:52:16
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Username", new ResoniteLink.Reference() { });
members.Add("IgnoreCase", new ResoniteLink.Reference() { });
members.Add("AllowPartialMatch", new ResoniteLink.Reference() { });
}

}
}
