
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhysicalLocomotion
// Generated on: čtvrtek 26. února 2026 15:08:01
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhysicalLocomotion")]
public partial class PhysicalLocomotion : global::FrooxEngine.SmoothLocomotionBase, global::FrooxEngine.ICustomInspector, global::FrooxEngine.IPhysicalLocomotion, global::FrooxEngine.IFieldOfViewModifier

{
    public global::FrooxEngine.TurnSubmodule Turn = new();
public global::System.Nullable<global::FrooxEngine.LocomotionArchetype> Archetype { get => Archetype_Element.Data; set => Archetype_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::FrooxEngine.LocomotionArchetype>>, global::System.Nullable<global::FrooxEngine.LocomotionArchetype>> Archetype_Element = new();
public global::System.Single MinInitializationDelay { get => MinInitializationDelay_Element.Data; set => MinInitializationDelay_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinInitializationDelay_Element = new();
public global::System.Single MaxInitializationDelay { get => MaxInitializationDelay_Element.Data; set => MaxInitializationDelay_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxInitializationDelay_Element = new();
public global::FrooxEngine.Slot InitializationColliderRoot { get => InitializationColliderRoot_Element.Data; set => InitializationColliderRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> InitializationColliderRoot_Element = new();
public global::System.Boolean UseSpeedFromUserSettings { get => UseSpeedFromUserSettings_Element.Data; set => UseSpeedFromUserSettings_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseSpeedFromUserSettings_Element = new();
public global::System.String Description { get => Description_Element.Data; set => Description_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Description_Element = new();
public global::FrooxEngine.PhysicalLocomotion.MovementMode Mode { get => Mode_Element.Data; set => Mode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PhysicalLocomotion.MovementMode>, global::FrooxEngine.PhysicalLocomotion.MovementMode> Mode_Element = new();
public global::FrooxEngine.PhysicalLocomotion.EnvironmentGripping Gripping { get => Gripping_Element.Data; set => Gripping_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PhysicalLocomotion.EnvironmentGripping>, global::FrooxEngine.PhysicalLocomotion.EnvironmentGripping> Gripping_Element = new();
public global::System.Boolean GripOnHold { get => GripOnHold_Element.Data; set => GripOnHold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> GripOnHold_Element = new();
public global::System.Single GripRadius { get => GripRadius_Element.Data; set => GripRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GripRadius_Element = new();
public global::System.Single GripVelocityMultiplier { get => GripVelocityMultiplier_Element.Data; set => GripVelocityMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GripVelocityMultiplier_Element = new();
public global::FrooxEngine.PhysicalLocomotion.GripRotation GripHandRotationMode { get => GripHandRotationMode_Element.Data; set => GripHandRotationMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PhysicalLocomotion.GripRotation>, global::FrooxEngine.PhysicalLocomotion.GripRotation> GripHandRotationMode_Element = new();
public global::FrooxEngine.PhysicalLocomotion.GripRotation GripObjectRotationMode { get => GripObjectRotationMode_Element.Data; set => GripObjectRotationMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PhysicalLocomotion.GripRotation>, global::FrooxEngine.PhysicalLocomotion.GripRotation> GripObjectRotationMode_Element = new();
public global::System.Nullable<global::System.Single> HandGripRotationSmoothSpeed { get => HandGripRotationSmoothSpeed_Element.Data; set => HandGripRotationSmoothSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> HandGripRotationSmoothSpeed_Element = new();
public global::System.Single FallRespawnPosition { get => FallRespawnPosition_Element.Data; set => FallRespawnPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FallRespawnPosition_Element = new();
public global::System.Boolean MakeGravityCharacterLocal { get => MakeGravityCharacterLocal_Element.Data; set => MakeGravityCharacterLocal_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MakeGravityCharacterLocal_Element = new();
public global::System.Single AutoAlignVerticalWithGravitySpeed { get => AutoAlignVerticalWithGravitySpeed_Element.Data; set => AutoAlignVerticalWithGravitySpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AutoAlignVerticalWithGravitySpeed_Element = new();
public global::System.Single ManualAlignVerticalWithGravitySpeed { get => ManualAlignVerticalWithGravitySpeed_Element.Data; set => ManualAlignVerticalWithGravitySpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ManualAlignVerticalWithGravitySpeed_Element = new();
public global::System.Single AirDecelerationSpeed { get => AirDecelerationSpeed_Element.Data; set => AirDecelerationSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AirDecelerationSpeed_Element = new();
public global::System.Single GripScaleDelay { get => GripScaleDelay_Element.Data; set => GripScaleDelay_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GripScaleDelay_Element = new();
public global::System.Boolean AllowCrouch { get => AllowCrouch_Element.Data; set => AllowCrouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowCrouch_Element = new();
public global::System.Single MaximumNormalizedSpeed { get => MaximumNormalizedSpeed_Element.Data; set => MaximumNormalizedSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaximumNormalizedSpeed_Element = new();
public System.Uri _defaultIcon { get => _defaultIcon_Element.Data; set => _defaultIcon_Element.Data = value; }
public Field<global::FrooxEngine.Sync<System.Uri>, System.Uri> _defaultIcon_Element = new();
public UnityEngine.ColorX _defaultColor { get => _defaultColor_Element.Data; set => _defaultColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> _defaultColor_Element = new();
public global::FrooxEngine.CharacterController _characterController { get => _characterController_Element.Data; set => _characterController_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.CharacterController>, global::FrooxEngine.CharacterController> _characterController_Element = new();
public global::System.String __legacyName { get => __legacyName_Element.Data; set => __legacyName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> __legacyName_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Turn", Turn.ToLinkSyncObject(context));
members.Add("Archetype", Archetype_Element.ToLinkField(context));
members.Add("MinInitializationDelay", MinInitializationDelay_Element.ToLinkField(context));
members.Add("MaxInitializationDelay", MaxInitializationDelay_Element.ToLinkField(context));
members.Add("InitializationColliderRoot", InitializationColliderRoot_Element.ToLinkReference(context));
members.Add("UseSpeedFromUserSettings", UseSpeedFromUserSettings_Element.ToLinkField(context));
members.Add("Description", Description_Element.ToLinkField(context));
members.Add("Mode", Mode_Element.ToLinkField(context));
members.Add("Gripping", Gripping_Element.ToLinkField(context));
members.Add("GripOnHold", GripOnHold_Element.ToLinkField(context));
members.Add("GripRadius", GripRadius_Element.ToLinkField(context));
members.Add("GripVelocityMultiplier", GripVelocityMultiplier_Element.ToLinkField(context));
members.Add("GripHandRotationMode", GripHandRotationMode_Element.ToLinkField(context));
members.Add("GripObjectRotationMode", GripObjectRotationMode_Element.ToLinkField(context));
members.Add("HandGripRotationSmoothSpeed", HandGripRotationSmoothSpeed_Element.ToLinkField(context));
members.Add("FallRespawnPosition", FallRespawnPosition_Element.ToLinkField(context));
members.Add("MakeGravityCharacterLocal", MakeGravityCharacterLocal_Element.ToLinkField(context));
members.Add("AutoAlignVerticalWithGravitySpeed", AutoAlignVerticalWithGravitySpeed_Element.ToLinkField(context));
members.Add("ManualAlignVerticalWithGravitySpeed", ManualAlignVerticalWithGravitySpeed_Element.ToLinkField(context));
members.Add("AirDecelerationSpeed", AirDecelerationSpeed_Element.ToLinkField(context));
members.Add("GripScaleDelay", GripScaleDelay_Element.ToLinkField(context));
members.Add("AllowCrouch", AllowCrouch_Element.ToLinkField(context));
members.Add("MaximumNormalizedSpeed", MaximumNormalizedSpeed_Element.ToLinkField(context));
members.Add("_defaultIcon", _defaultIcon_Element.ToLinkField(context));
members.Add("_defaultColor", _defaultColor_Element.ToLinkField(context));
members.Add("_characterController", _characterController_Element.ToLinkReference(context));
members.Add("__legacyName", __legacyName_Element.ToLinkField(context));
}

}
}
