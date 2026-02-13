
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Rects.RectFromXYWH
// Generated on: pátek 13. února 2026 23:22:38
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("X", new ResoniteLink.Reference() { });
members.Add("Y", new ResoniteLink.Reference() { });
members.Add("Width", new ResoniteLink.Reference() { });
members.Add("Height", new ResoniteLink.Reference() { });
}

}
}
