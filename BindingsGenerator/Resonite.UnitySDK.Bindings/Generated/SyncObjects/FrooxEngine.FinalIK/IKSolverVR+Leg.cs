
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.IKSolverVR+Leg
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FinalIK.IKSolverVR+Leg")]
public partial class Leg : global::FrooxEngine.FinalIK.IKSolverVR.BodyPart

{
    public global::FrooxEngine.Slot Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Target_Element = new();
public UnityEngine.Vector3 BendGoalPosition { get => BendGoalPosition_Element.Data; set => BendGoalPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> BendGoalPosition_Element = new();
public global::FrooxEngine.Slot BendGoal { get => BendGoal_Element.Data; set => BendGoal_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> BendGoal_Element = new();
public global::System.Single PositionWeight { get => PositionWeight_Element.Data; set => PositionWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PositionWeight_Element = new();
public global::System.Single RotationWeight { get => RotationWeight_Element.Data; set => RotationWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RotationWeight_Element = new();
public global::System.Single BendGoalWeight { get => BendGoalWeight_Element.Data; set => BendGoalWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BendGoalWeight_Element = new();
public global::System.Single SwivelOffset { get => SwivelOffset_Element.Data; set => SwivelOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SwivelOffset_Element = new();
public UnityEngine.Vector3 CalfBendNormal { get => CalfBendNormal_Element.Data; set => CalfBendNormal_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> CalfBendNormal_Element = new();
public UnityEngine.Vector3 IKPosition { get => IKPosition_Element.Data; set => IKPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> IKPosition_Element = new();
public UnityEngine.Quaternion IKRotation { get => IKRotation_Element.Data; set => IKRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> IKRotation_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("BendGoalPosition", BendGoalPosition_Element.ToLinkField(context));
members.Add("BendGoal", BendGoal_Element.ToLinkReference(context));
members.Add("PositionWeight", PositionWeight_Element.ToLinkField(context));
members.Add("RotationWeight", RotationWeight_Element.ToLinkField(context));
members.Add("BendGoalWeight", BendGoalWeight_Element.ToLinkField(context));
members.Add("SwivelOffset", SwivelOffset_Element.ToLinkField(context));
members.Add("CalfBendNormal", CalfBendNormal_Element.ToLinkField(context));
members.Add("IKPosition", IKPosition_Element.ToLinkField(context));
members.Add("IKRotation", IKRotation_Element.ToLinkField(context));
}

}
            }
}
