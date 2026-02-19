
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhysicalLocomotion
// Generated on: čtvrtek 19. února 2026 7:59:00
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhysicalLocomotion")]
public partial class PhysicalLocomotion : global::FrooxEngine.SmoothLocomotionBase, global::FrooxEngine.ICustomInspector, global::FrooxEngine.IPhysicalLocomotion, global::FrooxEngine.IFieldOfViewModifier

{
    public global::FrooxEngine.TurnSubmodule Turn;
public global::System.Nullable<global::FrooxEngine.LocomotionArchetype> Archetype;
public global::System.Single MinInitializationDelay;
public global::System.Single MaxInitializationDelay;
public global::FrooxEngine.Slot InitializationColliderRoot;
public global::System.Boolean UseSpeedFromUserSettings;
public global::System.String Description;
public global::FrooxEngine.PhysicalLocomotion.MovementMode Mode;
public global::FrooxEngine.PhysicalLocomotion.EnvironmentGripping Gripping;
public global::System.Boolean GripOnHold;
public global::System.Single GripRadius;
public global::System.Single GripVelocityMultiplier;
public global::FrooxEngine.PhysicalLocomotion.GripRotation GripHandRotationMode;
public global::FrooxEngine.PhysicalLocomotion.GripRotation GripObjectRotationMode;
public global::System.Nullable<global::System.Single> HandGripRotationSmoothSpeed;
public global::System.Single FallRespawnPosition;
public global::System.Boolean MakeGravityCharacterLocal;
public global::System.Single AutoAlignVerticalWithGravitySpeed;
public global::System.Single ManualAlignVerticalWithGravitySpeed;
public global::System.Single AirDecelerationSpeed;
public global::System.Single GripScaleDelay;
public global::System.Boolean AllowCrouch;
public global::System.Single MaximumNormalizedSpeed;
public System.Uri _defaultIcon;
public UnityEngine.ColorX _defaultColor;
public global::FrooxEngine.CharacterController _characterController;
public global::System.String __legacyName;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Turn", new ResoniteLink.SyncObject() { Members = Turn.CollectMembers(context) });
members.Add("Archetype", Archetype.ToResoniteLinkField());
members.Add("MinInitializationDelay", MinInitializationDelay.ToResoniteLinkField());
members.Add("MaxInitializationDelay", MaxInitializationDelay.ToResoniteLinkField());
members.Add("InitializationColliderRoot", InitializationColliderRoot.ToResoniteReference(context));
members.Add("UseSpeedFromUserSettings", UseSpeedFromUserSettings.ToResoniteLinkField());
members.Add("Description", Description.ToResoniteLinkField());
members.Add("Mode", Mode.ToResoniteLinkField());
members.Add("Gripping", Gripping.ToResoniteLinkField());
members.Add("GripOnHold", GripOnHold.ToResoniteLinkField());
members.Add("GripRadius", GripRadius.ToResoniteLinkField());
members.Add("GripVelocityMultiplier", GripVelocityMultiplier.ToResoniteLinkField());
members.Add("GripHandRotationMode", GripHandRotationMode.ToResoniteLinkField());
members.Add("GripObjectRotationMode", GripObjectRotationMode.ToResoniteLinkField());
members.Add("HandGripRotationSmoothSpeed", HandGripRotationSmoothSpeed.ToResoniteLinkField());
members.Add("FallRespawnPosition", FallRespawnPosition.ToResoniteLinkField());
members.Add("MakeGravityCharacterLocal", MakeGravityCharacterLocal.ToResoniteLinkField());
members.Add("AutoAlignVerticalWithGravitySpeed", AutoAlignVerticalWithGravitySpeed.ToResoniteLinkField());
members.Add("ManualAlignVerticalWithGravitySpeed", ManualAlignVerticalWithGravitySpeed.ToResoniteLinkField());
members.Add("AirDecelerationSpeed", AirDecelerationSpeed.ToResoniteLinkField());
members.Add("GripScaleDelay", GripScaleDelay.ToResoniteLinkField());
members.Add("AllowCrouch", AllowCrouch.ToResoniteLinkField());
members.Add("MaximumNormalizedSpeed", MaximumNormalizedSpeed.ToResoniteLinkField());
members.Add("_defaultIcon", _defaultIcon.ToResoniteLinkField());
members.Add("_defaultColor", _defaultColor.ToResoniteLinkField());
members.Add("_characterController", _characterController.ToResoniteReference(context));
members.Add("__legacyName", __legacyName.ToResoniteLinkField());
}

}
}
