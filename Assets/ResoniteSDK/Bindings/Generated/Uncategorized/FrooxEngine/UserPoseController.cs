
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserPoseController
// Generated on: sobota 14. února 2026 8:58:43
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserPoseController")]
public partial class UserPoseController : global::FrooxEngine.UserRootComponent

{
    public global::FrooxEngine.ScreenController ScreenController;
public global::System.Single BodyHorizontalAngle;
public global::System.Boolean RenderDebugVisuals;
public global::System.Boolean PauseLocomotionAnimation;
public global::System.Nullable<UnityEngine.Vector3> OverrideLocomotionVelocity;
public global::System.Nullable<global::System.Single> OverrideLocomotionAngularVelocity;
public global::System.Single SimulationSpeedRatio;
public global::FrooxEngine.LocomotionAnimationConfiguration _defaultConfig;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ScreenController", ScreenController.ToResoniteReference(context));
members.Add("BodyHorizontalAngle", BodyHorizontalAngle.ToResoniteLinkField());
members.Add("RenderDebugVisuals", RenderDebugVisuals.ToResoniteLinkField());
members.Add("PauseLocomotionAnimation", PauseLocomotionAnimation.ToResoniteLinkField());
members.Add("OverrideLocomotionVelocity", OverrideLocomotionVelocity.ToResoniteLinkField());
members.Add("OverrideLocomotionAngularVelocity", OverrideLocomotionAngularVelocity.ToResoniteLinkField());
members.Add("SimulationSpeedRatio", SimulationSpeedRatio.ToResoniteLinkField());
members.Add("_defaultConfig", _defaultConfig.ToResoniteReference(context));
}

}
}
