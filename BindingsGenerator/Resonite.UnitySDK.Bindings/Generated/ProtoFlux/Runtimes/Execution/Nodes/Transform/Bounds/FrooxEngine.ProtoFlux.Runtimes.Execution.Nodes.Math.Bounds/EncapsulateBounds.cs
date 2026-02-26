
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Bounds.EncapsulateBounds
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Bounds.EncapsulateBounds")]
public partial class EncapsulateBounds : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Bounds>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Bounds> Bounds { get => Bounds_Element.Data; set => Bounds_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Bounds>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Bounds>> Bounds_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Bounds> OtherBounds { get => OtherBounds_Element.Data; set => OtherBounds_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Bounds>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Bounds>> OtherBounds_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Bounds", Bounds_Element.ToLinkReference(context));
members.Add("OtherBounds", OtherBounds_Element.ToLinkReference(context));
}

}
}
