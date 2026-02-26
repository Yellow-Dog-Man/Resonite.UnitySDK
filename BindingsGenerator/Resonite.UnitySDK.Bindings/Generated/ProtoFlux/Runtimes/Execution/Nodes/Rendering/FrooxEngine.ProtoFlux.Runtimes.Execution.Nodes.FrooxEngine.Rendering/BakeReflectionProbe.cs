
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Rendering.BakeReflectionProbe
// Generated on: čtvrtek 26. února 2026 10:04:29
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
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.ReflectionProbe> Probe { get => Probe_Element.Data; set => Probe_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.ReflectionProbe>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.ReflectionProbe>> Probe_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnBakeStart { get => OnBakeStart_Element.Data; set => OnBakeStart_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnBakeStart_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnBakeFail { get => OnBakeFail_Element.Data; set => OnBakeFail_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnBakeFail_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnBakeComplete { get => OnBakeComplete_Element.Data; set => OnBakeComplete_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnBakeComplete_Element = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<System.Uri> BakedCubemapURL = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Probe", Probe_Element.Data.ToResoniteReference(context));
members.Add("OnBakeStart", OnBakeStart_Element.Data.ToResoniteReference(context));
members.Add("OnBakeFail", OnBakeFail_Element.Data.ToResoniteReference(context));
members.Add("OnBakeComplete", OnBakeComplete_Element.Data.ToResoniteReference(context));
members.Add("BakedCubemapURL", new ResoniteLink.EmptyElement());
}

}
}
