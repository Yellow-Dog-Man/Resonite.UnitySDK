
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarPoseSmoothLerp
// Generated on: čtvrtek 26. února 2026 10:04:06
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
    public global::System.Single PositionSmoothSpeed { get => PositionSmoothSpeed_Element.Data; set => PositionSmoothSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PositionSmoothSpeed_Element = new();
public global::System.Single RotationSmoothSpeed { get => RotationSmoothSpeed_Element.Data; set => RotationSmoothSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RotationSmoothSpeed_Element = new();
public global::System.Boolean SmoothSimulatedPoses { get => SmoothSimulatedPoses_Element.Data; set => SmoothSimulatedPoses_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SmoothSimulatedPoses_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PositionSmoothSpeed", PositionSmoothSpeed_Element.Data.ToResoniteLinkField());
members.Add("RotationSmoothSpeed", RotationSmoothSpeed_Element.Data.ToResoniteLinkField());
members.Add("SmoothSimulatedPoses", SmoothSimulatedPoses_Element.Data.ToResoniteLinkField());
}

}
}
