
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CharacterController
// Generated on: úterý 24. února 2026 18:17:51
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CharacterController")]
public partial class CharacterController : global::FrooxEngine.Component, global::FrooxEngine.IBounded

{
    public global::FrooxEngine.User SimulatingUser;
public global::FrooxEngine.Slot CharacterRoot;
public global::FrooxEngine.Slot HeadReference;
public global::System.Boolean SimulateRotation;
public global::FrooxEngine.PhysicsScalingMode MassScaling;
public global::FrooxEngine.PhysicsScalingMode ForceScaling;
public global::FrooxEngine.PhysicsScalingMode SpeedScaling;
public global::FrooxEngine.PhysicsScalingMode JumpScaling;
public global::FrooxEngine.PhysicsScalingMode GravityScaling;
public global::System.Single LinearDamping;
public global::System.Single AngularDamping;
public global::System.Single Margin;
public global::System.Single StepUpHeight;
public global::System.Single StepUpCheckDistance;
public global::System.Boolean KillVerticalVelocityAfterStepUp;
public global::System.Single EdgeDetectionDepth;
public global::System.Single Speed;
public global::System.Single SlidingSpeed;
public global::System.Single AirSpeed;
public global::System.Single TractionForce;
public global::System.Single SlidingForce;
public global::System.Single AirForce;
public global::System.Single MaximumGlueForce;
public global::System.Single MaximumTractionSlope;
public global::System.Single MaximumSupportSlope;
public global::System.Single JumpSpeed;
public global::System.Single SlidingJumpSpeed;
public UnityEngine.Vector3 Gravity;
public global::FrooxEngine.RootSpace GravitySpace;
public global::System.Nullable<global::System.Single> DebugVisualDuration;
public global::System.Single __height;
public global::System.Single __radius;
public global::System.Single __mass;
public global::System.Boolean __collideWithOtherCharacters;
public global::System.Boolean __ignoreRaycasts;
public global::System.Boolean __rootAtBottom;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SimulatingUser", SimulatingUser.ToResoniteReference(context));
members.Add("CharacterRoot", CharacterRoot.ToResoniteReference(context));
members.Add("HeadReference", HeadReference.ToResoniteReference(context));
members.Add("SimulateRotation", SimulateRotation.ToResoniteLinkField());
members.Add("MassScaling", MassScaling.ToResoniteLinkField());
members.Add("ForceScaling", ForceScaling.ToResoniteLinkField());
members.Add("SpeedScaling", SpeedScaling.ToResoniteLinkField());
members.Add("JumpScaling", JumpScaling.ToResoniteLinkField());
members.Add("GravityScaling", GravityScaling.ToResoniteLinkField());
members.Add("LinearDamping", LinearDamping.ToResoniteLinkField());
members.Add("AngularDamping", AngularDamping.ToResoniteLinkField());
members.Add("Margin", Margin.ToResoniteLinkField());
members.Add("StepUpHeight", StepUpHeight.ToResoniteLinkField());
members.Add("StepUpCheckDistance", StepUpCheckDistance.ToResoniteLinkField());
members.Add("KillVerticalVelocityAfterStepUp", KillVerticalVelocityAfterStepUp.ToResoniteLinkField());
members.Add("EdgeDetectionDepth", EdgeDetectionDepth.ToResoniteLinkField());
members.Add("Speed", Speed.ToResoniteLinkField());
members.Add("SlidingSpeed", SlidingSpeed.ToResoniteLinkField());
members.Add("AirSpeed", AirSpeed.ToResoniteLinkField());
members.Add("TractionForce", TractionForce.ToResoniteLinkField());
members.Add("SlidingForce", SlidingForce.ToResoniteLinkField());
members.Add("AirForce", AirForce.ToResoniteLinkField());
members.Add("MaximumGlueForce", MaximumGlueForce.ToResoniteLinkField());
members.Add("MaximumTractionSlope", MaximumTractionSlope.ToResoniteLinkField());
members.Add("MaximumSupportSlope", MaximumSupportSlope.ToResoniteLinkField());
members.Add("JumpSpeed", JumpSpeed.ToResoniteLinkField());
members.Add("SlidingJumpSpeed", SlidingJumpSpeed.ToResoniteLinkField());
members.Add("Gravity", Gravity.ToResoniteLinkField());
members.Add("GravitySpace", new ResoniteLink.SyncObject() { Members = GravitySpace.CollectMembers(context) });
members.Add("DebugVisualDuration", DebugVisualDuration.ToResoniteLinkField());
members.Add("__height", __height.ToResoniteLinkField());
members.Add("__radius", __radius.ToResoniteLinkField());
members.Add("__mass", __mass.ToResoniteLinkField());
members.Add("__collideWithOtherCharacters", __collideWithOtherCharacters.ToResoniteLinkField());
members.Add("__ignoreRaycasts", __ignoreRaycasts.ToResoniteLinkField());
members.Add("__rootAtBottom", __rootAtBottom.ToResoniteLinkField());
}

}
}
