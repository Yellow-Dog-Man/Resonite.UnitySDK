
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Bounds.ComputeBoundingBox
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Bounds.ComputeBoundingBox")]
public partial class ComputeBoundingBox : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::Elements.Core.BoundingBox>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> Instance;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> IncludeInactive;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> CoordinateSpace;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> OnlyWithTag;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Instance", Instance.ToResoniteReference(context));
members.Add("IncludeInactive", IncludeInactive.ToResoniteReference(context));
members.Add("CoordinateSpace", CoordinateSpace.ToResoniteReference(context));
members.Add("OnlyWithTag", OnlyWithTag.ToResoniteReference(context));
}

}
}
