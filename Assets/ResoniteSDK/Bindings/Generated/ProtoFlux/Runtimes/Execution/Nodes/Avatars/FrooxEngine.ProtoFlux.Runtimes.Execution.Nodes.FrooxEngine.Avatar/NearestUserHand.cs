
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.NearestUserHand
// Generated on: sobota 14. února 2026 8:57:46
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.NearestUserHand")]
public partial class NearestUserHand : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.NearestUserNode<global::ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.NearestUserHand.Data>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> GetLeft;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> GetRight;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::Renderite.Shared.Chirality> Chirality;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("GetLeft", GetLeft.ToResoniteReference(context));
members.Add("GetRight", GetRight.ToResoniteReference(context));
members.Add("Chirality", new ResoniteLink.EmptyElement());
}

}
}
