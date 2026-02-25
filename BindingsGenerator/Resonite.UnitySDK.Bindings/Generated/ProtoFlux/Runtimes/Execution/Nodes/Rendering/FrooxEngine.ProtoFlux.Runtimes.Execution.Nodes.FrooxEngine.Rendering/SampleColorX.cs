
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Rendering.SampleColorX
// Generated on: středa 25. února 2026 16:14:05
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Point", Point.ToResoniteReference(context));
members.Add("Direction", Direction.ToResoniteReference(context));
members.Add("Reference", Reference.ToResoniteReference(context));
members.Add("NearClip", NearClip.ToResoniteReference(context));
members.Add("FarClip", FarClip.ToResoniteReference(context));
members.Add("OnSampleStart", OnSampleStart.ToResoniteReference(context));
members.Add("OnSampled", OnSampled.ToResoniteReference(context));
members.Add("SampledColor", new ResoniteLink.EmptyElement());
}

}
}
