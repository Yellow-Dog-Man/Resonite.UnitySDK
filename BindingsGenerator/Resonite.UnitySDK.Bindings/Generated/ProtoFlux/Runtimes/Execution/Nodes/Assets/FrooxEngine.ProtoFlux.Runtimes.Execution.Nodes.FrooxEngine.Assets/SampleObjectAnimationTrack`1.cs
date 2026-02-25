
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.SampleObjectAnimationTrack<>
// Generated on: středa 25. února 2026 16:13:37
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.SampleObjectAnimationTrack<>")]
public partial class SampleObjectAnimationTrack<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,T>
	

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
