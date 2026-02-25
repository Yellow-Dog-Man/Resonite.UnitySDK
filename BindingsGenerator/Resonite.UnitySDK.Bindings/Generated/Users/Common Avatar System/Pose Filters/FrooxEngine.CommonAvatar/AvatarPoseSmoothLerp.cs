
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarPoseSmoothLerp
// Generated on: středa 25. února 2026 16:13:38
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarPoseSmoothLerp")]
public partial class AvatarPoseSmoothLerp : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarPoseFilter

{
    public global::System.Single PositionSmoothSpeed;
public global::System.Single RotationSmoothSpeed;
public global::System.Boolean SmoothSimulatedPoses;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PositionSmoothSpeed", PositionSmoothSpeed.ToResoniteLinkField());
members.Add("RotationSmoothSpeed", RotationSmoothSpeed.ToResoniteLinkField());
members.Add("SmoothSimulatedPoses", SmoothSimulatedPoses.ToResoniteLinkField());
}

}
}
