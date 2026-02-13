
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Playback.PlaybackState
// Generated on: pátek 13. února 2026 23:22:41
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IPlayable> Source;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsPlaying;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Loop;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Position;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> NormalizedPosition;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> ClipLength;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Speed;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Source", new ResoniteLink.Reference() { });
members.Add("IsPlaying", new ResoniteLink.EmptyElement());
members.Add("Loop", new ResoniteLink.EmptyElement());
members.Add("Position", new ResoniteLink.EmptyElement());
members.Add("NormalizedPosition", new ResoniteLink.EmptyElement());
members.Add("ClipLength", new ResoniteLink.EmptyElement());
members.Add("Speed", new ResoniteLink.EmptyElement());
}

}
}
