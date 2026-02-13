
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarPoseBoxConstraint
// Generated on: pátek 13. února 2026 5:52:39
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarPoseBoxConstraint")]
public partial class AvatarPoseBoxConstraint : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarPoseFilter

{
    public UnityEngine.Vector3 BoxSize;
public global::FrooxEngine.Slot DefaultPoseReference;
public global::System.Boolean ProcessSimulatedPoses;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("BoxSize", BoxSize.ToResoniteLinkField());
members.Add("DefaultPoseReference", new ResoniteLink.Reference() { });
members.Add("ProcessSimulatedPoses", ProcessSimulatedPoses.ToResoniteLinkField());
}

}
}
