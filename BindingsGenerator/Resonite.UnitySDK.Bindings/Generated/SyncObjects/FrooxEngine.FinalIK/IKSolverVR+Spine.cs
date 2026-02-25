
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.IKSolverVR+Spine
// Generated on: středa 25. února 2026 16:14:38
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.FinalIK
{
    public partial class IKSolverVR
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FinalIK.IKSolverVR+Spine")]
public partial class Spine : global::FrooxEngine.FinalIK.IKSolverVR.BodyPart

{
    public global::FrooxEngine.Slot HeadTarget;
public global::FrooxEngine.Slot PelvisTarget;
public global::System.Single PositionWeight;
public global::System.Single RotationWeight;
public global::System.Single PelvisPositionWeight;
public global::System.Single PelvisRotationWeight;
public global::FrooxEngine.Slot ChestGoal;
public global::System.Single ChestGoalWeight;
public global::System.Single MinHeadHeight;
public global::System.Single BodyPosStiffness;
public global::System.Single BodyRotStiffness;
public global::System.Single NeckStiffness;
public global::System.Single RotateChestByHands;
public global::System.Single ChestClampWeight;
public global::System.Single HeadClampWeight;
public global::System.Single MoveBodyBackWhenCrouching;
public global::System.Single MaintainPelvisPosition;
public global::System.Single MaxRootAngle;
public UnityEngine.Vector3 IKPositionHead;
public UnityEngine.Quaternion IKRotationHead;
public UnityEngine.Vector3 IKPositionPelvis;
public UnityEngine.Quaternion IKRotationPelvis;
public UnityEngine.Vector3 GoalPositionChest;
public global::System.Single headHeight;
public UnityEngine.Quaternion anchorRelativeToHead;
public UnityEngine.Quaternion pelvisRelativeRotation;
public UnityEngine.Quaternion chestRelativeRotation;
public UnityEngine.Vector3 chestForward;
public UnityEngine.Vector3 pelvisForward;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HeadTarget", HeadTarget.ToResoniteReference(context));
members.Add("PelvisTarget", PelvisTarget.ToResoniteReference(context));
members.Add("PositionWeight", PositionWeight.ToResoniteLinkField());
members.Add("RotationWeight", RotationWeight.ToResoniteLinkField());
members.Add("PelvisPositionWeight", PelvisPositionWeight.ToResoniteLinkField());
members.Add("PelvisRotationWeight", PelvisRotationWeight.ToResoniteLinkField());
members.Add("ChestGoal", ChestGoal.ToResoniteReference(context));
members.Add("ChestGoalWeight", ChestGoalWeight.ToResoniteLinkField());
members.Add("MinHeadHeight", MinHeadHeight.ToResoniteLinkField());
members.Add("BodyPosStiffness", BodyPosStiffness.ToResoniteLinkField());
members.Add("BodyRotStiffness", BodyRotStiffness.ToResoniteLinkField());
members.Add("NeckStiffness", NeckStiffness.ToResoniteLinkField());
members.Add("RotateChestByHands", RotateChestByHands.ToResoniteLinkField());
members.Add("ChestClampWeight", ChestClampWeight.ToResoniteLinkField());
members.Add("HeadClampWeight", HeadClampWeight.ToResoniteLinkField());
members.Add("MoveBodyBackWhenCrouching", MoveBodyBackWhenCrouching.ToResoniteLinkField());
members.Add("MaintainPelvisPosition", MaintainPelvisPosition.ToResoniteLinkField());
members.Add("MaxRootAngle", MaxRootAngle.ToResoniteLinkField());
members.Add("IKPositionHead", IKPositionHead.ToResoniteLinkField());
members.Add("IKRotationHead", IKRotationHead.ToResoniteLinkField());
members.Add("IKPositionPelvis", IKPositionPelvis.ToResoniteLinkField());
members.Add("IKRotationPelvis", IKRotationPelvis.ToResoniteLinkField());
members.Add("GoalPositionChest", GoalPositionChest.ToResoniteLinkField());
members.Add("headHeight", headHeight.ToResoniteLinkField());
members.Add("anchorRelativeToHead", anchorRelativeToHead.ToResoniteLinkField());
members.Add("pelvisRelativeRotation", pelvisRelativeRotation.ToResoniteLinkField());
members.Add("chestRelativeRotation", chestRelativeRotation.ToResoniteLinkField());
members.Add("chestForward", chestForward.ToResoniteLinkField());
members.Add("pelvisForward", pelvisForward.ToResoniteLinkField());
}

}
            }
}
