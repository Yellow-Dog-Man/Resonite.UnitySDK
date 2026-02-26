
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.SampleObjectAnimationTrack<>
// Generated on: čtvrtek 26. února 2026 10:04:06
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
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Animation> Animation { get => Animation_Element.Data; set => Animation_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Animation>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Animation>> Animation_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> TrackIndex { get => TrackIndex_Element.Data; set => TrackIndex_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>> TrackIndex_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Time { get => Time_Element.Data; set => Time_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> Time_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Animation", Animation_Element.Data.ToResoniteReference(context));
members.Add("TrackIndex", TrackIndex_Element.Data.ToResoniteReference(context));
members.Add("Time", Time_Element.Data.ToResoniteReference(context));
}

}
}
