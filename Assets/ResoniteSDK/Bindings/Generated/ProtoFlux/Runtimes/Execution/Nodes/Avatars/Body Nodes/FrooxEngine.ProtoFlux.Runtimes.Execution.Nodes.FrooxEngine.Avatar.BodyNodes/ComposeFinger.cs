
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.BodyNodes.ComposeFinger
// Generated on: pátek 13. února 2026 5:51:45
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.FingerType> Finger;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.FingerSegmentType> Segment;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.Chirality> Chirality;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Finger", new ResoniteLink.Reference() { });
members.Add("Segment", new ResoniteLink.Reference() { });
members.Add("Chirality", new ResoniteLink.Reference() { });
}

}
}
