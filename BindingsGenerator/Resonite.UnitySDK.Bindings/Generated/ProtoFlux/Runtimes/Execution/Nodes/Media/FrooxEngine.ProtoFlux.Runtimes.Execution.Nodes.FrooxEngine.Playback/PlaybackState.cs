
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Playback.PlaybackState
// Generated on: čtvrtek 26. února 2026 15:08:46
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IPlayable>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IPlayable>> Source_Element = new();
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
members.Add("Source", Source_Element.ToLinkReference(context));
members.Add("IsPlaying", IsPlaying.ToLinkEmpty(context));
members.Add("Loop", Loop.ToLinkEmpty(context));
members.Add("Position", Position.ToLinkEmpty(context));
members.Add("NormalizedPosition", NormalizedPosition.ToLinkEmpty(context));
members.Add("ClipLength", ClipLength.ToLinkEmpty(context));
members.Add("Speed", Speed.ToLinkEmpty(context));
}

}
}
