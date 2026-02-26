
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.EyeManager
// Generated on: čtvrtek 26. února 2026 15:09:11
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.EyeManager")]
public partial class EyeManager : global::FrooxEngine.UserRootComponent

{
    public UnityEngine.Vector3 TargetPoint { get => TargetPoint_Element.Data; set => TargetPoint_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.Vector3>, UnityEngine.Vector3> TargetPoint_Element = new();
public UnityEngine.Vector3 LeftEyeTargetPoint { get => LeftEyeTargetPoint_Element.Data; set => LeftEyeTargetPoint_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.Vector3>, UnityEngine.Vector3> LeftEyeTargetPoint_Element = new();
public UnityEngine.Vector3 RightEyeTargetPoint { get => RightEyeTargetPoint_Element.Data; set => RightEyeTargetPoint_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.Vector3>, UnityEngine.Vector3> RightEyeTargetPoint_Element = new();
public global::System.Single LeftEyeClose { get => LeftEyeClose_Element.Data; set => LeftEyeClose_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LeftEyeClose_Element = new();
public global::System.Single RightEyeClose { get => RightEyeClose_Element.Data; set => RightEyeClose_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> RightEyeClose_Element = new();
public global::System.Single CombinedEyeClose { get => CombinedEyeClose_Element.Data; set => CombinedEyeClose_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> CombinedEyeClose_Element = new();
public global::System.Single LeftEyePupilSizeMillimeters { get => LeftEyePupilSizeMillimeters_Element.Data; set => LeftEyePupilSizeMillimeters_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LeftEyePupilSizeMillimeters_Element = new();
public global::System.Single RightEyePupilSizeMillimeters { get => RightEyePupilSizeMillimeters_Element.Data; set => RightEyePupilSizeMillimeters_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> RightEyePupilSizeMillimeters_Element = new();
public global::System.Single CombinedEyePupilSizeMillimeters { get => CombinedEyePupilSizeMillimeters_Element.Data; set => CombinedEyePupilSizeMillimeters_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> CombinedEyePupilSizeMillimeters_Element = new();
public global::System.Single LeftEyeWiden { get => LeftEyeWiden_Element.Data; set => LeftEyeWiden_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LeftEyeWiden_Element = new();
public global::System.Single RightEyeWiden { get => RightEyeWiden_Element.Data; set => RightEyeWiden_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> RightEyeWiden_Element = new();
public global::System.Single CombinedEyeWiden { get => CombinedEyeWiden_Element.Data; set => CombinedEyeWiden_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> CombinedEyeWiden_Element = new();
public global::System.Single LeftEyeSqueeze { get => LeftEyeSqueeze_Element.Data; set => LeftEyeSqueeze_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LeftEyeSqueeze_Element = new();
public global::System.Single RightEyeSqueeze { get => RightEyeSqueeze_Element.Data; set => RightEyeSqueeze_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> RightEyeSqueeze_Element = new();
public global::System.Single CombinedEyeSqueeze { get => CombinedEyeSqueeze_Element.Data; set => CombinedEyeSqueeze_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> CombinedEyeSqueeze_Element = new();
public global::System.Single LeftEyeFrown { get => LeftEyeFrown_Element.Data; set => LeftEyeFrown_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LeftEyeFrown_Element = new();
public global::System.Single RightEyeFrown { get => RightEyeFrown_Element.Data; set => RightEyeFrown_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> RightEyeFrown_Element = new();
public global::System.Single CombinedEyeFrown { get => CombinedEyeFrown_Element.Data; set => CombinedEyeFrown_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> CombinedEyeFrown_Element = new();
public global::System.Single LeftEyeInnerBrowVertical { get => LeftEyeInnerBrowVertical_Element.Data; set => LeftEyeInnerBrowVertical_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LeftEyeInnerBrowVertical_Element = new();
public global::System.Single RightEyeInnerBrowVertical { get => RightEyeInnerBrowVertical_Element.Data; set => RightEyeInnerBrowVertical_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> RightEyeInnerBrowVertical_Element = new();
public global::System.Single CombinedEyeInnerBrowVertical { get => CombinedEyeInnerBrowVertical_Element.Data; set => CombinedEyeInnerBrowVertical_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> CombinedEyeInnerBrowVertical_Element = new();
public global::System.Single LeftEyeOuterBrowVertical { get => LeftEyeOuterBrowVertical_Element.Data; set => LeftEyeOuterBrowVertical_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LeftEyeOuterBrowVertical_Element = new();
public global::System.Single RightEyeOuterBrowVertical { get => RightEyeOuterBrowVertical_Element.Data; set => RightEyeOuterBrowVertical_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> RightEyeOuterBrowVertical_Element = new();
public global::System.Single CombinedEyeOuterBrowVertical { get => CombinedEyeOuterBrowVertical_Element.Data; set => CombinedEyeOuterBrowVertical_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> CombinedEyeOuterBrowVertical_Element = new();
public global::FrooxEngine.IEyeDataSourceComponent EyeDataSource { get => EyeDataSource_Element.Data; set => EyeDataSource_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IEyeDataSourceComponent>, global::FrooxEngine.IEyeDataSourceComponent> EyeDataSource_Element = new();
public global::FrooxEngine.User SimulatingUser { get => SimulatingUser_Element.Data; set => SimulatingUser_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> SimulatingUser_Element = new();
public global::System.Boolean SimulateOnHost { get => SimulateOnHost_Element.Data; set => SimulateOnHost_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SimulateOnHost_Element = new();
public global::System.Boolean IgnoreLocalUserHead { get => IgnoreLocalUserHead_Element.Data; set => IgnoreLocalUserHead_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IgnoreLocalUserHead_Element = new();
public global::System.Single UserHeadWeight { get => UserHeadWeight_Element.Data; set => UserHeadWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> UserHeadWeight_Element = new();
public global::System.Single UserHandWeight { get => UserHandWeight_Element.Data; set => UserHandWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> UserHandWeight_Element = new();
public global::System.Single GrippingHandWeight { get => GrippingHandWeight_Element.Data; set => GrippingHandWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GrippingHandWeight_Element = new();
public global::System.Single CameraWeight { get => CameraWeight_Element.Data; set => CameraWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CameraWeight_Element = new();
public global::System.Single ForcedCameraWeight { get => ForcedCameraWeight_Element.Data; set => ForcedCameraWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ForcedCameraWeight_Element = new();
public global::FrooxEngine.Slot EyeReference { get => EyeReference_Element.Data; set => EyeReference_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> EyeReference_Element = new();
public global::System.Single EyeSeparation { get => EyeSeparation_Element.Data; set => EyeSeparation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EyeSeparation_Element = new();
public global::System.Single SaccadeSpeed { get => SaccadeSpeed_Element.Data; set => SaccadeSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SaccadeSpeed_Element = new();
public global::FrooxEngine.Slot LookTargetRoot { get => LookTargetRoot_Element.Data; set => LookTargetRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> LookTargetRoot_Element = new();
public UnityEngine.Vector3 LookTargetLocalPoint { get => LookTargetLocalPoint_Element.Data; set => LookTargetLocalPoint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> LookTargetLocalPoint_Element = new();
public UnityEngine.Vector3 LeftEyeTargetOffset { get => LeftEyeTargetOffset_Element.Data; set => LeftEyeTargetOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> LeftEyeTargetOffset_Element = new();
public UnityEngine.Vector3 RightEyeTargetOffset { get => RightEyeTargetOffset_Element.Data; set => RightEyeTargetOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> RightEyeTargetOffset_Element = new();
public UnityEngine.Vector3 LookTargetOffset { get => LookTargetOffset_Element.Data; set => LookTargetOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> LookTargetOffset_Element = new();
public global::System.Single MinRandomSaccadeInterval { get => MinRandomSaccadeInterval_Element.Data; set => MinRandomSaccadeInterval_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinRandomSaccadeInterval_Element = new();
public global::System.Single MaxRandomSaccadeInterval { get => MaxRandomSaccadeInterval_Element.Data; set => MaxRandomSaccadeInterval_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxRandomSaccadeInterval_Element = new();
public global::System.Single MinTargetSaccadeInterval { get => MinTargetSaccadeInterval_Element.Data; set => MinTargetSaccadeInterval_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinTargetSaccadeInterval_Element = new();
public global::System.Single MaxTargetSaccadeInterval { get => MaxTargetSaccadeInterval_Element.Data; set => MaxTargetSaccadeInterval_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxTargetSaccadeInterval_Element = new();
public global::System.Single MaxRandomSaccadeOffset { get => MaxRandomSaccadeOffset_Element.Data; set => MaxRandomSaccadeOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxRandomSaccadeOffset_Element = new();
public global::System.Single DefaultAcceptAngle { get => DefaultAcceptAngle_Element.Data; set => DefaultAcceptAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DefaultAcceptAngle_Element = new();
public global::System.Single DefaultBreakAngle { get => DefaultBreakAngle_Element.Data; set => DefaultBreakAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DefaultBreakAngle_Element = new();
public global::System.Single HeadAcceptAngle { get => HeadAcceptAngle_Element.Data; set => HeadAcceptAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadAcceptAngle_Element = new();
public global::System.Single HeadBreakAngle { get => HeadBreakAngle_Element.Data; set => HeadBreakAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadBreakAngle_Element = new();
public global::System.Single CameraAcceptAngle { get => CameraAcceptAngle_Element.Data; set => CameraAcceptAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CameraAcceptAngle_Element = new();
public global::System.Single CameraBreakAngle { get => CameraBreakAngle_Element.Data; set => CameraBreakAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CameraBreakAngle_Element = new();
public global::System.Single HandAcceptAngle { get => HandAcceptAngle_Element.Data; set => HandAcceptAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HandAcceptAngle_Element = new();
public global::System.Single HandBreakAngle { get => HandBreakAngle_Element.Data; set => HandBreakAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HandBreakAngle_Element = new();
public global::System.Single DistanceCompensationExp { get => DistanceCompensationExp_Element.Data; set => DistanceCompensationExp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DistanceCompensationExp_Element = new();
public global::System.Single LeftEyeCloseOverride { get => LeftEyeCloseOverride_Element.Data; set => LeftEyeCloseOverride_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LeftEyeCloseOverride_Element = new();
public global::System.Single RightEyeCloseOverride { get => RightEyeCloseOverride_Element.Data; set => RightEyeCloseOverride_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RightEyeCloseOverride_Element = new();
public global::System.Single MinBlinkInterval { get => MinBlinkInterval_Element.Data; set => MinBlinkInterval_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinBlinkInterval_Element = new();
public global::System.Single MaxBlinkInterval { get => MaxBlinkInterval_Element.Data; set => MaxBlinkInterval_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxBlinkInterval_Element = new();
public global::System.Single BlinkMinSpeed { get => BlinkMinSpeed_Element.Data; set => BlinkMinSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BlinkMinSpeed_Element = new();
public global::System.Single BlinkMaxSpeed { get => BlinkMaxSpeed_Element.Data; set => BlinkMaxSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BlinkMaxSpeed_Element = new();
public global::System.Single BlinkSpeedSpread { get => BlinkSpeedSpread_Element.Data; set => BlinkSpeedSpread_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BlinkSpeedSpread_Element = new();
public global::System.Single MinPupilSize { get => MinPupilSize_Element.Data; set => MinPupilSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinPupilSize_Element = new();
public global::System.Single MaxPupilSize { get => MaxPupilSize_Element.Data; set => MaxPupilSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxPupilSize_Element = new();
public global::System.Single PupilSizeNoiseSpeed { get => PupilSizeNoiseSpeed_Element.Data; set => PupilSizeNoiseSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PupilSizeNoiseSpeed_Element = new();
public global::System.Single PupilSizeNoiseOffset { get => PupilSizeNoiseOffset_Element.Data; set => PupilSizeNoiseOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PupilSizeNoiseOffset_Element = new();
public global::System.Single EyeTrackingPupilSizeSmoothSpeed { get => EyeTrackingPupilSizeSmoothSpeed_Element.Data; set => EyeTrackingPupilSizeSmoothSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EyeTrackingPupilSizeSmoothSpeed_Element = new();
public global::System.Single MiniExpressionProbability { get => MiniExpressionProbability_Element.Data; set => MiniExpressionProbability_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MiniExpressionProbability_Element = new();
public global::System.Single MiniExpressionInterval { get => MiniExpressionInterval_Element.Data; set => MiniExpressionInterval_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MiniExpressionInterval_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.CommonAvatar.EyeManager.MiniExpression>, global::FrooxEngine.CommonAvatar.EyeManager.MiniExpression> MiniExpressions = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetPoint", TargetPoint_Element.ToLinkField(context));
members.Add("LeftEyeTargetPoint", LeftEyeTargetPoint_Element.ToLinkField(context));
members.Add("RightEyeTargetPoint", RightEyeTargetPoint_Element.ToLinkField(context));
members.Add("LeftEyeClose", LeftEyeClose_Element.ToLinkField(context));
members.Add("RightEyeClose", RightEyeClose_Element.ToLinkField(context));
members.Add("CombinedEyeClose", CombinedEyeClose_Element.ToLinkField(context));
members.Add("LeftEyePupilSizeMillimeters", LeftEyePupilSizeMillimeters_Element.ToLinkField(context));
members.Add("RightEyePupilSizeMillimeters", RightEyePupilSizeMillimeters_Element.ToLinkField(context));
members.Add("CombinedEyePupilSizeMillimeters", CombinedEyePupilSizeMillimeters_Element.ToLinkField(context));
members.Add("LeftEyeWiden", LeftEyeWiden_Element.ToLinkField(context));
members.Add("RightEyeWiden", RightEyeWiden_Element.ToLinkField(context));
members.Add("CombinedEyeWiden", CombinedEyeWiden_Element.ToLinkField(context));
members.Add("LeftEyeSqueeze", LeftEyeSqueeze_Element.ToLinkField(context));
members.Add("RightEyeSqueeze", RightEyeSqueeze_Element.ToLinkField(context));
members.Add("CombinedEyeSqueeze", CombinedEyeSqueeze_Element.ToLinkField(context));
members.Add("LeftEyeFrown", LeftEyeFrown_Element.ToLinkField(context));
members.Add("RightEyeFrown", RightEyeFrown_Element.ToLinkField(context));
members.Add("CombinedEyeFrown", CombinedEyeFrown_Element.ToLinkField(context));
members.Add("LeftEyeInnerBrowVertical", LeftEyeInnerBrowVertical_Element.ToLinkField(context));
members.Add("RightEyeInnerBrowVertical", RightEyeInnerBrowVertical_Element.ToLinkField(context));
members.Add("CombinedEyeInnerBrowVertical", CombinedEyeInnerBrowVertical_Element.ToLinkField(context));
members.Add("LeftEyeOuterBrowVertical", LeftEyeOuterBrowVertical_Element.ToLinkField(context));
members.Add("RightEyeOuterBrowVertical", RightEyeOuterBrowVertical_Element.ToLinkField(context));
members.Add("CombinedEyeOuterBrowVertical", CombinedEyeOuterBrowVertical_Element.ToLinkField(context));
members.Add("EyeDataSource", EyeDataSource_Element.ToLinkReference(context));
members.Add("SimulatingUser", SimulatingUser_Element.ToLinkReference(context));
members.Add("SimulateOnHost", SimulateOnHost_Element.ToLinkField(context));
members.Add("IgnoreLocalUserHead", IgnoreLocalUserHead_Element.ToLinkField(context));
members.Add("UserHeadWeight", UserHeadWeight_Element.ToLinkField(context));
members.Add("UserHandWeight", UserHandWeight_Element.ToLinkField(context));
members.Add("GrippingHandWeight", GrippingHandWeight_Element.ToLinkField(context));
members.Add("CameraWeight", CameraWeight_Element.ToLinkField(context));
members.Add("ForcedCameraWeight", ForcedCameraWeight_Element.ToLinkField(context));
members.Add("EyeReference", EyeReference_Element.ToLinkReference(context));
members.Add("EyeSeparation", EyeSeparation_Element.ToLinkField(context));
members.Add("SaccadeSpeed", SaccadeSpeed_Element.ToLinkField(context));
members.Add("LookTargetRoot", LookTargetRoot_Element.ToLinkReference(context));
members.Add("LookTargetLocalPoint", LookTargetLocalPoint_Element.ToLinkField(context));
members.Add("LeftEyeTargetOffset", LeftEyeTargetOffset_Element.ToLinkField(context));
members.Add("RightEyeTargetOffset", RightEyeTargetOffset_Element.ToLinkField(context));
members.Add("LookTargetOffset", LookTargetOffset_Element.ToLinkField(context));
members.Add("MinRandomSaccadeInterval", MinRandomSaccadeInterval_Element.ToLinkField(context));
members.Add("MaxRandomSaccadeInterval", MaxRandomSaccadeInterval_Element.ToLinkField(context));
members.Add("MinTargetSaccadeInterval", MinTargetSaccadeInterval_Element.ToLinkField(context));
members.Add("MaxTargetSaccadeInterval", MaxTargetSaccadeInterval_Element.ToLinkField(context));
members.Add("MaxRandomSaccadeOffset", MaxRandomSaccadeOffset_Element.ToLinkField(context));
members.Add("DefaultAcceptAngle", DefaultAcceptAngle_Element.ToLinkField(context));
members.Add("DefaultBreakAngle", DefaultBreakAngle_Element.ToLinkField(context));
members.Add("HeadAcceptAngle", HeadAcceptAngle_Element.ToLinkField(context));
members.Add("HeadBreakAngle", HeadBreakAngle_Element.ToLinkField(context));
members.Add("CameraAcceptAngle", CameraAcceptAngle_Element.ToLinkField(context));
members.Add("CameraBreakAngle", CameraBreakAngle_Element.ToLinkField(context));
members.Add("HandAcceptAngle", HandAcceptAngle_Element.ToLinkField(context));
members.Add("HandBreakAngle", HandBreakAngle_Element.ToLinkField(context));
members.Add("DistanceCompensationExp", DistanceCompensationExp_Element.ToLinkField(context));
members.Add("LeftEyeCloseOverride", LeftEyeCloseOverride_Element.ToLinkField(context));
members.Add("RightEyeCloseOverride", RightEyeCloseOverride_Element.ToLinkField(context));
members.Add("MinBlinkInterval", MinBlinkInterval_Element.ToLinkField(context));
members.Add("MaxBlinkInterval", MaxBlinkInterval_Element.ToLinkField(context));
members.Add("BlinkMinSpeed", BlinkMinSpeed_Element.ToLinkField(context));
members.Add("BlinkMaxSpeed", BlinkMaxSpeed_Element.ToLinkField(context));
members.Add("BlinkSpeedSpread", BlinkSpeedSpread_Element.ToLinkField(context));
members.Add("MinPupilSize", MinPupilSize_Element.ToLinkField(context));
members.Add("MaxPupilSize", MaxPupilSize_Element.ToLinkField(context));
members.Add("PupilSizeNoiseSpeed", PupilSizeNoiseSpeed_Element.ToLinkField(context));
members.Add("PupilSizeNoiseOffset", PupilSizeNoiseOffset_Element.ToLinkField(context));
members.Add("EyeTrackingPupilSizeSmoothSpeed", EyeTrackingPupilSizeSmoothSpeed_Element.ToLinkField(context));
members.Add("MiniExpressionProbability", MiniExpressionProbability_Element.ToLinkField(context));
members.Add("MiniExpressionInterval", MiniExpressionInterval_Element.ToLinkField(context));
members.Add("MiniExpressions", MiniExpressions.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
