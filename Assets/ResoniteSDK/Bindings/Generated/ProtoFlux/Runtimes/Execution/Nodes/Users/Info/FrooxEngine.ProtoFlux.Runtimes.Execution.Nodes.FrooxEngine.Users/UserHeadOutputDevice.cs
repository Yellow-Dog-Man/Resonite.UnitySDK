
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Users.UserHeadOutputDevice
// Generated on: pátek 13. února 2026 23:22:58
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Users.UserHeadOutputDevice")]
public partial class UserHeadOutputDevice : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::Renderite.Shared.HeadOutputDevice>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User> User;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("User", new ResoniteLink.Reference() { });
}

}
}
