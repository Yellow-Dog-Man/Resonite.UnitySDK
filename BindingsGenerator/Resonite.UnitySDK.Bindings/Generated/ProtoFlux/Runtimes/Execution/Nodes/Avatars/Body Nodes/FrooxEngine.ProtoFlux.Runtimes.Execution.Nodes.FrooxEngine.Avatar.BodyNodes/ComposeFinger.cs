
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.BodyNodes.ComposeFinger
// Generated on: čtvrtek 26. února 2026 10:04:07
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.BodyNodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.BodyNodes.ComposeFinger")]
public partial class ComposeFinger : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::Renderite.Shared.BodyNode>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.FingerType> Finger { get => Finger_Element.Data; set => Finger_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.FingerType>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.FingerType>> Finger_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.FingerSegmentType> Segment { get => Segment_Element.Data; set => Segment_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.FingerSegmentType>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.FingerSegmentType>> Segment_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.Chirality> Chirality { get => Chirality_Element.Data; set => Chirality_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.Chirality>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.Chirality>> Chirality_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Finger", Finger_Element.Data.ToResoniteReference(context));
members.Add("Segment", Segment_Element.Data.ToResoniteReference(context));
members.Add("Chirality", Chirality_Element.Data.ToResoniteReference(context));
}

}
}
