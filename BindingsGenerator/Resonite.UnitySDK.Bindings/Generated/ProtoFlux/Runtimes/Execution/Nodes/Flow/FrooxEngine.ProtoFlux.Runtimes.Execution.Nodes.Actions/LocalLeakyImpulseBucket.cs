
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.LocalLeakyImpulseBucket
// Generated on: čtvrtek 26. února 2026 10:04:14
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.ProtoFlux.ISyncNodeOperation Pulse { get => Pulse_Element.Data; set => Pulse_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> Pulse_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation Overflow { get => Overflow_Element.Data; set => Overflow_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> Overflow_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Interval { get => Interval_Element.Data; set => Interval_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> Interval_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> MaximumCapacity { get => MaximumCapacity_Element.Data; set => MaximumCapacity_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>> MaximumCapacity_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> CurrentCapacity = new();
public global::FrooxEngine.ProtoFlux.SyncNodeOperation Trigger = new();
public global::FrooxEngine.ProtoFlux.SyncNodeOperation Reset = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Pulse", Pulse_Element.Data.ToResoniteReference(context));
members.Add("Overflow", Overflow_Element.Data.ToResoniteReference(context));
members.Add("Interval", Interval_Element.Data.ToResoniteReference(context));
members.Add("MaximumCapacity", MaximumCapacity_Element.Data.ToResoniteReference(context));
members.Add("CurrentCapacity", new ResoniteLink.EmptyElement());
members.Add("Trigger", new ResoniteLink.EmptyElement());
members.Add("Reset", new ResoniteLink.EmptyElement());
}

}
}
