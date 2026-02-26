
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Bounds.BoundingBoxProperties
// Generated on: čtvrtek 26. února 2026 15:08:58
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Bounds
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Bounds.BoundingBoxProperties")]
public partial class BoundingBoxProperties : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Bounds> Bounds { get => Bounds_Element.Data; set => Bounds_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Bounds>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Bounds>> Bounds_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Min = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Max = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Center = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Size = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Valid = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Empty = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Bounds", Bounds_Element.ToLinkReference(context));
members.Add("Min", Min.ToLinkEmpty(context));
members.Add("Max", Max.ToLinkEmpty(context));
members.Add("Center", Center.ToLinkEmpty(context));
members.Add("Size", Size.ToLinkEmpty(context));
members.Add("Valid", Valid.ToLinkEmpty(context));
members.Add("Empty", Empty.ToLinkEmpty(context));
}

}
}
