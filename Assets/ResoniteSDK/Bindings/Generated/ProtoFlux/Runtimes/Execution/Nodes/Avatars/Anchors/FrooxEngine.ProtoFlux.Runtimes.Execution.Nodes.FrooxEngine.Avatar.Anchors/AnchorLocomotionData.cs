
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.Anchors.AnchorLocomotionData
// Generated on: úterý 24. února 2026 18:18:57
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.Anchors
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.Anchors.AnchorLocomotionData")]
public partial class AnchorLocomotionData : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.Anchors.AnchorEventsBase, global::FrooxEngine.FrooxEngine.ProtoFlux.IMappableNode, global::FrooxEngine.ProtoFlux.IProtoFluxNode<global::FrooxEngine.ProtoFlux.IMappableNode>

{
    public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnLocomotionUpdate;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> HasPrimary;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> HasSecondary;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> PrimaryAxis;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> SecondaryAxis;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> PrimaryAction;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> SecondaryAction;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnLocomotionUpdate", OnLocomotionUpdate.ToResoniteReference(context));
members.Add("HasPrimary", new ResoniteLink.EmptyElement());
members.Add("HasSecondary", new ResoniteLink.EmptyElement());
members.Add("PrimaryAxis", new ResoniteLink.EmptyElement());
members.Add("SecondaryAxis", new ResoniteLink.EmptyElement());
members.Add("PrimaryAction", new ResoniteLink.EmptyElement());
members.Add("SecondaryAction", new ResoniteLink.EmptyElement());
}

}
}
