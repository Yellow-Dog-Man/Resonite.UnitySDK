
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocomotionAnimationGaitParameters
// Generated on: čtvrtek 26. února 2026 15:09:11
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocomotionAnimationGaitParameters")]
public partial class LocomotionAnimationGaitParameters : global::FrooxEngine.SyncObject

{
    public global::System.Single ReferenceSpeed { get => ReferenceSpeed_Element.Data; set => ReferenceSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ReferenceSpeed_Element = new();
public global::System.Single MinOpposingProgress { get => MinOpposingProgress_Element.Data; set => MinOpposingProgress_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinOpposingProgress_Element = new();
public global::System.Single VelocityIncreaseSmoothTime { get => VelocityIncreaseSmoothTime_Element.Data; set => VelocityIncreaseSmoothTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VelocityIncreaseSmoothTime_Element = new();
public global::System.Single VelocityDecreaseSmoothTime { get => VelocityDecreaseSmoothTime_Element.Data; set => VelocityDecreaseSmoothTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VelocityDecreaseSmoothTime_Element = new();
public global::System.Single FootTravelDistance { get => FootTravelDistance_Element.Data; set => FootTravelDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootTravelDistance_Element = new();
public global::System.Single FootSidewaysDistanceRatio { get => FootSidewaysDistanceRatio_Element.Data; set => FootSidewaysDistanceRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootSidewaysDistanceRatio_Element = new();
public global::System.Single FootBackwardsDistanceRatio { get => FootBackwardsDistanceRatio_Element.Data; set => FootBackwardsDistanceRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootBackwardsDistanceRatio_Element = new();
public global::System.Single FootMaxAngle { get => FootMaxAngle_Element.Data; set => FootMaxAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootMaxAngle_Element = new();
public global::System.Single FootTurnInfluence { get => FootTurnInfluence_Element.Data; set => FootTurnInfluence_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootTurnInfluence_Element = new();
public UnityEngine.Vector3 Offset { get => Offset_Element.Data; set => Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Offset_Element = new();
public global::System.Single FootStepUpHeight { get => FootStepUpHeight_Element.Data; set => FootStepUpHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootStepUpHeight_Element = new();
public global::System.Single FootStepDownHeight { get => FootStepDownHeight_Element.Data; set => FootStepDownHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootStepDownHeight_Element = new();
public global::System.Single FootStepUpPow { get => FootStepUpPow_Element.Data; set => FootStepUpPow_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootStepUpPow_Element = new();
public global::System.Single FootStepDownPow { get => FootStepDownPow_Element.Data; set => FootStepDownPow_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootStepDownPow_Element = new();
public global::System.Single FootStepUpVelocityMultiplier { get => FootStepUpVelocityMultiplier_Element.Data; set => FootStepUpVelocityMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootStepUpVelocityMultiplier_Element = new();
public global::System.Single FootStepUpVelocityVerticalRatio { get => FootStepUpVelocityVerticalRatio_Element.Data; set => FootStepUpVelocityVerticalRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootStepUpVelocityVerticalRatio_Element = new();
public global::System.Single FootGroundAngle { get => FootGroundAngle_Element.Data; set => FootGroundAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootGroundAngle_Element = new();
public global::System.Single FootGroundPow { get => FootGroundPow_Element.Data; set => FootGroundPow_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootGroundPow_Element = new();
public global::System.Single FootStepUpAngularVelocityMultiplier { get => FootStepUpAngularVelocityMultiplier_Element.Data; set => FootStepUpAngularVelocityMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootStepUpAngularVelocityMultiplier_Element = new();
public global::System.Single FootStepDownAngle { get => FootStepDownAngle_Element.Data; set => FootStepDownAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootStepDownAngle_Element = new();
public global::System.Single HandForwardForce { get => HandForwardForce_Element.Data; set => HandForwardForce_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HandForwardForce_Element = new();
public global::System.Single HandBackwardForce { get => HandBackwardForce_Element.Data; set => HandBackwardForce_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HandBackwardForce_Element = new();
public global::System.Single HandDrag { get => HandDrag_Element.Data; set => HandDrag_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HandDrag_Element = new();
public global::System.Single HandSwingDistance { get => HandSwingDistance_Element.Data; set => HandSwingDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HandSwingDistance_Element = new();
public UnityEngine.Vector3 HandOffset { get => HandOffset_Element.Data; set => HandOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> HandOffset_Element = new();
public UnityEngine.Vector3 HandDirectionCenterOffset { get => HandDirectionCenterOffset_Element.Data; set => HandDirectionCenterOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> HandDirectionCenterOffset_Element = new();
public UnityEngine.Vector3 HandSwingDirection { get => HandSwingDirection_Element.Data; set => HandSwingDirection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> HandSwingDirection_Element = new();
public UnityEngine.Vector3 HandSwingArcPeak { get => HandSwingArcPeak_Element.Data; set => HandSwingArcPeak_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> HandSwingArcPeak_Element = new();
public global::FrooxEngine.IFingerPoseSourceComponent FingerBasePose { get => FingerBasePose_Element.Data; set => FingerBasePose_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IFingerPoseSourceComponent>, global::FrooxEngine.IFingerPoseSourceComponent> FingerBasePose_Element = new();
public global::System.Single FingerCurlOffset { get => FingerCurlOffset_Element.Data; set => FingerCurlOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FingerCurlOffset_Element = new();
public global::System.Single FingerCurlSwayMagnitude { get => FingerCurlSwayMagnitude_Element.Data; set => FingerCurlSwayMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FingerCurlSwayMagnitude_Element = new();
public global::System.Single FingerCurlSwaySpeed { get => FingerCurlSwaySpeed_Element.Data; set => FingerCurlSwaySpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FingerCurlSwaySpeed_Element = new();
public global::System.Single FingerCurlVariationMagnitude { get => FingerCurlVariationMagnitude_Element.Data; set => FingerCurlVariationMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FingerCurlVariationMagnitude_Element = new();
public global::System.Single FingerCurlVariationSpeed { get => FingerCurlVariationSpeed_Element.Data; set => FingerCurlVariationSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FingerCurlVariationSpeed_Element = new();
public global::System.Single HeadSmoothingSpeed { get => HeadSmoothingSpeed_Element.Data; set => HeadSmoothingSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadSmoothingSpeed_Element = new();
public global::System.Single HeadHorizontalBobOffset { get => HeadHorizontalBobOffset_Element.Data; set => HeadHorizontalBobOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadHorizontalBobOffset_Element = new();
public global::System.Single HeadHorizontalBobAngle { get => HeadHorizontalBobAngle_Element.Data; set => HeadHorizontalBobAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadHorizontalBobAngle_Element = new();
public global::System.Single HeadVerticalBobOffset { get => HeadVerticalBobOffset_Element.Data; set => HeadVerticalBobOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadVerticalBobOffset_Element = new();
public global::System.Single HeadVerticalBobAngle { get => HeadVerticalBobAngle_Element.Data; set => HeadVerticalBobAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadVerticalBobAngle_Element = new();
public global::System.Single VerticalHeadAngleOffset { get => VerticalHeadAngleOffset_Element.Data; set => VerticalHeadAngleOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VerticalHeadAngleOffset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ReferenceSpeed", ReferenceSpeed_Element.ToLinkField(context));
members.Add("MinOpposingProgress", MinOpposingProgress_Element.ToLinkField(context));
members.Add("VelocityIncreaseSmoothTime", VelocityIncreaseSmoothTime_Element.ToLinkField(context));
members.Add("VelocityDecreaseSmoothTime", VelocityDecreaseSmoothTime_Element.ToLinkField(context));
members.Add("FootTravelDistance", FootTravelDistance_Element.ToLinkField(context));
members.Add("FootSidewaysDistanceRatio", FootSidewaysDistanceRatio_Element.ToLinkField(context));
members.Add("FootBackwardsDistanceRatio", FootBackwardsDistanceRatio_Element.ToLinkField(context));
members.Add("FootMaxAngle", FootMaxAngle_Element.ToLinkField(context));
members.Add("FootTurnInfluence", FootTurnInfluence_Element.ToLinkField(context));
members.Add("Offset", Offset_Element.ToLinkField(context));
members.Add("FootStepUpHeight", FootStepUpHeight_Element.ToLinkField(context));
members.Add("FootStepDownHeight", FootStepDownHeight_Element.ToLinkField(context));
members.Add("FootStepUpPow", FootStepUpPow_Element.ToLinkField(context));
members.Add("FootStepDownPow", FootStepDownPow_Element.ToLinkField(context));
members.Add("FootStepUpVelocityMultiplier", FootStepUpVelocityMultiplier_Element.ToLinkField(context));
members.Add("FootStepUpVelocityVerticalRatio", FootStepUpVelocityVerticalRatio_Element.ToLinkField(context));
members.Add("FootGroundAngle", FootGroundAngle_Element.ToLinkField(context));
members.Add("FootGroundPow", FootGroundPow_Element.ToLinkField(context));
members.Add("FootStepUpAngularVelocityMultiplier", FootStepUpAngularVelocityMultiplier_Element.ToLinkField(context));
members.Add("FootStepDownAngle", FootStepDownAngle_Element.ToLinkField(context));
members.Add("HandForwardForce", HandForwardForce_Element.ToLinkField(context));
members.Add("HandBackwardForce", HandBackwardForce_Element.ToLinkField(context));
members.Add("HandDrag", HandDrag_Element.ToLinkField(context));
members.Add("HandSwingDistance", HandSwingDistance_Element.ToLinkField(context));
members.Add("HandOffset", HandOffset_Element.ToLinkField(context));
members.Add("HandDirectionCenterOffset", HandDirectionCenterOffset_Element.ToLinkField(context));
members.Add("HandSwingDirection", HandSwingDirection_Element.ToLinkField(context));
members.Add("HandSwingArcPeak", HandSwingArcPeak_Element.ToLinkField(context));
members.Add("FingerBasePose", FingerBasePose_Element.ToLinkReference(context));
members.Add("FingerCurlOffset", FingerCurlOffset_Element.ToLinkField(context));
members.Add("FingerCurlSwayMagnitude", FingerCurlSwayMagnitude_Element.ToLinkField(context));
members.Add("FingerCurlSwaySpeed", FingerCurlSwaySpeed_Element.ToLinkField(context));
members.Add("FingerCurlVariationMagnitude", FingerCurlVariationMagnitude_Element.ToLinkField(context));
members.Add("FingerCurlVariationSpeed", FingerCurlVariationSpeed_Element.ToLinkField(context));
members.Add("HeadSmoothingSpeed", HeadSmoothingSpeed_Element.ToLinkField(context));
members.Add("HeadHorizontalBobOffset", HeadHorizontalBobOffset_Element.ToLinkField(context));
members.Add("HeadHorizontalBobAngle", HeadHorizontalBobAngle_Element.ToLinkField(context));
members.Add("HeadVerticalBobOffset", HeadVerticalBobOffset_Element.ToLinkField(context));
members.Add("HeadVerticalBobAngle", HeadVerticalBobAngle_Element.ToLinkField(context));
members.Add("VerticalHeadAngleOffset", VerticalHeadAngleOffset_Element.ToLinkField(context));
}

}
}
