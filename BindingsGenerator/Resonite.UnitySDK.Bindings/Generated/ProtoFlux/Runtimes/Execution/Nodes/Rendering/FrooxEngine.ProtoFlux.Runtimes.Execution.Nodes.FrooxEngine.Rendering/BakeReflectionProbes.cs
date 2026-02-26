
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Rendering.BakeReflectionProbes
// Generated on: čtvrtek 26. února 2026 15:08:55
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Rendering
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Rendering.BakeReflectionProbes")]
public partial class BakeReflectionProbes : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> Root { get => Root_Element.Data; set => Root_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot>> Root_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> BakeInactive { get => BakeInactive_Element.Data; set => BakeInactive_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> BakeInactive_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> FilterWithTag { get => FilterWithTag_Element.Data; set => FilterWithTag_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> FilterWithTag_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> DelayBeforeBake { get => DelayBeforeBake_Element.Data; set => DelayBeforeBake_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> DelayBeforeBake_Element = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.ReflectionProbe> Probe = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> ProbeIndex = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> ProbeCount = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnBakeBatchStart { get => OnBakeBatchStart_Element.Data; set => OnBakeBatchStart_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnBakeBatchStart_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnBeforeProbeBake { get => OnBeforeProbeBake_Element.Data; set => OnBeforeProbeBake_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnBeforeProbeBake_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnProbeBaked { get => OnProbeBaked_Element.Data; set => OnProbeBaked_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnProbeBaked_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnBakeBatchFinished { get => OnBakeBatchFinished_Element.Data; set => OnBakeBatchFinished_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnBakeBatchFinished_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Root", Root_Element.ToLinkReference(context));
members.Add("BakeInactive", BakeInactive_Element.ToLinkReference(context));
members.Add("FilterWithTag", FilterWithTag_Element.ToLinkReference(context));
members.Add("DelayBeforeBake", DelayBeforeBake_Element.ToLinkReference(context));
members.Add("Probe", Probe.ToLinkEmpty(context));
members.Add("ProbeIndex", ProbeIndex.ToLinkEmpty(context));
members.Add("ProbeCount", ProbeCount.ToLinkEmpty(context));
members.Add("OnBakeBatchStart", OnBakeBatchStart_Element.ToLinkReference(context));
members.Add("OnBeforeProbeBake", OnBeforeProbeBake_Element.ToLinkReference(context));
members.Add("OnProbeBaked", OnProbeBaked_Element.ToLinkReference(context));
members.Add("OnBakeBatchFinished", OnBakeBatchFinished_Element.ToLinkReference(context));
}

}
}
