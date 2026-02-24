
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Rects.RectFromXYWH
// Generated on: úterý 24. února 2026 18:19:28
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Rects
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Rects.RectFromXYWH")]
public partial class RectFromXYWH : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Rect>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> X;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Y;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Width;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Height;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("X", X.ToResoniteReference(context));
members.Add("Y", Y.ToResoniteReference(context));
members.Add("Width", Width.ToResoniteReference(context));
members.Add("Height", Height.ToResoniteReference(context));
}

}
}
