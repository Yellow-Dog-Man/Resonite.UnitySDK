
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.NearestUserFoot
// Generated on: čtvrtek 19. února 2026 7:59:42
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.NearestUserFoot")]
public partial class NearestUserFoot : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.NearestUserNode<global::ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.NearestUserFoot.Data>

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
