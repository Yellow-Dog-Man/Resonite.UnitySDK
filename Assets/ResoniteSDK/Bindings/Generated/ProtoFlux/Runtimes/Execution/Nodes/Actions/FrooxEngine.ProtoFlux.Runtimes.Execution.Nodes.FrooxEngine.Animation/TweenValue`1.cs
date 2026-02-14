
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Animation.TweenValue<>
// Generated on: sobota 14. února 2026 8:57:45
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("To", To.ToResoniteReference(context));
members.Add("From", From.ToResoniteReference(context));
members.Add("Duration", Duration.ToResoniteReference(context));
members.Add("Curve", Curve.ToResoniteReference(context));
members.Add("ProportionalDuration", ProportionalDuration.ToResoniteReference(context));
members.Add("Target", Target.ToResoniteReference(context));
members.Add("OnStarted", OnStarted.ToResoniteReference(context));
members.Add("OnDone", OnDone.ToResoniteReference(context));
}

}
}
