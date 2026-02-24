
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.LocalLeakyImpulseBucket
// Generated on: úterý 24. února 2026 18:19:14
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Pulse", Pulse.ToResoniteReference(context));
members.Add("Overflow", Overflow.ToResoniteReference(context));
members.Add("Interval", Interval.ToResoniteReference(context));
members.Add("MaximumCapacity", MaximumCapacity.ToResoniteReference(context));
members.Add("CurrentCapacity", new ResoniteLink.EmptyElement());
members.Add("Trigger", new ResoniteLink.EmptyElement());
members.Add("Reset", new ResoniteLink.EmptyElement());
}

}
}
