
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Users.SetUserScale
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Users.SetUserScale")]
public partial class SetUserScale : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.UserRoot> UserRoot;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Scale;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> AnimationTime;
public global::FrooxEngine.ProtoFlux.INodeOperation OnScaleChangeStart;
public global::FrooxEngine.ProtoFlux.INodeOperation OnAnimationFinished;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("UserRoot", new ResoniteLink.Reference() { });
members.Add("Scale", new ResoniteLink.Reference() { });
members.Add("AnimationTime", new ResoniteLink.Reference() { });
members.Add("OnScaleChangeStart", new ResoniteLink.Reference() { });
members.Add("OnAnimationFinished", new ResoniteLink.Reference() { });
}

}
}
