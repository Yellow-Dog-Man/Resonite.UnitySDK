
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.Anchors.AnchorLocomotionData
// Generated on: čtvrtek 26. února 2026 12:27:26
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnLocomotionUpdate { get => OnLocomotionUpdate_Element.Data; set => OnLocomotionUpdate_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> OnLocomotionUpdate_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> HasPrimary = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> HasSecondary = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> PrimaryAxis = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> SecondaryAxis = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> PrimaryAction = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> SecondaryAction = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnLocomotionUpdate", OnLocomotionUpdate_Element.ToLinkReference(context));
members.Add("HasPrimary", HasPrimary.ToLinkEmpty(context));
members.Add("HasSecondary", HasSecondary.ToLinkEmpty(context));
members.Add("PrimaryAxis", PrimaryAxis.ToLinkEmpty(context));
members.Add("SecondaryAxis", SecondaryAxis.ToLinkEmpty(context));
members.Add("PrimaryAction", PrimaryAction.ToLinkEmpty(context));
members.Add("SecondaryAction", SecondaryAction.ToLinkEmpty(context));
}

}
}
