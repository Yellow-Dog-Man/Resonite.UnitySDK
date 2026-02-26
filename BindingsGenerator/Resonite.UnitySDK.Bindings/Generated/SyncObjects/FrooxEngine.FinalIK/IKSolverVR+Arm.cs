
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.IKSolverVR+Arm
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FinalIK.IKSolverVR+Arm")]
public partial class Arm : global::FrooxEngine.FinalIK.IKSolverVR.BodyPart

{
    public global::FrooxEngine.Slot Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Target_Element = new();
public global::FrooxEngine.Slot BendGoal { get => BendGoal_Element.Data; set => BendGoal_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> BendGoal_Element = new();
public global::System.Single PositionWeight { get => PositionWeight_Element.Data; set => PositionWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PositionWeight_Element = new();
public global::System.Single RotationWeight { get => RotationWeight_Element.Data; set => RotationWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RotationWeight_Element = new();
public global::FrooxEngine.FinalIK.IKSolverVR.Arm.ShoulderRotationMode ShoulderRotationModeSetting { get => ShoulderRotationModeSetting_Element.Data; set => ShoulderRotationModeSetting_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.FinalIK.IKSolverVR.Arm.ShoulderRotationMode>, global::FrooxEngine.FinalIK.IKSolverVR.Arm.ShoulderRotationMode> ShoulderRotationModeSetting_Element = new();
public global::System.Single ShoulderRotationWeight { get => ShoulderRotationWeight_Element.Data; set => ShoulderRotationWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ShoulderRotationWeight_Element = new();
public global::System.Single BendGoalWeight { get => BendGoalWeight_Element.Data; set => BendGoalWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BendGoalWeight_Element = new();
public global::System.Single SwivelOffset { get => SwivelOffset_Element.Data; set => SwivelOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SwivelOffset_Element = new();
public UnityEngine.Vector3 WristToPalmAxis { get => WristToPalmAxis_Element.Data; set => WristToPalmAxis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> WristToPalmAxis_Element = new();
public UnityEngine.Vector3 PalmToThumbAxis { get => PalmToThumbAxis_Element.Data; set => PalmToThumbAxis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> PalmToThumbAxis_Element = new();
public global::System.Single ArmLengthMlp { get => ArmLengthMlp_Element.Data; set => ArmLengthMlp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ArmLengthMlp_Element = new();
public global::SyncArray<global::FrooxEngine.SyncCurve<global::System.Single>, global::FrooxEngine.CurveKey<global::System.Single>> StretchCurve = new();
public UnityEngine.Vector3 IKPosition { get => IKPosition_Element.Data; set => IKPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> IKPosition_Element = new();
public UnityEngine.Quaternion IKRotation { get => IKRotation_Element.Data; set => IKRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> IKRotation_Element = new();
public UnityEngine.Vector3 BendGoalPosition { get => BendGoalPosition_Element.Data; set => BendGoalPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> BendGoalPosition_Element = new();
public global::System.Single TwistRelaxWeight { get => TwistRelaxWeight_Element.Data; set => TwistRelaxWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TwistRelaxWeight_Element = new();
public global::System.Single TwistCrossfade { get => TwistCrossfade_Element.Data; set => TwistCrossfade_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TwistCrossfade_Element = new();
public global::System.Single TwistAngleOffset { get => TwistAngleOffset_Element.Data; set => TwistAngleOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TwistAngleOffset_Element = new();
public UnityEngine.Vector3 chestForwardAxis { get => chestForwardAxis_Element.Data; set => chestForwardAxis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> chestForwardAxis_Element = new();
public UnityEngine.Vector3 chestUpAxis { get => chestUpAxis_Element.Data; set => chestUpAxis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> chestUpAxis_Element = new();
public UnityEngine.Vector3 forearmTwistAxis { get => forearmTwistAxis_Element.Data; set => forearmTwistAxis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> forearmTwistAxis_Element = new();
public UnityEngine.Vector3 forearmAxis { get => forearmAxis_Element.Data; set => forearmAxis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> forearmAxis_Element = new();
public UnityEngine.Vector3 axisRelativeToUpperArm { get => axisRelativeToUpperArm_Element.Data; set => axisRelativeToUpperArm_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> axisRelativeToUpperArm_Element = new();
public UnityEngine.Vector3 axisRelativeToHand { get => axisRelativeToHand_Element.Data; set => axisRelativeToHand_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> axisRelativeToHand_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("BendGoal", BendGoal_Element.ToLinkReference(context));
members.Add("PositionWeight", PositionWeight_Element.ToLinkField(context));
members.Add("RotationWeight", RotationWeight_Element.ToLinkField(context));
members.Add("ShoulderRotationModeSetting", ShoulderRotationModeSetting_Element.ToLinkField(context));
members.Add("ShoulderRotationWeight", ShoulderRotationWeight_Element.ToLinkField(context));
members.Add("BendGoalWeight", BendGoalWeight_Element.ToLinkField(context));
members.Add("SwivelOffset", SwivelOffset_Element.ToLinkField(context));
members.Add("WristToPalmAxis", WristToPalmAxis_Element.ToLinkField(context));
members.Add("PalmToThumbAxis", PalmToThumbAxis_Element.ToLinkField(context));
members.Add("ArmLengthMlp", ArmLengthMlp_Element.ToLinkField(context));
members.Add("StretchCurve", StretchCurve.ToLinkArray(context));
members.Add("IKPosition", IKPosition_Element.ToLinkField(context));
members.Add("IKRotation", IKRotation_Element.ToLinkField(context));
members.Add("BendGoalPosition", BendGoalPosition_Element.ToLinkField(context));
members.Add("TwistRelaxWeight", TwistRelaxWeight_Element.ToLinkField(context));
members.Add("TwistCrossfade", TwistCrossfade_Element.ToLinkField(context));
members.Add("TwistAngleOffset", TwistAngleOffset_Element.ToLinkField(context));
members.Add("chestForwardAxis", chestForwardAxis_Element.ToLinkField(context));
members.Add("chestUpAxis", chestUpAxis_Element.ToLinkField(context));
members.Add("forearmTwistAxis", forearmTwistAxis_Element.ToLinkField(context));
members.Add("forearmAxis", forearmAxis_Element.ToLinkField(context));
members.Add("axisRelativeToUpperArm", axisRelativeToUpperArm_Element.ToLinkField(context));
members.Add("axisRelativeToHand", axisRelativeToHand_Element.ToLinkField(context));
}

}
            }
}
