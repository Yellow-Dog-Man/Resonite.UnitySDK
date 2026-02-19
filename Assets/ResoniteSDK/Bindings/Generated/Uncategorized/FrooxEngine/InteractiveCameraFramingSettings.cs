
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraFramingSettings
// Generated on: čtvrtek 19. února 2026 8:00:28
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraFramingSettings")]
public partial class InteractiveCameraFramingSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.InteractiveCameraFramingSettings>

{
    public global::FrooxEngine.CameraPositioningMode PositioningMode;
public global::System.Single FieldOfView;
public global::System.Single AnglePosition;
public global::System.Single Distance;
public global::System.Single HeightOffset;
public global::System.Single FirstPersonPitch;
public global::System.Single FirstPersonRoll;
public global::System.Single FirstPersonOffset;
public UnityEngine.Vector2 FramingViewportPosition;
public global::System.Boolean AimInFrontOfHead;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PositioningMode", PositioningMode.ToResoniteLinkField());
members.Add("FieldOfView", FieldOfView.ToResoniteLinkField());
members.Add("AnglePosition", AnglePosition.ToResoniteLinkField());
members.Add("Distance", Distance.ToResoniteLinkField());
members.Add("HeightOffset", HeightOffset.ToResoniteLinkField());
members.Add("FirstPersonPitch", FirstPersonPitch.ToResoniteLinkField());
members.Add("FirstPersonRoll", FirstPersonRoll.ToResoniteLinkField());
members.Add("FirstPersonOffset", FirstPersonOffset.ToResoniteLinkField());
members.Add("FramingViewportPosition", FramingViewportPosition.ToResoniteLinkField());
members.Add("AimInFrontOfHead", AimInFrontOfHead.ToResoniteLinkField());
}

}
}
