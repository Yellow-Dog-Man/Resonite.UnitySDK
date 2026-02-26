
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Audio.PlayOneShot
// Generated on: čtvrtek 26. února 2026 15:08:29
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> Clip { get => Clip_Element.Data; set => Clip_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>>> Clip_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Volume { get => Volume_Element.Data; set => Volume_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> Volume_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Speed { get => Speed_Element.Data; set => Speed_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> Speed_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Spatialize { get => Spatialize_Element.Data; set => Spatialize_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> Spatialize_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> SpatialBlend { get => SpatialBlend_Element.Data; set => SpatialBlend_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> SpatialBlend_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.Nullable<global::System.Boolean>> Global { get => Global_Element.Data; set => Global_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.Nullable<global::System.Boolean>>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.Nullable<global::System.Boolean>>> Global_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Point { get => Point_Element.Data; set => Point_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>> Point_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> Root { get => Root_Element.Data; set => Root_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot>> Root_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> ParentUnderRoot { get => ParentUnderRoot_Element.Data; set => ParentUnderRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> ParentUnderRoot_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Priority { get => Priority_Element.Data; set => Priority_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>> Priority_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Doppler { get => Doppler_Element.Data; set => Doppler_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> Doppler_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> MinDistance { get => MinDistance_Element.Data; set => MinDistance_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> MinDistance_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> MaxDistance { get => MaxDistance_Element.Data; set => MaxDistance_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> MaxDistance_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Awwdio.AudioRolloffCurve> Rolloff { get => Rolloff_Element.Data; set => Rolloff_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Awwdio.AudioRolloffCurve>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Awwdio.AudioRolloffCurve>> Rolloff_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.AudioDistanceSpace> DistanceSpace { get => DistanceSpace_Element.Data; set => DistanceSpace_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.AudioDistanceSpace>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.AudioDistanceSpace>> DistanceSpace_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> MinScale { get => MinScale_Element.Data; set => MinScale_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> MinScale_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> MaxScale { get => MaxScale_Element.Data; set => MaxScale_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> MaxScale_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.AudioTypeGroup> Group { get => Group_Element.Data; set => Group_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.AudioTypeGroup>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.AudioTypeGroup>> Group_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> IgnoreAudioEffects { get => IgnoreAudioEffects_Element.Data; set => IgnoreAudioEffects_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> IgnoreAudioEffects_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> LocalOnly { get => LocalOnly_Element.Data; set => LocalOnly_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> LocalOnly_Element = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.AudioOutput> Audio = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnStartedPlaying { get => OnStartedPlaying_Element.Data; set => OnStartedPlaying_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnStartedPlaying_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Clip", Clip_Element.ToLinkReference(context));
members.Add("Volume", Volume_Element.ToLinkReference(context));
members.Add("Speed", Speed_Element.ToLinkReference(context));
members.Add("Spatialize", Spatialize_Element.ToLinkReference(context));
members.Add("SpatialBlend", SpatialBlend_Element.ToLinkReference(context));
members.Add("Global", Global_Element.ToLinkReference(context));
members.Add("Point", Point_Element.ToLinkReference(context));
members.Add("Root", Root_Element.ToLinkReference(context));
members.Add("ParentUnderRoot", ParentUnderRoot_Element.ToLinkReference(context));
members.Add("Priority", Priority_Element.ToLinkReference(context));
members.Add("Doppler", Doppler_Element.ToLinkReference(context));
members.Add("MinDistance", MinDistance_Element.ToLinkReference(context));
members.Add("MaxDistance", MaxDistance_Element.ToLinkReference(context));
members.Add("Rolloff", Rolloff_Element.ToLinkReference(context));
members.Add("DistanceSpace", DistanceSpace_Element.ToLinkReference(context));
members.Add("MinScale", MinScale_Element.ToLinkReference(context));
members.Add("MaxScale", MaxScale_Element.ToLinkReference(context));
members.Add("Group", Group_Element.ToLinkReference(context));
members.Add("IgnoreAudioEffects", IgnoreAudioEffects_Element.ToLinkReference(context));
members.Add("LocalOnly", LocalOnly_Element.ToLinkReference(context));
members.Add("Audio", Audio.ToLinkEmpty(context));
members.Add("OnStartedPlaying", OnStartedPlaying_Element.ToLinkReference(context));
}

}
}
