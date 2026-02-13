
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DroneCamera
// Generated on: pátek 13. února 2026 5:52:39
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DroneCamera")]
public partial class DroneCamera : global::FrooxEngine.Component

{
    public global::FrooxEngine.UserRef CameraUser;
public global::System.Boolean SimulateOnHost;
public global::System.Boolean ManualControl;
public global::System.Single SlowSpeed;
public global::System.Single Speed;
public global::System.Single FastSpeed;
public global::System.Single MouseSensitivity;
public global::FrooxEngine.IField<global::System.Single> FieldOfViewSource;
public global::System.Single FieldOfView;
public global::FrooxEngine.IField<global::System.Single> AspectRatioSource;
public global::System.Single AspectRatio;
public global::FrooxEngine.User FollowUser;
public global::System.Single ControllerRejectDistance;
public global::System.Single GroupSearchRadius;
public global::System.Single BiggestGroupSearchInterval;
public global::System.Boolean IgnoreOtherCameras;
public global::System.Single HeadForwardPointDistance;
public global::System.Single HeadBackwardPointDistance;
public global::System.Single HeadUpPointDistance;
public global::System.Single HeadDownPointDistance;
public global::System.Single HeightOffset;
public global::System.Single CircleOffset;
public global::System.Single DistanceOffset;
public global::System.Single CircleSpeed;
public global::System.Single PositionSpeed;
public global::System.Single LookSpeed;
public global::System.Single DistanceSpeed;
public global::System.Single UserInfluenceSpeed;
public global::System.Single HeightAmplitude;
public global::System.Single DistanceAmplitude;
public global::System.Single CircleAmplitude;
public global::System.Single HeightPeriod;
public global::System.Single DistancePeriod;
public global::System.Single CirclePeriod;
public global::System.Single CirclePeriodNoiseSpeed;
public global::System.Single CirclePeriodNoiseInfluence;
public global::System.Boolean CheckOcclusion;
public global::System.Boolean AdjustHeightOnOcclusion;
public global::System.Single TeleportWaitTime;
public global::System.Single TeleportTriggerRelativeDistance;
public global::System.Single TeleportTriggerAngle;
public global::System.Single MinRandomizeFovInterval;
public global::System.Single MaxRandomizeFovInterval;
public global::System.Single MinFov;
public global::System.Single MaxFov;
public global::System.Single MinChangeFovTime;
public global::System.Single MaxChangeFovTime;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("CameraUser", new ResoniteLink.SyncObject() { Members = CameraUser.CollectMembers() });
members.Add("SimulateOnHost", SimulateOnHost.ToResoniteLinkField());
members.Add("ManualControl", ManualControl.ToResoniteLinkField());
members.Add("SlowSpeed", SlowSpeed.ToResoniteLinkField());
members.Add("Speed", Speed.ToResoniteLinkField());
members.Add("FastSpeed", FastSpeed.ToResoniteLinkField());
members.Add("MouseSensitivity", MouseSensitivity.ToResoniteLinkField());
members.Add("FieldOfViewSource", new ResoniteLink.Reference() { });
members.Add("FieldOfView", FieldOfView.ToResoniteLinkField());
members.Add("AspectRatioSource", new ResoniteLink.Reference() { });
members.Add("AspectRatio", AspectRatio.ToResoniteLinkField());
members.Add("FollowUser", new ResoniteLink.Reference() { });
members.Add("ControllerRejectDistance", ControllerRejectDistance.ToResoniteLinkField());
members.Add("GroupSearchRadius", GroupSearchRadius.ToResoniteLinkField());
members.Add("BiggestGroupSearchInterval", BiggestGroupSearchInterval.ToResoniteLinkField());
members.Add("IgnoreOtherCameras", IgnoreOtherCameras.ToResoniteLinkField());
members.Add("HeadForwardPointDistance", HeadForwardPointDistance.ToResoniteLinkField());
members.Add("HeadBackwardPointDistance", HeadBackwardPointDistance.ToResoniteLinkField());
members.Add("HeadUpPointDistance", HeadUpPointDistance.ToResoniteLinkField());
members.Add("HeadDownPointDistance", HeadDownPointDistance.ToResoniteLinkField());
members.Add("HeightOffset", HeightOffset.ToResoniteLinkField());
members.Add("CircleOffset", CircleOffset.ToResoniteLinkField());
members.Add("DistanceOffset", DistanceOffset.ToResoniteLinkField());
members.Add("CircleSpeed", CircleSpeed.ToResoniteLinkField());
members.Add("PositionSpeed", PositionSpeed.ToResoniteLinkField());
members.Add("LookSpeed", LookSpeed.ToResoniteLinkField());
members.Add("DistanceSpeed", DistanceSpeed.ToResoniteLinkField());
members.Add("UserInfluenceSpeed", UserInfluenceSpeed.ToResoniteLinkField());
members.Add("HeightAmplitude", HeightAmplitude.ToResoniteLinkField());
members.Add("DistanceAmplitude", DistanceAmplitude.ToResoniteLinkField());
members.Add("CircleAmplitude", CircleAmplitude.ToResoniteLinkField());
members.Add("HeightPeriod", HeightPeriod.ToResoniteLinkField());
members.Add("DistancePeriod", DistancePeriod.ToResoniteLinkField());
members.Add("CirclePeriod", CirclePeriod.ToResoniteLinkField());
members.Add("CirclePeriodNoiseSpeed", CirclePeriodNoiseSpeed.ToResoniteLinkField());
members.Add("CirclePeriodNoiseInfluence", CirclePeriodNoiseInfluence.ToResoniteLinkField());
members.Add("CheckOcclusion", CheckOcclusion.ToResoniteLinkField());
members.Add("AdjustHeightOnOcclusion", AdjustHeightOnOcclusion.ToResoniteLinkField());
members.Add("TeleportWaitTime", TeleportWaitTime.ToResoniteLinkField());
members.Add("TeleportTriggerRelativeDistance", TeleportTriggerRelativeDistance.ToResoniteLinkField());
members.Add("TeleportTriggerAngle", TeleportTriggerAngle.ToResoniteLinkField());
members.Add("MinRandomizeFovInterval", MinRandomizeFovInterval.ToResoniteLinkField());
members.Add("MaxRandomizeFovInterval", MaxRandomizeFovInterval.ToResoniteLinkField());
members.Add("MinFov", MinFov.ToResoniteLinkField());
members.Add("MaxFov", MaxFov.ToResoniteLinkField());
members.Add("MinChangeFovTime", MinChangeFovTime.ToResoniteLinkField());
members.Add("MaxChangeFovTime", MaxChangeFovTime.ToResoniteLinkField());
}

}
}
