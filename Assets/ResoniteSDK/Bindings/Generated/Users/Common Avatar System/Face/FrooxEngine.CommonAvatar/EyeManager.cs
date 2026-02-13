
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.EyeManager
// Generated on: pátek 13. února 2026 23:23:13
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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
    public UnityEngine.Vector3 TargetPoint;
public UnityEngine.Vector3 LeftEyeTargetPoint;
public UnityEngine.Vector3 RightEyeTargetPoint;
public global::System.Single LeftEyeClose;
public global::System.Single RightEyeClose;
public global::System.Single CombinedEyeClose;
public global::System.Single LeftEyePupilSizeMillimeters;
public global::System.Single RightEyePupilSizeMillimeters;
public global::System.Single CombinedEyePupilSizeMillimeters;
public global::System.Single LeftEyeWiden;
public global::System.Single RightEyeWiden;
public global::System.Single CombinedEyeWiden;
public global::System.Single LeftEyeSqueeze;
public global::System.Single RightEyeSqueeze;
public global::System.Single CombinedEyeSqueeze;
public global::System.Single LeftEyeFrown;
public global::System.Single RightEyeFrown;
public global::System.Single CombinedEyeFrown;
public global::System.Single LeftEyeInnerBrowVertical;
public global::System.Single RightEyeInnerBrowVertical;
public global::System.Single CombinedEyeInnerBrowVertical;
public global::System.Single LeftEyeOuterBrowVertical;
public global::System.Single RightEyeOuterBrowVertical;
public global::System.Single CombinedEyeOuterBrowVertical;
public global::FrooxEngine.IEyeDataSourceComponent EyeDataSource;
public global::FrooxEngine.User SimulatingUser;
public global::System.Boolean SimulateOnHost;
public global::System.Boolean IgnoreLocalUserHead;
public global::System.Single UserHeadWeight;
public global::System.Single UserHandWeight;
public global::System.Single GrippingHandWeight;
public global::System.Single CameraWeight;
public global::System.Single ForcedCameraWeight;
public global::FrooxEngine.Slot EyeReference;
public global::System.Single EyeSeparation;
public global::System.Single SaccadeSpeed;
public global::FrooxEngine.Slot LookTargetRoot;
public UnityEngine.Vector3 LookTargetLocalPoint;
public UnityEngine.Vector3 LeftEyeTargetOffset;
public UnityEngine.Vector3 RightEyeTargetOffset;
public UnityEngine.Vector3 LookTargetOffset;
public global::System.Single MinRandomSaccadeInterval;
public global::System.Single MaxRandomSaccadeInterval;
public global::System.Single MinTargetSaccadeInterval;
public global::System.Single MaxTargetSaccadeInterval;
public global::System.Single MaxRandomSaccadeOffset;
public global::System.Single DefaultAcceptAngle;
public global::System.Single DefaultBreakAngle;
public global::System.Single HeadAcceptAngle;
public global::System.Single HeadBreakAngle;
public global::System.Single CameraAcceptAngle;
public global::System.Single CameraBreakAngle;
public global::System.Single HandAcceptAngle;
public global::System.Single HandBreakAngle;
public global::System.Single DistanceCompensationExp;
public global::System.Single LeftEyeCloseOverride;
public global::System.Single RightEyeCloseOverride;
public global::System.Single MinBlinkInterval;
public global::System.Single MaxBlinkInterval;
public global::System.Single BlinkMinSpeed;
public global::System.Single BlinkMaxSpeed;
public global::System.Single BlinkSpeedSpread;
public global::System.Single MinPupilSize;
public global::System.Single MaxPupilSize;
public global::System.Single PupilSizeNoiseSpeed;
public global::System.Single PupilSizeNoiseOffset;
public global::System.Single EyeTrackingPupilSizeSmoothSpeed;
public global::System.Single MiniExpressionProbability;
public global::System.Single MiniExpressionInterval;
public System.Collections.Generic.List<global::FrooxEngine.CommonAvatar.EyeManager.MiniExpression> MiniExpressions;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetPoint", TargetPoint.ToResoniteLinkField());
members.Add("LeftEyeTargetPoint", LeftEyeTargetPoint.ToResoniteLinkField());
members.Add("RightEyeTargetPoint", RightEyeTargetPoint.ToResoniteLinkField());
members.Add("LeftEyeClose", LeftEyeClose.ToResoniteLinkField());
members.Add("RightEyeClose", RightEyeClose.ToResoniteLinkField());
members.Add("CombinedEyeClose", CombinedEyeClose.ToResoniteLinkField());
members.Add("LeftEyePupilSizeMillimeters", LeftEyePupilSizeMillimeters.ToResoniteLinkField());
members.Add("RightEyePupilSizeMillimeters", RightEyePupilSizeMillimeters.ToResoniteLinkField());
members.Add("CombinedEyePupilSizeMillimeters", CombinedEyePupilSizeMillimeters.ToResoniteLinkField());
members.Add("LeftEyeWiden", LeftEyeWiden.ToResoniteLinkField());
members.Add("RightEyeWiden", RightEyeWiden.ToResoniteLinkField());
members.Add("CombinedEyeWiden", CombinedEyeWiden.ToResoniteLinkField());
members.Add("LeftEyeSqueeze", LeftEyeSqueeze.ToResoniteLinkField());
members.Add("RightEyeSqueeze", RightEyeSqueeze.ToResoniteLinkField());
members.Add("CombinedEyeSqueeze", CombinedEyeSqueeze.ToResoniteLinkField());
members.Add("LeftEyeFrown", LeftEyeFrown.ToResoniteLinkField());
members.Add("RightEyeFrown", RightEyeFrown.ToResoniteLinkField());
members.Add("CombinedEyeFrown", CombinedEyeFrown.ToResoniteLinkField());
members.Add("LeftEyeInnerBrowVertical", LeftEyeInnerBrowVertical.ToResoniteLinkField());
members.Add("RightEyeInnerBrowVertical", RightEyeInnerBrowVertical.ToResoniteLinkField());
members.Add("CombinedEyeInnerBrowVertical", CombinedEyeInnerBrowVertical.ToResoniteLinkField());
members.Add("LeftEyeOuterBrowVertical", LeftEyeOuterBrowVertical.ToResoniteLinkField());
members.Add("RightEyeOuterBrowVertical", RightEyeOuterBrowVertical.ToResoniteLinkField());
members.Add("CombinedEyeOuterBrowVertical", CombinedEyeOuterBrowVertical.ToResoniteLinkField());
members.Add("EyeDataSource", new ResoniteLink.Reference() { });
members.Add("SimulatingUser", new ResoniteLink.Reference() { });
members.Add("SimulateOnHost", SimulateOnHost.ToResoniteLinkField());
members.Add("IgnoreLocalUserHead", IgnoreLocalUserHead.ToResoniteLinkField());
members.Add("UserHeadWeight", UserHeadWeight.ToResoniteLinkField());
members.Add("UserHandWeight", UserHandWeight.ToResoniteLinkField());
members.Add("GrippingHandWeight", GrippingHandWeight.ToResoniteLinkField());
members.Add("CameraWeight", CameraWeight.ToResoniteLinkField());
members.Add("ForcedCameraWeight", ForcedCameraWeight.ToResoniteLinkField());
members.Add("EyeReference", new ResoniteLink.Reference() { });
members.Add("EyeSeparation", EyeSeparation.ToResoniteLinkField());
members.Add("SaccadeSpeed", SaccadeSpeed.ToResoniteLinkField());
members.Add("LookTargetRoot", new ResoniteLink.Reference() { });
members.Add("LookTargetLocalPoint", LookTargetLocalPoint.ToResoniteLinkField());
members.Add("LeftEyeTargetOffset", LeftEyeTargetOffset.ToResoniteLinkField());
members.Add("RightEyeTargetOffset", RightEyeTargetOffset.ToResoniteLinkField());
members.Add("LookTargetOffset", LookTargetOffset.ToResoniteLinkField());
members.Add("MinRandomSaccadeInterval", MinRandomSaccadeInterval.ToResoniteLinkField());
members.Add("MaxRandomSaccadeInterval", MaxRandomSaccadeInterval.ToResoniteLinkField());
members.Add("MinTargetSaccadeInterval", MinTargetSaccadeInterval.ToResoniteLinkField());
members.Add("MaxTargetSaccadeInterval", MaxTargetSaccadeInterval.ToResoniteLinkField());
members.Add("MaxRandomSaccadeOffset", MaxRandomSaccadeOffset.ToResoniteLinkField());
members.Add("DefaultAcceptAngle", DefaultAcceptAngle.ToResoniteLinkField());
members.Add("DefaultBreakAngle", DefaultBreakAngle.ToResoniteLinkField());
members.Add("HeadAcceptAngle", HeadAcceptAngle.ToResoniteLinkField());
members.Add("HeadBreakAngle", HeadBreakAngle.ToResoniteLinkField());
members.Add("CameraAcceptAngle", CameraAcceptAngle.ToResoniteLinkField());
members.Add("CameraBreakAngle", CameraBreakAngle.ToResoniteLinkField());
members.Add("HandAcceptAngle", HandAcceptAngle.ToResoniteLinkField());
members.Add("HandBreakAngle", HandBreakAngle.ToResoniteLinkField());
members.Add("DistanceCompensationExp", DistanceCompensationExp.ToResoniteLinkField());
members.Add("LeftEyeCloseOverride", LeftEyeCloseOverride.ToResoniteLinkField());
members.Add("RightEyeCloseOverride", RightEyeCloseOverride.ToResoniteLinkField());
members.Add("MinBlinkInterval", MinBlinkInterval.ToResoniteLinkField());
members.Add("MaxBlinkInterval", MaxBlinkInterval.ToResoniteLinkField());
members.Add("BlinkMinSpeed", BlinkMinSpeed.ToResoniteLinkField());
members.Add("BlinkMaxSpeed", BlinkMaxSpeed.ToResoniteLinkField());
members.Add("BlinkSpeedSpread", BlinkSpeedSpread.ToResoniteLinkField());
members.Add("MinPupilSize", MinPupilSize.ToResoniteLinkField());
members.Add("MaxPupilSize", MaxPupilSize.ToResoniteLinkField());
members.Add("PupilSizeNoiseSpeed", PupilSizeNoiseSpeed.ToResoniteLinkField());
members.Add("PupilSizeNoiseOffset", PupilSizeNoiseOffset.ToResoniteLinkField());
members.Add("EyeTrackingPupilSizeSmoothSpeed", EyeTrackingPupilSizeSmoothSpeed.ToResoniteLinkField());
members.Add("MiniExpressionProbability", MiniExpressionProbability.ToResoniteLinkField());
members.Add("MiniExpressionInterval", MiniExpressionInterval.ToResoniteLinkField());
members.Add("MiniExpressions", new ResoniteLink.SyncList()
{
    Elements = MiniExpressions.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
}

}
}
