
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarPoseRotationConstraint
// Generated on: sobota 14. února 2026 8:58:50
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarPoseRotationConstraint")]
public partial class AvatarPoseRotationConstraint : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarPoseFilter

{
    public global::System.Single MaxTwist;
public global::System.Single MaxSwing;
public UnityEngine.Vector3 Axis;
public UnityEngine.Vector3 TwistReferenceAxis;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxTwist", MaxTwist.ToResoniteLinkField());
members.Add("MaxSwing", MaxSwing.ToResoniteLinkField());
members.Add("Axis", Axis.ToResoniteLinkField());
members.Add("TwistReferenceAxis", TwistReferenceAxis.ToResoniteLinkField());
}

}
}
