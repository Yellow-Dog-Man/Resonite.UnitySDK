
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Playback.PlaybackState
// Generated on: čtvrtek 26. února 2026 10:04:21
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Playback
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Playback.PlaybackState")]
public partial class PlaybackState : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IPlayable> Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IPlayable>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IPlayable>> Source_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsPlaying = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Loop = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Position = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> NormalizedPosition = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> ClipLength = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Speed = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source_Element.Data.ToResoniteReference(context));
members.Add("IsPlaying", new ResoniteLink.EmptyElement());
members.Add("Loop", new ResoniteLink.EmptyElement());
members.Add("Position", new ResoniteLink.EmptyElement());
members.Add("NormalizedPosition", new ResoniteLink.EmptyElement());
members.Add("ClipLength", new ResoniteLink.EmptyElement());
members.Add("Speed", new ResoniteLink.EmptyElement());
}

}
}
