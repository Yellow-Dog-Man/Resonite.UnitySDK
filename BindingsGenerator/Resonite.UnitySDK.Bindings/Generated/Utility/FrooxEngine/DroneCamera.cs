
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DroneCamera
// Generated on: čtvrtek 26. února 2026 12:28:16
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.UserRef CameraUser = new();
public global::System.Boolean SimulateOnHost { get => SimulateOnHost_Element.Data; set => SimulateOnHost_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SimulateOnHost_Element = new();
public global::System.Boolean ManualControl { get => ManualControl_Element.Data; set => ManualControl_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ManualControl_Element = new();
public global::System.Single SlowSpeed { get => SlowSpeed_Element.Data; set => SlowSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SlowSpeed_Element = new();
public global::System.Single Speed { get => Speed_Element.Data; set => Speed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Speed_Element = new();
public global::System.Single FastSpeed { get => FastSpeed_Element.Data; set => FastSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FastSpeed_Element = new();
public global::System.Single MouseSensitivity { get => MouseSensitivity_Element.Data; set => MouseSensitivity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MouseSensitivity_Element = new();
public global::FrooxEngine.IField<global::System.Single> FieldOfViewSource { get => FieldOfViewSource_Element.Data; set => FieldOfViewSource_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> FieldOfViewSource_Element = new();
public global::System.Single FieldOfView { get => FieldOfView_Element.Data; set => FieldOfView_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FieldOfView_Element = new();
public global::FrooxEngine.IField<global::System.Single> AspectRatioSource { get => AspectRatioSource_Element.Data; set => AspectRatioSource_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> AspectRatioSource_Element = new();
public global::System.Single AspectRatio { get => AspectRatio_Element.Data; set => AspectRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AspectRatio_Element = new();
public global::FrooxEngine.User FollowUser { get => FollowUser_Element.Data; set => FollowUser_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> FollowUser_Element = new();
public global::System.Single ControllerRejectDistance { get => ControllerRejectDistance_Element.Data; set => ControllerRejectDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ControllerRejectDistance_Element = new();
public global::System.Single GroupSearchRadius { get => GroupSearchRadius_Element.Data; set => GroupSearchRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GroupSearchRadius_Element = new();
public global::System.Single BiggestGroupSearchInterval { get => BiggestGroupSearchInterval_Element.Data; set => BiggestGroupSearchInterval_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BiggestGroupSearchInterval_Element = new();
public global::System.Boolean IgnoreOtherCameras { get => IgnoreOtherCameras_Element.Data; set => IgnoreOtherCameras_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IgnoreOtherCameras_Element = new();
public global::System.Single HeadForwardPointDistance { get => HeadForwardPointDistance_Element.Data; set => HeadForwardPointDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadForwardPointDistance_Element = new();
public global::System.Single HeadBackwardPointDistance { get => HeadBackwardPointDistance_Element.Data; set => HeadBackwardPointDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadBackwardPointDistance_Element = new();
public global::System.Single HeadUpPointDistance { get => HeadUpPointDistance_Element.Data; set => HeadUpPointDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadUpPointDistance_Element = new();
public global::System.Single HeadDownPointDistance { get => HeadDownPointDistance_Element.Data; set => HeadDownPointDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadDownPointDistance_Element = new();
public global::System.Single HeightOffset { get => HeightOffset_Element.Data; set => HeightOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeightOffset_Element = new();
public global::System.Single CircleOffset { get => CircleOffset_Element.Data; set => CircleOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CircleOffset_Element = new();
public global::System.Single DistanceOffset { get => DistanceOffset_Element.Data; set => DistanceOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DistanceOffset_Element = new();
public global::System.Single CircleSpeed { get => CircleSpeed_Element.Data; set => CircleSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CircleSpeed_Element = new();
public global::System.Single PositionSpeed { get => PositionSpeed_Element.Data; set => PositionSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PositionSpeed_Element = new();
public global::System.Single LookSpeed { get => LookSpeed_Element.Data; set => LookSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LookSpeed_Element = new();
public global::System.Single DistanceSpeed { get => DistanceSpeed_Element.Data; set => DistanceSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DistanceSpeed_Element = new();
public global::System.Single UserInfluenceSpeed { get => UserInfluenceSpeed_Element.Data; set => UserInfluenceSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> UserInfluenceSpeed_Element = new();
public global::System.Single HeightAmplitude { get => HeightAmplitude_Element.Data; set => HeightAmplitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeightAmplitude_Element = new();
public global::System.Single DistanceAmplitude { get => DistanceAmplitude_Element.Data; set => DistanceAmplitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DistanceAmplitude_Element = new();
public global::System.Single CircleAmplitude { get => CircleAmplitude_Element.Data; set => CircleAmplitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CircleAmplitude_Element = new();
public global::System.Single HeightPeriod { get => HeightPeriod_Element.Data; set => HeightPeriod_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeightPeriod_Element = new();
public global::System.Single DistancePeriod { get => DistancePeriod_Element.Data; set => DistancePeriod_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DistancePeriod_Element = new();
public global::System.Single CirclePeriod { get => CirclePeriod_Element.Data; set => CirclePeriod_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CirclePeriod_Element = new();
public global::System.Single CirclePeriodNoiseSpeed { get => CirclePeriodNoiseSpeed_Element.Data; set => CirclePeriodNoiseSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CirclePeriodNoiseSpeed_Element = new();
public global::System.Single CirclePeriodNoiseInfluence { get => CirclePeriodNoiseInfluence_Element.Data; set => CirclePeriodNoiseInfluence_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CirclePeriodNoiseInfluence_Element = new();
public global::System.Boolean CheckOcclusion { get => CheckOcclusion_Element.Data; set => CheckOcclusion_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CheckOcclusion_Element = new();
public global::System.Boolean AdjustHeightOnOcclusion { get => AdjustHeightOnOcclusion_Element.Data; set => AdjustHeightOnOcclusion_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AdjustHeightOnOcclusion_Element = new();
public global::System.Single TeleportWaitTime { get => TeleportWaitTime_Element.Data; set => TeleportWaitTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TeleportWaitTime_Element = new();
public global::System.Single TeleportTriggerRelativeDistance { get => TeleportTriggerRelativeDistance_Element.Data; set => TeleportTriggerRelativeDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TeleportTriggerRelativeDistance_Element = new();
public global::System.Single TeleportTriggerAngle { get => TeleportTriggerAngle_Element.Data; set => TeleportTriggerAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TeleportTriggerAngle_Element = new();
public global::System.Single MinRandomizeFovInterval { get => MinRandomizeFovInterval_Element.Data; set => MinRandomizeFovInterval_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinRandomizeFovInterval_Element = new();
public global::System.Single MaxRandomizeFovInterval { get => MaxRandomizeFovInterval_Element.Data; set => MaxRandomizeFovInterval_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxRandomizeFovInterval_Element = new();
public global::System.Single MinFov { get => MinFov_Element.Data; set => MinFov_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinFov_Element = new();
public global::System.Single MaxFov { get => MaxFov_Element.Data; set => MaxFov_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxFov_Element = new();
public global::System.Single MinChangeFovTime { get => MinChangeFovTime_Element.Data; set => MinChangeFovTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinChangeFovTime_Element = new();
public global::System.Single MaxChangeFovTime { get => MaxChangeFovTime_Element.Data; set => MaxChangeFovTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxChangeFovTime_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CameraUser", CameraUser.ToLinkSyncObject(context));
members.Add("SimulateOnHost", SimulateOnHost_Element.ToLinkField(context));
members.Add("ManualControl", ManualControl_Element.ToLinkField(context));
members.Add("SlowSpeed", SlowSpeed_Element.ToLinkField(context));
members.Add("Speed", Speed_Element.ToLinkField(context));
members.Add("FastSpeed", FastSpeed_Element.ToLinkField(context));
members.Add("MouseSensitivity", MouseSensitivity_Element.ToLinkField(context));
members.Add("FieldOfViewSource", FieldOfViewSource_Element.ToLinkReference(context));
members.Add("FieldOfView", FieldOfView_Element.ToLinkField(context));
members.Add("AspectRatioSource", AspectRatioSource_Element.ToLinkReference(context));
members.Add("AspectRatio", AspectRatio_Element.ToLinkField(context));
members.Add("FollowUser", FollowUser_Element.ToLinkReference(context));
members.Add("ControllerRejectDistance", ControllerRejectDistance_Element.ToLinkField(context));
members.Add("GroupSearchRadius", GroupSearchRadius_Element.ToLinkField(context));
members.Add("BiggestGroupSearchInterval", BiggestGroupSearchInterval_Element.ToLinkField(context));
members.Add("IgnoreOtherCameras", IgnoreOtherCameras_Element.ToLinkField(context));
members.Add("HeadForwardPointDistance", HeadForwardPointDistance_Element.ToLinkField(context));
members.Add("HeadBackwardPointDistance", HeadBackwardPointDistance_Element.ToLinkField(context));
members.Add("HeadUpPointDistance", HeadUpPointDistance_Element.ToLinkField(context));
members.Add("HeadDownPointDistance", HeadDownPointDistance_Element.ToLinkField(context));
members.Add("HeightOffset", HeightOffset_Element.ToLinkField(context));
members.Add("CircleOffset", CircleOffset_Element.ToLinkField(context));
members.Add("DistanceOffset", DistanceOffset_Element.ToLinkField(context));
members.Add("CircleSpeed", CircleSpeed_Element.ToLinkField(context));
members.Add("PositionSpeed", PositionSpeed_Element.ToLinkField(context));
members.Add("LookSpeed", LookSpeed_Element.ToLinkField(context));
members.Add("DistanceSpeed", DistanceSpeed_Element.ToLinkField(context));
members.Add("UserInfluenceSpeed", UserInfluenceSpeed_Element.ToLinkField(context));
members.Add("HeightAmplitude", HeightAmplitude_Element.ToLinkField(context));
members.Add("DistanceAmplitude", DistanceAmplitude_Element.ToLinkField(context));
members.Add("CircleAmplitude", CircleAmplitude_Element.ToLinkField(context));
members.Add("HeightPeriod", HeightPeriod_Element.ToLinkField(context));
members.Add("DistancePeriod", DistancePeriod_Element.ToLinkField(context));
members.Add("CirclePeriod", CirclePeriod_Element.ToLinkField(context));
members.Add("CirclePeriodNoiseSpeed", CirclePeriodNoiseSpeed_Element.ToLinkField(context));
members.Add("CirclePeriodNoiseInfluence", CirclePeriodNoiseInfluence_Element.ToLinkField(context));
members.Add("CheckOcclusion", CheckOcclusion_Element.ToLinkField(context));
members.Add("AdjustHeightOnOcclusion", AdjustHeightOnOcclusion_Element.ToLinkField(context));
members.Add("TeleportWaitTime", TeleportWaitTime_Element.ToLinkField(context));
members.Add("TeleportTriggerRelativeDistance", TeleportTriggerRelativeDistance_Element.ToLinkField(context));
members.Add("TeleportTriggerAngle", TeleportTriggerAngle_Element.ToLinkField(context));
members.Add("MinRandomizeFovInterval", MinRandomizeFovInterval_Element.ToLinkField(context));
members.Add("MaxRandomizeFovInterval", MaxRandomizeFovInterval_Element.ToLinkField(context));
members.Add("MinFov", MinFov_Element.ToLinkField(context));
members.Add("MaxFov", MaxFov_Element.ToLinkField(context));
members.Add("MinChangeFovTime", MinChangeFovTime_Element.ToLinkField(context));
members.Add("MaxChangeFovTime", MaxChangeFovTime_Element.ToLinkField(context));
}

}
}
