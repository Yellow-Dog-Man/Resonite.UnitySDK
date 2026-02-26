
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CharacterController
// Generated on: čtvrtek 26. února 2026 10:03:40
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CharacterController")]
public partial class CharacterController : global::FrooxEngine.Component, global::FrooxEngine.IBounded

{
    public global::FrooxEngine.User SimulatingUser { get => SimulatingUser_Element.Data; set => SimulatingUser_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> SimulatingUser_Element = new();
public global::FrooxEngine.Slot CharacterRoot { get => CharacterRoot_Element.Data; set => CharacterRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> CharacterRoot_Element = new();
public global::FrooxEngine.Slot HeadReference { get => HeadReference_Element.Data; set => HeadReference_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> HeadReference_Element = new();
public global::System.Boolean SimulateRotation { get => SimulateRotation_Element.Data; set => SimulateRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SimulateRotation_Element = new();
public global::FrooxEngine.PhysicsScalingMode MassScaling { get => MassScaling_Element.Data; set => MassScaling_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PhysicsScalingMode>, global::FrooxEngine.PhysicsScalingMode> MassScaling_Element = new();
public global::FrooxEngine.PhysicsScalingMode ForceScaling { get => ForceScaling_Element.Data; set => ForceScaling_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PhysicsScalingMode>, global::FrooxEngine.PhysicsScalingMode> ForceScaling_Element = new();
public global::FrooxEngine.PhysicsScalingMode SpeedScaling { get => SpeedScaling_Element.Data; set => SpeedScaling_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PhysicsScalingMode>, global::FrooxEngine.PhysicsScalingMode> SpeedScaling_Element = new();
public global::FrooxEngine.PhysicsScalingMode JumpScaling { get => JumpScaling_Element.Data; set => JumpScaling_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PhysicsScalingMode>, global::FrooxEngine.PhysicsScalingMode> JumpScaling_Element = new();
public global::FrooxEngine.PhysicsScalingMode GravityScaling { get => GravityScaling_Element.Data; set => GravityScaling_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PhysicsScalingMode>, global::FrooxEngine.PhysicsScalingMode> GravityScaling_Element = new();
public global::System.Single LinearDamping { get => LinearDamping_Element.Data; set => LinearDamping_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LinearDamping_Element = new();
public global::System.Single AngularDamping { get => AngularDamping_Element.Data; set => AngularDamping_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AngularDamping_Element = new();
public global::System.Single Margin { get => Margin_Element.Data; set => Margin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Margin_Element = new();
public global::System.Single StepUpHeight { get => StepUpHeight_Element.Data; set => StepUpHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StepUpHeight_Element = new();
public global::System.Single StepUpCheckDistance { get => StepUpCheckDistance_Element.Data; set => StepUpCheckDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StepUpCheckDistance_Element = new();
public global::System.Boolean KillVerticalVelocityAfterStepUp { get => KillVerticalVelocityAfterStepUp_Element.Data; set => KillVerticalVelocityAfterStepUp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> KillVerticalVelocityAfterStepUp_Element = new();
public global::System.Single EdgeDetectionDepth { get => EdgeDetectionDepth_Element.Data; set => EdgeDetectionDepth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EdgeDetectionDepth_Element = new();
public global::System.Single Speed { get => Speed_Element.Data; set => Speed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Speed_Element = new();
public global::System.Single SlidingSpeed { get => SlidingSpeed_Element.Data; set => SlidingSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SlidingSpeed_Element = new();
public global::System.Single AirSpeed { get => AirSpeed_Element.Data; set => AirSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AirSpeed_Element = new();
public global::System.Single TractionForce { get => TractionForce_Element.Data; set => TractionForce_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TractionForce_Element = new();
public global::System.Single SlidingForce { get => SlidingForce_Element.Data; set => SlidingForce_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SlidingForce_Element = new();
public global::System.Single AirForce { get => AirForce_Element.Data; set => AirForce_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AirForce_Element = new();
public global::System.Single MaximumGlueForce { get => MaximumGlueForce_Element.Data; set => MaximumGlueForce_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaximumGlueForce_Element = new();
public global::System.Single MaximumTractionSlope { get => MaximumTractionSlope_Element.Data; set => MaximumTractionSlope_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaximumTractionSlope_Element = new();
public global::System.Single MaximumSupportSlope { get => MaximumSupportSlope_Element.Data; set => MaximumSupportSlope_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaximumSupportSlope_Element = new();
public global::System.Single JumpSpeed { get => JumpSpeed_Element.Data; set => JumpSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> JumpSpeed_Element = new();
public global::System.Single SlidingJumpSpeed { get => SlidingJumpSpeed_Element.Data; set => SlidingJumpSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SlidingJumpSpeed_Element = new();
public UnityEngine.Vector3 Gravity { get => Gravity_Element.Data; set => Gravity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Gravity_Element = new();
public global::FrooxEngine.RootSpace GravitySpace = new();
public global::System.Nullable<global::System.Single> DebugVisualDuration { get => DebugVisualDuration_Element.Data; set => DebugVisualDuration_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> DebugVisualDuration_Element = new();
public global::System.Single __height { get => __height_Element.Data; set => __height_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> __height_Element = new();
public global::System.Single __radius { get => __radius_Element.Data; set => __radius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> __radius_Element = new();
public global::System.Single __mass { get => __mass_Element.Data; set => __mass_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> __mass_Element = new();
public global::System.Boolean __collideWithOtherCharacters { get => __collideWithOtherCharacters_Element.Data; set => __collideWithOtherCharacters_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> __collideWithOtherCharacters_Element = new();
public global::System.Boolean __ignoreRaycasts { get => __ignoreRaycasts_Element.Data; set => __ignoreRaycasts_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> __ignoreRaycasts_Element = new();
public global::System.Boolean __rootAtBottom { get => __rootAtBottom_Element.Data; set => __rootAtBottom_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> __rootAtBottom_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SimulatingUser", SimulatingUser_Element.Data.ToResoniteReference(context));
members.Add("CharacterRoot", CharacterRoot_Element.Data.ToResoniteReference(context));
members.Add("HeadReference", HeadReference_Element.Data.ToResoniteReference(context));
members.Add("SimulateRotation", SimulateRotation_Element.Data.ToResoniteLinkField());
members.Add("MassScaling", MassScaling_Element.Data.ToResoniteLinkField());
members.Add("ForceScaling", ForceScaling_Element.Data.ToResoniteLinkField());
members.Add("SpeedScaling", SpeedScaling_Element.Data.ToResoniteLinkField());
members.Add("JumpScaling", JumpScaling_Element.Data.ToResoniteLinkField());
members.Add("GravityScaling", GravityScaling_Element.Data.ToResoniteLinkField());
members.Add("LinearDamping", LinearDamping_Element.Data.ToResoniteLinkField());
members.Add("AngularDamping", AngularDamping_Element.Data.ToResoniteLinkField());
members.Add("Margin", Margin_Element.Data.ToResoniteLinkField());
members.Add("StepUpHeight", StepUpHeight_Element.Data.ToResoniteLinkField());
members.Add("StepUpCheckDistance", StepUpCheckDistance_Element.Data.ToResoniteLinkField());
members.Add("KillVerticalVelocityAfterStepUp", KillVerticalVelocityAfterStepUp_Element.Data.ToResoniteLinkField());
members.Add("EdgeDetectionDepth", EdgeDetectionDepth_Element.Data.ToResoniteLinkField());
members.Add("Speed", Speed_Element.Data.ToResoniteLinkField());
members.Add("SlidingSpeed", SlidingSpeed_Element.Data.ToResoniteLinkField());
members.Add("AirSpeed", AirSpeed_Element.Data.ToResoniteLinkField());
members.Add("TractionForce", TractionForce_Element.Data.ToResoniteLinkField());
members.Add("SlidingForce", SlidingForce_Element.Data.ToResoniteLinkField());
members.Add("AirForce", AirForce_Element.Data.ToResoniteLinkField());
members.Add("MaximumGlueForce", MaximumGlueForce_Element.Data.ToResoniteLinkField());
members.Add("MaximumTractionSlope", MaximumTractionSlope_Element.Data.ToResoniteLinkField());
members.Add("MaximumSupportSlope", MaximumSupportSlope_Element.Data.ToResoniteLinkField());
members.Add("JumpSpeed", JumpSpeed_Element.Data.ToResoniteLinkField());
members.Add("SlidingJumpSpeed", SlidingJumpSpeed_Element.Data.ToResoniteLinkField());
members.Add("Gravity", Gravity_Element.Data.ToResoniteLinkField());
members.Add("GravitySpace", new ResoniteLink.SyncObject() { Members = GravitySpace.CollectMembers(context) });
members.Add("DebugVisualDuration", DebugVisualDuration_Element.Data.ToResoniteLinkField());
members.Add("__height", __height_Element.Data.ToResoniteLinkField());
members.Add("__radius", __radius_Element.Data.ToResoniteLinkField());
members.Add("__mass", __mass_Element.Data.ToResoniteLinkField());
members.Add("__collideWithOtherCharacters", __collideWithOtherCharacters_Element.Data.ToResoniteLinkField());
members.Add("__ignoreRaycasts", __ignoreRaycasts_Element.Data.ToResoniteLinkField());
members.Add("__rootAtBottom", __rootAtBottom_Element.Data.ToResoniteLinkField());
}

}
}
