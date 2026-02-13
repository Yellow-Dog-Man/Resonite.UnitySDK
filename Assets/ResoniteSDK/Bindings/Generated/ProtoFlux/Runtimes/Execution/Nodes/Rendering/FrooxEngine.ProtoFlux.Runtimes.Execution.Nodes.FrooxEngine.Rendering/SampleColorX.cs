
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Rendering.SampleColorX
// Generated on: pátek 13. února 2026 23:22:53
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Rendering.SampleColorX")]
public partial class SampleColorX : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Point;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Direction;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> Reference;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> NearClip;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> FarClip;
public global::FrooxEngine.ProtoFlux.INodeOperation OnSampleStart;
public global::FrooxEngine.ProtoFlux.INodeOperation OnSampled;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.ColorX> SampledColor;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Point", new ResoniteLink.Reference() { });
members.Add("Direction", new ResoniteLink.Reference() { });
members.Add("Reference", new ResoniteLink.Reference() { });
members.Add("NearClip", new ResoniteLink.Reference() { });
members.Add("FarClip", new ResoniteLink.Reference() { });
members.Add("OnSampleStart", new ResoniteLink.Reference() { });
members.Add("OnSampled", new ResoniteLink.Reference() { });
members.Add("SampledColor", new ResoniteLink.EmptyElement());
}

}
}
