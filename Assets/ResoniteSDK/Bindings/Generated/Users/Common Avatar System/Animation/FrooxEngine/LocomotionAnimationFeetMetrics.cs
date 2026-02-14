
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocomotionAnimationFeetMetrics
// Generated on: sobota 14. února 2026 8:58:50
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocomotionAnimationFeetMetrics")]
public partial class LocomotionAnimationFeetMetrics : global::FrooxEngine.LocomotionAnimationParametersBase

{
    public global::FrooxEngine.LocomotionMetricsSpace Space;
public global::System.Nullable<global::System.Single> FeetSeparation;
public global::System.Nullable<global::System.Single> FeetBackwardsOffset;
public global::System.Nullable<global::System.Single> FootHeight;
public global::System.Nullable<global::System.Single> FootFrontOffset;
public global::System.Nullable<global::System.Single> FootBackOffset;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Space", Space.ToResoniteLinkField());
members.Add("FeetSeparation", FeetSeparation.ToResoniteLinkField());
members.Add("FeetBackwardsOffset", FeetBackwardsOffset.ToResoniteLinkField());
members.Add("FootHeight", FootHeight.ToResoniteLinkField());
members.Add("FootFrontOffset", FootFrontOffset.ToResoniteLinkField());
members.Add("FootBackOffset", FootBackOffset.ToResoniteLinkField());
}

}
}
