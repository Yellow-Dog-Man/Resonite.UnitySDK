
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.SampleValueAnimationTrack<>
// Generated on: úterý 24. února 2026 18:18:56
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.SampleValueAnimationTrack<>")]
public partial class SampleValueAnimationTrack<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,T>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Animation> Animation;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> TrackIndex;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Time;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Animation", Animation.ToResoniteReference(context));
members.Add("TrackIndex", TrackIndex.ToResoniteReference(context));
members.Add("Time", Time.ToResoniteReference(context));
}

}
}
