
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Bounds.BoundingBoxProperties
// Generated on: sobota 14. února 2026 8:58:27
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Elements.Core.BoundingBox> Bounds;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Min;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Max;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Center;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Size;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Valid;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Empty;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Bounds", Bounds.ToResoniteReference(context));
members.Add("Min", new ResoniteLink.EmptyElement());
members.Add("Max", new ResoniteLink.EmptyElement());
members.Add("Center", new ResoniteLink.EmptyElement());
members.Add("Size", new ResoniteLink.EmptyElement());
members.Add("Valid", new ResoniteLink.EmptyElement());
members.Add("Empty", new ResoniteLink.EmptyElement());
}

}
}
