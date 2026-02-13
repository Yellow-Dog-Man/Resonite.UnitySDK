
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Animation.TweenValue<>
// Generated on: pátek 13. února 2026 5:51:43
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Animation
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Animation.TweenValue<>")]
public partial class TweenValue<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> To;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> From;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Duration;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.CurvePreset> Curve;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> ProportionalDuration;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IField<T>> Target;
public global::FrooxEngine.ProtoFlux.INodeOperation OnStarted;
public global::FrooxEngine.ProtoFlux.INodeOperation OnDone;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("To", new ResoniteLink.Reference() { });
members.Add("From", new ResoniteLink.Reference() { });
members.Add("Duration", new ResoniteLink.Reference() { });
members.Add("Curve", new ResoniteLink.Reference() { });
members.Add("ProportionalDuration", new ResoniteLink.Reference() { });
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("OnStarted", new ResoniteLink.Reference() { });
members.Add("OnDone", new ResoniteLink.Reference() { });
}

}
}
