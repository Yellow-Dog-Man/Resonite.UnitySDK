
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Time.Stopwatch
// Generated on: pátek 13. února 2026 23:22:56
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Time
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Time.Stopwatch")]
public partial class Stopwatch : global::FrooxEngine.FrooxEngine.ProtoFlux.ProxyVoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Time.Stopwatch.Proxy>

{
    public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Time;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsRunning;
public global::FrooxEngine.ProtoFlux.SyncNodeOperation Start;
public global::FrooxEngine.ProtoFlux.SyncNodeOperation Stop;
public global::FrooxEngine.ProtoFlux.SyncNodeOperation Reset;
public global::FrooxEngine.ProtoFlux.INodeOperation OnStart;
public global::FrooxEngine.ProtoFlux.INodeOperation OnStop;
public global::FrooxEngine.ProtoFlux.INodeOperation OnReset;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Time", new ResoniteLink.EmptyElement());
members.Add("IsRunning", new ResoniteLink.EmptyElement());
members.Add("Start", new ResoniteLink.EmptyElement());
members.Add("Stop", new ResoniteLink.EmptyElement());
members.Add("Reset", new ResoniteLink.EmptyElement());
members.Add("OnStart", new ResoniteLink.Reference() { });
members.Add("OnStop", new ResoniteLink.Reference() { });
members.Add("OnReset", new ResoniteLink.Reference() { });
}

}
}
