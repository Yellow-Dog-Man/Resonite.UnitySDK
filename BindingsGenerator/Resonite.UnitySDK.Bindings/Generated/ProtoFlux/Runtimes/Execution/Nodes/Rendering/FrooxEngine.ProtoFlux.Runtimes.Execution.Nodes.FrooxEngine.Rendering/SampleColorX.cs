
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Rendering.SampleColorX
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Rendering.SampleColorX")]
public partial class SampleColorX : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Point { get => Point_Element.Data; set => Point_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>> Point_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Direction { get => Direction_Element.Data; set => Direction_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>> Direction_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> Reference { get => Reference_Element.Data; set => Reference_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot>> Reference_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> NearClip { get => NearClip_Element.Data; set => NearClip_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> NearClip_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> FarClip { get => FarClip_Element.Data; set => FarClip_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> FarClip_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnSampleStart { get => OnSampleStart_Element.Data; set => OnSampleStart_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnSampleStart_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnSampled { get => OnSampled_Element.Data; set => OnSampled_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnSampled_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.ColorX> SampledColor = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Point", Point_Element.Data.ToResoniteReference(context));
members.Add("Direction", Direction_Element.Data.ToResoniteReference(context));
members.Add("Reference", Reference_Element.Data.ToResoniteReference(context));
members.Add("NearClip", NearClip_Element.Data.ToResoniteReference(context));
members.Add("FarClip", FarClip_Element.Data.ToResoniteReference(context));
members.Add("OnSampleStart", OnSampleStart_Element.Data.ToResoniteReference(context));
members.Add("OnSampled", OnSampled_Element.Data.ToResoniteReference(context));
members.Add("SampledColor", new ResoniteLink.EmptyElement());
}

}
}
