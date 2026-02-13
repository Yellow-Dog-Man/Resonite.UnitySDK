
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Rendering.BakeReflectionProbes
// Generated on: pátek 13. února 2026 5:52:11
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> Root;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> BakeInactive;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> FilterWithTag;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> DelayBeforeBake;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.ReflectionProbe> Probe;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> ProbeIndex;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> ProbeCount;
public global::FrooxEngine.ProtoFlux.INodeOperation OnBakeBatchStart;
public global::FrooxEngine.ProtoFlux.INodeOperation OnBeforeProbeBake;
public global::FrooxEngine.ProtoFlux.INodeOperation OnProbeBaked;
public global::FrooxEngine.ProtoFlux.INodeOperation OnBakeBatchFinished;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Root", new ResoniteLink.Reference() { });
members.Add("BakeInactive", new ResoniteLink.Reference() { });
members.Add("FilterWithTag", new ResoniteLink.Reference() { });
members.Add("DelayBeforeBake", new ResoniteLink.Reference() { });
members.Add("Probe", new ResoniteLink.EmptyElement());
members.Add("ProbeIndex", new ResoniteLink.EmptyElement());
members.Add("ProbeCount", new ResoniteLink.EmptyElement());
members.Add("OnBakeBatchStart", new ResoniteLink.Reference() { });
members.Add("OnBeforeProbeBake", new ResoniteLink.Reference() { });
members.Add("OnProbeBaked", new ResoniteLink.Reference() { });
members.Add("OnBakeBatchFinished", new ResoniteLink.Reference() { });
}

}
}
