
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Audio.PlayOneShotAndWait
// Generated on: čtvrtek 19. února 2026 7:59:42
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Audio
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Audio.PlayOneShotAndWait")]
public partial class PlayOneShotAndWait : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>, global::FrooxEngine.FrooxEngine.ProtoFlux.IMappableNode, global::FrooxEngine.ProtoFlux.IProtoFluxNode<global::FrooxEngine.ProtoFlux.IMappableNode>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> Clip;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Volume;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Speed;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Spatialize;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> SpatialBlend;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.Nullable<global::System.Boolean>> Global;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Point;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> Root;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> ParentUnderRoot;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Priority;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Doppler;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> MinDistance;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> MaxDistance;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Awwdio.AudioRolloffCurve> Rolloff;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.AudioDistanceSpace> DistanceSpace;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> MinScale;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> MaxScale;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.AudioTypeGroup> Group;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> IgnoreAudioEffects;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> LocalOnly;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.AudioOutput> Audio;
public global::FrooxEngine.ProtoFlux.INodeOperation OnStartedPlaying;
public global::FrooxEngine.ProtoFlux.INodeOperation OnFinishedPlaying;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Clip", Clip.ToResoniteReference(context));
members.Add("Volume", Volume.ToResoniteReference(context));
members.Add("Speed", Speed.ToResoniteReference(context));
members.Add("Spatialize", Spatialize.ToResoniteReference(context));
members.Add("SpatialBlend", SpatialBlend.ToResoniteReference(context));
members.Add("Global", Global.ToResoniteReference(context));
members.Add("Point", Point.ToResoniteReference(context));
members.Add("Root", Root.ToResoniteReference(context));
members.Add("ParentUnderRoot", ParentUnderRoot.ToResoniteReference(context));
members.Add("Priority", Priority.ToResoniteReference(context));
members.Add("Doppler", Doppler.ToResoniteReference(context));
members.Add("MinDistance", MinDistance.ToResoniteReference(context));
members.Add("MaxDistance", MaxDistance.ToResoniteReference(context));
members.Add("Rolloff", Rolloff.ToResoniteReference(context));
members.Add("DistanceSpace", DistanceSpace.ToResoniteReference(context));
members.Add("MinScale", MinScale.ToResoniteReference(context));
members.Add("MaxScale", MaxScale.ToResoniteReference(context));
members.Add("Group", Group.ToResoniteReference(context));
members.Add("IgnoreAudioEffects", IgnoreAudioEffects.ToResoniteReference(context));
members.Add("LocalOnly", LocalOnly.ToResoniteReference(context));
members.Add("Audio", new ResoniteLink.EmptyElement());
members.Add("OnStartedPlaying", OnStartedPlaying.ToResoniteReference(context));
members.Add("OnFinishedPlaying", OnFinishedPlaying.ToResoniteReference(context));
}

}
}
