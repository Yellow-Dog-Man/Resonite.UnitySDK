
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Bounds.ComputeBoundingBox
// Generated on: pátek 13. února 2026 23:22:57
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Bounds.ComputeBoundingBox")]
public partial class ComputeBoundingBox : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::Elements.Core.BoundingBox>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> Instance;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> IncludeInactive;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> CoordinateSpace;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> OnlyWithTag;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Instance", new ResoniteLink.Reference() { });
members.Add("IncludeInactive", new ResoniteLink.Reference() { });
members.Add("CoordinateSpace", new ResoniteLink.Reference() { });
members.Add("OnlyWithTag", new ResoniteLink.Reference() { });
}

}
}
