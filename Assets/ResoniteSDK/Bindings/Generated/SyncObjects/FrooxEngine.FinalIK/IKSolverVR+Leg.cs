
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.IKSolverVR+Leg
// Generated on: sobota 14. února 2026 8:58:43
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FinalIK.IKSolverVR+Leg")]
public partial class Leg : global::FrooxEngine.FinalIK.IKSolverVR.BodyPart

{
    public global::FrooxEngine.Slot Target;
public UnityEngine.Vector3 BendGoalPosition;
public global::FrooxEngine.Slot BendGoal;
public global::System.Single PositionWeight;
public global::System.Single RotationWeight;
public global::System.Single BendGoalWeight;
public global::System.Single SwivelOffset;
public UnityEngine.Vector3 CalfBendNormal;
public UnityEngine.Vector3 IKPosition;
public UnityEngine.Quaternion IKRotation;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("BendGoalPosition", BendGoalPosition.ToResoniteLinkField());
members.Add("BendGoal", BendGoal.ToResoniteReference(context));
members.Add("PositionWeight", PositionWeight.ToResoniteLinkField());
members.Add("RotationWeight", RotationWeight.ToResoniteLinkField());
members.Add("BendGoalWeight", BendGoalWeight.ToResoniteLinkField());
members.Add("SwivelOffset", SwivelOffset.ToResoniteLinkField());
members.Add("CalfBendNormal", CalfBendNormal.ToResoniteLinkField());
members.Add("IKPosition", IKPosition.ToResoniteLinkField());
members.Add("IKRotation", IKRotation.ToResoniteLinkField());
}

}
            }
}
