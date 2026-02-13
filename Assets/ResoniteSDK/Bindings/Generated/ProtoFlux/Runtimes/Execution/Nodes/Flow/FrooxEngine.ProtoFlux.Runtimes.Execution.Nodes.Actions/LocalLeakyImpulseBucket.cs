
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.LocalLeakyImpulseBucket
// Generated on: pátek 13. února 2026 5:51:53
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.LocalLeakyImpulseBucket")]
public partial class LocalLeakyImpulseBucket : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>, global::FrooxEngine.FrooxEngine.ProtoFlux.IMappableNode, global::FrooxEngine.ProtoFlux.IProtoFluxNode<global::FrooxEngine.ProtoFlux.IMappableNode>

{
    public global::FrooxEngine.ProtoFlux.ISyncNodeOperation Pulse;
public global::FrooxEngine.ProtoFlux.INodeOperation Overflow;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Interval;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> MaximumCapacity;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> CurrentCapacity;
public global::FrooxEngine.ProtoFlux.SyncNodeOperation Trigger;
public global::FrooxEngine.ProtoFlux.SyncNodeOperation Reset;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Pulse", new ResoniteLink.Reference() { });
members.Add("Overflow", new ResoniteLink.Reference() { });
members.Add("Interval", new ResoniteLink.Reference() { });
members.Add("MaximumCapacity", new ResoniteLink.Reference() { });
members.Add("CurrentCapacity", new ResoniteLink.EmptyElement());
members.Add("Trigger", new ResoniteLink.EmptyElement());
members.Add("Reset", new ResoniteLink.EmptyElement());
}

}
}
