
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RepulsionTreeSimulator
// Generated on: čtvrtek 19. února 2026 8:00:30
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RepulsionTreeSimulator")]
public partial class RepulsionTreeSimulator : global::FrooxEngine.Component, global::FrooxEngine.IRepulsionTreeNode

{
    public global::System.Single FalloffPower;
public global::System.Single Radius;
public global::System.Single Force;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FalloffPower", FalloffPower.ToResoniteLinkField());
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("Force", Force.ToResoniteLinkField());
}

}
}
