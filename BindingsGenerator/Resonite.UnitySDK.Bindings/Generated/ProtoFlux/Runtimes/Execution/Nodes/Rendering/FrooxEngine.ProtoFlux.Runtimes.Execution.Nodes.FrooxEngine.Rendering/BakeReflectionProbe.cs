
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Rendering.BakeReflectionProbe
// Generated on: středa 25. února 2026 16:14:04
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Rendering.BakeReflectionProbe")]
public partial class BakeReflectionProbe : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.ReflectionProbe> Probe;
public global::FrooxEngine.ProtoFlux.INodeOperation OnBakeStart;
public global::FrooxEngine.ProtoFlux.INodeOperation OnBakeFail;
public global::FrooxEngine.ProtoFlux.INodeOperation OnBakeComplete;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<System.Uri> BakedCubemapURL;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Probe", Probe.ToResoniteReference(context));
members.Add("OnBakeStart", OnBakeStart.ToResoniteReference(context));
members.Add("OnBakeFail", OnBakeFail.ToResoniteReference(context));
members.Add("OnBakeComplete", OnBakeComplete.ToResoniteReference(context));
members.Add("BakedCubemapURL", new ResoniteLink.EmptyElement());
}

}
}
