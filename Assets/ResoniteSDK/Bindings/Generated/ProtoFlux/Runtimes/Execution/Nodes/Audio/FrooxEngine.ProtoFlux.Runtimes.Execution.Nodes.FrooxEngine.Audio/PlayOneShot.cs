
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Audio.PlayOneShot
// Generated on: pátek 13. února 2026 5:51:44
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Audio
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Audio.PlayOneShot")]
public partial class PlayOneShot : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>, global::FrooxEngine.FrooxEngine.ProtoFlux.IMappableNode, global::FrooxEngine.ProtoFlux.IProtoFluxNode<global::FrooxEngine.ProtoFlux.IMappableNode>

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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Clip", new ResoniteLink.Reference() { });
members.Add("Volume", new ResoniteLink.Reference() { });
members.Add("Speed", new ResoniteLink.Reference() { });
members.Add("Spatialize", new ResoniteLink.Reference() { });
members.Add("SpatialBlend", new ResoniteLink.Reference() { });
members.Add("Global", new ResoniteLink.Reference() { });
members.Add("Point", new ResoniteLink.Reference() { });
members.Add("Root", new ResoniteLink.Reference() { });
members.Add("ParentUnderRoot", new ResoniteLink.Reference() { });
members.Add("Priority", new ResoniteLink.Reference() { });
members.Add("Doppler", new ResoniteLink.Reference() { });
members.Add("MinDistance", new ResoniteLink.Reference() { });
members.Add("MaxDistance", new ResoniteLink.Reference() { });
members.Add("Rolloff", new ResoniteLink.Reference() { });
members.Add("DistanceSpace", new ResoniteLink.Reference() { });
members.Add("MinScale", new ResoniteLink.Reference() { });
members.Add("MaxScale", new ResoniteLink.Reference() { });
members.Add("Group", new ResoniteLink.Reference() { });
members.Add("IgnoreAudioEffects", new ResoniteLink.Reference() { });
members.Add("LocalOnly", new ResoniteLink.Reference() { });
members.Add("Audio", new ResoniteLink.EmptyElement());
members.Add("OnStartedPlaying", new ResoniteLink.Reference() { });
}

}
}
