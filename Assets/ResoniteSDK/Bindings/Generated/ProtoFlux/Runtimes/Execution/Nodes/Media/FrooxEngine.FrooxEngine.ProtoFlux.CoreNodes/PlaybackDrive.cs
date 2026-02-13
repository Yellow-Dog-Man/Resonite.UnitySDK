
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.PlaybackDrive
// Generated on: pátek 13. února 2026 23:22:41
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.PlaybackDrive")]
public partial class PlaybackDrive : global::FrooxEngine.FrooxEngine.ProtoFlux.ProxyVoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::FrooxEngine.ProtoFlux.CoreNodes.PlaybackDrive.Proxy>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.SyncPlayback> Target;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> NormalizedPosition;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> MaximumPositionError;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Speed;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Play;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Loop;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsDriving;
public global::FrooxEngine.ProtoFlux.SyncNodeOperation StartDrive;
public global::FrooxEngine.ProtoFlux.SyncNodeOperation StopDrive;
public global::FrooxEngine.ProtoFlux.SyncNodeOperation ForceResync;
public global::FrooxEngine.ProtoFlux.INodeOperation OnStartDrive;
public global::FrooxEngine.ProtoFlux.INodeOperation OnStopDrive;
public global::FrooxEngine.ProtoFlux.INodeOperation OnResync;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("NormalizedPosition", new ResoniteLink.Reference() { });
members.Add("MaximumPositionError", new ResoniteLink.Reference() { });
members.Add("Speed", new ResoniteLink.Reference() { });
members.Add("Play", new ResoniteLink.Reference() { });
members.Add("Loop", new ResoniteLink.Reference() { });
members.Add("IsDriving", new ResoniteLink.EmptyElement());
members.Add("StartDrive", new ResoniteLink.EmptyElement());
members.Add("StopDrive", new ResoniteLink.EmptyElement());
members.Add("ForceResync", new ResoniteLink.EmptyElement());
members.Add("OnStartDrive", new ResoniteLink.Reference() { });
members.Add("OnStopDrive", new ResoniteLink.Reference() { });
members.Add("OnResync", new ResoniteLink.Reference() { });
}

}
}
