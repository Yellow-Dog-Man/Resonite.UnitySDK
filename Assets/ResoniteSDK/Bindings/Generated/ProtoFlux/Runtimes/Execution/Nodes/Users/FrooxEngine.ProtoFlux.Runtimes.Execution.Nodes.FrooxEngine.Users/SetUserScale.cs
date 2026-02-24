
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Users.SetUserScale
// Generated on: úterý 24. února 2026 18:19:57
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UserRoot", UserRoot.ToResoniteReference(context));
members.Add("Scale", Scale.ToResoniteReference(context));
members.Add("AnimationTime", AnimationTime.ToResoniteReference(context));
members.Add("OnScaleChangeStart", OnScaleChangeStart.ToResoniteReference(context));
members.Add("OnAnimationFinished", OnAnimationFinished.ToResoniteReference(context));
}

}
}
