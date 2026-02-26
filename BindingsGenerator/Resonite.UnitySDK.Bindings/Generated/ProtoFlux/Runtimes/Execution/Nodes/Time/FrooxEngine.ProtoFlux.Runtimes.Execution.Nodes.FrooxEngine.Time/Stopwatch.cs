
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Time.Stopwatch
// Generated on: čtvrtek 26. února 2026 10:04:31
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Time = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsRunning = new();
public global::FrooxEngine.ProtoFlux.SyncNodeOperation Start = new();
public global::FrooxEngine.ProtoFlux.SyncNodeOperation Stop = new();
public global::FrooxEngine.ProtoFlux.SyncNodeOperation Reset = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnStart { get => OnStart_Element.Data; set => OnStart_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnStart_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnStop { get => OnStop_Element.Data; set => OnStop_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnStop_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnReset { get => OnReset_Element.Data; set => OnReset_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnReset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Time", new ResoniteLink.EmptyElement());
members.Add("IsRunning", new ResoniteLink.EmptyElement());
members.Add("Start", new ResoniteLink.EmptyElement());
members.Add("Stop", new ResoniteLink.EmptyElement());
members.Add("Reset", new ResoniteLink.EmptyElement());
members.Add("OnStart", OnStart_Element.Data.ToResoniteReference(context));
members.Add("OnStop", OnStop_Element.Data.ToResoniteReference(context));
members.Add("OnReset", OnReset_Element.Data.ToResoniteReference(context));
}

}
}
