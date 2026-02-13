
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.IKSolverVR+Arm
// Generated on: pátek 13. února 2026 23:23:14
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.Slot Target;
public global::FrooxEngine.Slot BendGoal;
public global::System.Single PositionWeight;
public global::System.Single RotationWeight;
public global::FrooxEngine.FinalIK.IKSolverVR.Arm.ShoulderRotationMode ShoulderRotationModeSetting;
public global::System.Single ShoulderRotationWeight;
public global::System.Single BendGoalWeight;
public global::System.Single SwivelOffset;
public UnityEngine.Vector3 WristToPalmAxis;
public UnityEngine.Vector3 PalmToThumbAxis;
public global::System.Single ArmLengthMlp;
public global::FrooxEngine.CurveKey<global::System.Single>[] StretchCurve;
public UnityEngine.Vector3 IKPosition;
public UnityEngine.Quaternion IKRotation;
public UnityEngine.Vector3 BendGoalPosition;
public global::System.Single TwistRelaxWeight;
public global::System.Single TwistCrossfade;
public global::System.Single TwistAngleOffset;
public UnityEngine.Vector3 chestForwardAxis;
public UnityEngine.Vector3 chestUpAxis;
public UnityEngine.Vector3 forearmTwistAxis;
public UnityEngine.Vector3 forearmAxis;
public UnityEngine.Vector3 axisRelativeToUpperArm;
public UnityEngine.Vector3 axisRelativeToHand;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("BendGoal", new ResoniteLink.Reference() { });
members.Add("PositionWeight", PositionWeight.ToResoniteLinkField());
members.Add("RotationWeight", RotationWeight.ToResoniteLinkField());
members.Add("ShoulderRotationModeSetting", ShoulderRotationModeSetting.ToResoniteLinkField());
members.Add("ShoulderRotationWeight", ShoulderRotationWeight.ToResoniteLinkField());
members.Add("BendGoalWeight", BendGoalWeight.ToResoniteLinkField());
members.Add("SwivelOffset", SwivelOffset.ToResoniteLinkField());
members.Add("WristToPalmAxis", WristToPalmAxis.ToResoniteLinkField());
members.Add("PalmToThumbAxis", PalmToThumbAxis.ToResoniteLinkField());
members.Add("ArmLengthMlp", ArmLengthMlp.ToResoniteLinkField());
members.Add("StretchCurve", StretchCurve.ToResoniteLinkArray());
members.Add("IKPosition", IKPosition.ToResoniteLinkField());
members.Add("IKRotation", IKRotation.ToResoniteLinkField());
members.Add("BendGoalPosition", BendGoalPosition.ToResoniteLinkField());
members.Add("TwistRelaxWeight", TwistRelaxWeight.ToResoniteLinkField());
members.Add("TwistCrossfade", TwistCrossfade.ToResoniteLinkField());
members.Add("TwistAngleOffset", TwistAngleOffset.ToResoniteLinkField());
members.Add("chestForwardAxis", chestForwardAxis.ToResoniteLinkField());
members.Add("chestUpAxis", chestUpAxis.ToResoniteLinkField());
members.Add("forearmTwistAxis", forearmTwistAxis.ToResoniteLinkField());
members.Add("forearmAxis", forearmAxis.ToResoniteLinkField());
members.Add("axisRelativeToUpperArm", axisRelativeToUpperArm.ToResoniteLinkField());
members.Add("axisRelativeToHand", axisRelativeToHand.ToResoniteLinkField());
}

}
            }
}
