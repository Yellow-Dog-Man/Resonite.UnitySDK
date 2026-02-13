
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.SampleObjectAnimationTrack<>
// Generated on: pátek 13. února 2026 23:22:18
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Animation", new ResoniteLink.Reference() { });
members.Add("TrackIndex", new ResoniteLink.Reference() { });
members.Add("Time", new ResoniteLink.Reference() { });
}

}
}
