
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocomotionAnimationHandMetrics
// Generated on: středa 25. února 2026 16:14:45
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocomotionAnimationHandMetrics")]
public partial class LocomotionAnimationHandMetrics : global::FrooxEngine.LocomotionAnimationParametersBase

{
    public global::FrooxEngine.LocomotionMetricsSpace Space;
public global::System.Nullable<global::System.Single> ShoulderSeparation;
public global::System.Nullable<global::System.Single> ShoulderHeight;
public global::System.Nullable<global::System.Single> ShoulderOffset;
public global::System.Nullable<global::System.Single> HandOffset;
public global::System.Nullable<global::System.Single> ArmLength;
public global::System.Nullable<global::System.Single> HandPalmDistance;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Space", Space.ToResoniteLinkField());
members.Add("ShoulderSeparation", ShoulderSeparation.ToResoniteLinkField());
members.Add("ShoulderHeight", ShoulderHeight.ToResoniteLinkField());
members.Add("ShoulderOffset", ShoulderOffset.ToResoniteLinkField());
members.Add("HandOffset", HandOffset.ToResoniteLinkField());
members.Add("ArmLength", ArmLength.ToResoniteLinkField());
members.Add("HandPalmDistance", HandPalmDistance.ToResoniteLinkField());
}

}
}
