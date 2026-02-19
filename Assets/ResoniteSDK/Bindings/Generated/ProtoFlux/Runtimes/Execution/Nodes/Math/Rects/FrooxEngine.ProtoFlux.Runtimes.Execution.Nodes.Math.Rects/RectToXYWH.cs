
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Rects.RectToXYWH
// Generated on: čtvrtek 19. února 2026 7:59:59
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Rects
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Rects.RectToXYWH")]
public partial class RectToXYWH : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Rect> Rect;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> X;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Y;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Width;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Height;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Rect", Rect.ToResoniteReference(context));
members.Add("X", new ResoniteLink.EmptyElement());
members.Add("Y", new ResoniteLink.EmptyElement());
members.Add("Width", new ResoniteLink.EmptyElement());
members.Add("Height", new ResoniteLink.EmptyElement());
}

}
}
