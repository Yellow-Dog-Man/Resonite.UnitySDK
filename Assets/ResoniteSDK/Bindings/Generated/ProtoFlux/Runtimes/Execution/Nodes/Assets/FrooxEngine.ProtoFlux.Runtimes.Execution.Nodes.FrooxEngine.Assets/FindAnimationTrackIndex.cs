
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.FindAnimationTrackIndex
// Generated on: sobota 14. února 2026 8:57:45
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.FindAnimationTrackIndex")]
public partial class FindAnimationTrackIndex : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::System.Int32>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Animation> Animation;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Node;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Property;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Animation", Animation.ToResoniteReference(context));
members.Add("Node", Node.ToResoniteReference(context));
members.Add("Property", Property.ToResoniteReference(context));
}

}
}
