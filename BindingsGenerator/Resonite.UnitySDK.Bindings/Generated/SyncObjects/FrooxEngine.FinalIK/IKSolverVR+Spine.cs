
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.IKSolverVR+Spine
// Generated on: čtvrtek 26. února 2026 15:09:11
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.Slot HeadTarget { get => HeadTarget_Element.Data; set => HeadTarget_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> HeadTarget_Element = new();
public global::FrooxEngine.Slot PelvisTarget { get => PelvisTarget_Element.Data; set => PelvisTarget_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> PelvisTarget_Element = new();
public global::System.Single PositionWeight { get => PositionWeight_Element.Data; set => PositionWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PositionWeight_Element = new();
public global::System.Single RotationWeight { get => RotationWeight_Element.Data; set => RotationWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RotationWeight_Element = new();
public global::System.Single PelvisPositionWeight { get => PelvisPositionWeight_Element.Data; set => PelvisPositionWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PelvisPositionWeight_Element = new();
public global::System.Single PelvisRotationWeight { get => PelvisRotationWeight_Element.Data; set => PelvisRotationWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PelvisRotationWeight_Element = new();
public global::FrooxEngine.Slot ChestGoal { get => ChestGoal_Element.Data; set => ChestGoal_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> ChestGoal_Element = new();
public global::System.Single ChestGoalWeight { get => ChestGoalWeight_Element.Data; set => ChestGoalWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ChestGoalWeight_Element = new();
public global::System.Single MinHeadHeight { get => MinHeadHeight_Element.Data; set => MinHeadHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinHeadHeight_Element = new();
public global::System.Single BodyPosStiffness { get => BodyPosStiffness_Element.Data; set => BodyPosStiffness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BodyPosStiffness_Element = new();
public global::System.Single BodyRotStiffness { get => BodyRotStiffness_Element.Data; set => BodyRotStiffness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BodyRotStiffness_Element = new();
public global::System.Single NeckStiffness { get => NeckStiffness_Element.Data; set => NeckStiffness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NeckStiffness_Element = new();
public global::System.Single RotateChestByHands { get => RotateChestByHands_Element.Data; set => RotateChestByHands_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RotateChestByHands_Element = new();
public global::System.Single ChestClampWeight { get => ChestClampWeight_Element.Data; set => ChestClampWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ChestClampWeight_Element = new();
public global::System.Single HeadClampWeight { get => HeadClampWeight_Element.Data; set => HeadClampWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadClampWeight_Element = new();
public global::System.Single MoveBodyBackWhenCrouching { get => MoveBodyBackWhenCrouching_Element.Data; set => MoveBodyBackWhenCrouching_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MoveBodyBackWhenCrouching_Element = new();
public global::System.Single MaintainPelvisPosition { get => MaintainPelvisPosition_Element.Data; set => MaintainPelvisPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaintainPelvisPosition_Element = new();
public global::System.Single MaxRootAngle { get => MaxRootAngle_Element.Data; set => MaxRootAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxRootAngle_Element = new();
public UnityEngine.Vector3 IKPositionHead { get => IKPositionHead_Element.Data; set => IKPositionHead_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> IKPositionHead_Element = new();
public UnityEngine.Quaternion IKRotationHead { get => IKRotationHead_Element.Data; set => IKRotationHead_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> IKRotationHead_Element = new();
public UnityEngine.Vector3 IKPositionPelvis { get => IKPositionPelvis_Element.Data; set => IKPositionPelvis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> IKPositionPelvis_Element = new();
public UnityEngine.Quaternion IKRotationPelvis { get => IKRotationPelvis_Element.Data; set => IKRotationPelvis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> IKRotationPelvis_Element = new();
public UnityEngine.Vector3 GoalPositionChest { get => GoalPositionChest_Element.Data; set => GoalPositionChest_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> GoalPositionChest_Element = new();
public global::System.Single headHeight { get => headHeight_Element.Data; set => headHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> headHeight_Element = new();
public UnityEngine.Quaternion anchorRelativeToHead { get => anchorRelativeToHead_Element.Data; set => anchorRelativeToHead_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> anchorRelativeToHead_Element = new();
public UnityEngine.Quaternion pelvisRelativeRotation { get => pelvisRelativeRotation_Element.Data; set => pelvisRelativeRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> pelvisRelativeRotation_Element = new();
public UnityEngine.Quaternion chestRelativeRotation { get => chestRelativeRotation_Element.Data; set => chestRelativeRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> chestRelativeRotation_Element = new();
public UnityEngine.Vector3 chestForward { get => chestForward_Element.Data; set => chestForward_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> chestForward_Element = new();
public UnityEngine.Vector3 pelvisForward { get => pelvisForward_Element.Data; set => pelvisForward_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> pelvisForward_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HeadTarget", HeadTarget_Element.ToLinkReference(context));
members.Add("PelvisTarget", PelvisTarget_Element.ToLinkReference(context));
members.Add("PositionWeight", PositionWeight_Element.ToLinkField(context));
members.Add("RotationWeight", RotationWeight_Element.ToLinkField(context));
members.Add("PelvisPositionWeight", PelvisPositionWeight_Element.ToLinkField(context));
members.Add("PelvisRotationWeight", PelvisRotationWeight_Element.ToLinkField(context));
members.Add("ChestGoal", ChestGoal_Element.ToLinkReference(context));
members.Add("ChestGoalWeight", ChestGoalWeight_Element.ToLinkField(context));
members.Add("MinHeadHeight", MinHeadHeight_Element.ToLinkField(context));
members.Add("BodyPosStiffness", BodyPosStiffness_Element.ToLinkField(context));
members.Add("BodyRotStiffness", BodyRotStiffness_Element.ToLinkField(context));
members.Add("NeckStiffness", NeckStiffness_Element.ToLinkField(context));
members.Add("RotateChestByHands", RotateChestByHands_Element.ToLinkField(context));
members.Add("ChestClampWeight", ChestClampWeight_Element.ToLinkField(context));
members.Add("HeadClampWeight", HeadClampWeight_Element.ToLinkField(context));
members.Add("MoveBodyBackWhenCrouching", MoveBodyBackWhenCrouching_Element.ToLinkField(context));
members.Add("MaintainPelvisPosition", MaintainPelvisPosition_Element.ToLinkField(context));
members.Add("MaxRootAngle", MaxRootAngle_Element.ToLinkField(context));
members.Add("IKPositionHead", IKPositionHead_Element.ToLinkField(context));
members.Add("IKRotationHead", IKRotationHead_Element.ToLinkField(context));
members.Add("IKPositionPelvis", IKPositionPelvis_Element.ToLinkField(context));
members.Add("IKRotationPelvis", IKRotationPelvis_Element.ToLinkField(context));
members.Add("GoalPositionChest", GoalPositionChest_Element.ToLinkField(context));
members.Add("headHeight", headHeight_Element.ToLinkField(context));
members.Add("anchorRelativeToHead", anchorRelativeToHead_Element.ToLinkField(context));
members.Add("pelvisRelativeRotation", pelvisRelativeRotation_Element.ToLinkField(context));
members.Add("chestRelativeRotation", chestRelativeRotation_Element.ToLinkField(context));
members.Add("chestForward", chestForward_Element.ToLinkField(context));
members.Add("pelvisForward", pelvisForward_Element.ToLinkField(context));
}

}
            }
}
