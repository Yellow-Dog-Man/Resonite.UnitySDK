
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarPoseBoxConstraint
// Generated on: středa 25. února 2026 16:14:46
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarPoseBoxConstraint")]
public partial class AvatarPoseBoxConstraint : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarPoseFilter

{
    public UnityEngine.Vector3 BoxSize;
public global::FrooxEngine.Slot DefaultPoseReference;
public global::System.Boolean ProcessSimulatedPoses;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BoxSize", BoxSize.ToResoniteLinkField());
members.Add("DefaultPoseReference", DefaultPoseReference.ToResoniteReference(context));
members.Add("ProcessSimulatedPoses", ProcessSimulatedPoses.ToResoniteLinkField());
}

}
}
