
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserPoseController
// Generated on: čtvrtek 26. února 2026 15:09:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserPoseController")]
public partial class UserPoseController : global::FrooxEngine.UserRootComponent

{
    public global::FrooxEngine.ScreenController ScreenController { get => ScreenController_Element.Data; set => ScreenController_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ScreenController>, global::FrooxEngine.ScreenController> ScreenController_Element = new();
public global::System.Single BodyHorizontalAngle { get => BodyHorizontalAngle_Element.Data; set => BodyHorizontalAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BodyHorizontalAngle_Element = new();
public global::System.Boolean RenderDebugVisuals { get => RenderDebugVisuals_Element.Data; set => RenderDebugVisuals_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RenderDebugVisuals_Element = new();
public global::System.Boolean PauseLocomotionAnimation { get => PauseLocomotionAnimation_Element.Data; set => PauseLocomotionAnimation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PauseLocomotionAnimation_Element = new();
public global::System.Nullable<UnityEngine.Vector3> OverrideLocomotionVelocity { get => OverrideLocomotionVelocity_Element.Data; set => OverrideLocomotionVelocity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector3>>, global::System.Nullable<UnityEngine.Vector3>> OverrideLocomotionVelocity_Element = new();
public global::System.Nullable<global::System.Single> OverrideLocomotionAngularVelocity { get => OverrideLocomotionAngularVelocity_Element.Data; set => OverrideLocomotionAngularVelocity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> OverrideLocomotionAngularVelocity_Element = new();
public global::System.Single SimulationSpeedRatio { get => SimulationSpeedRatio_Element.Data; set => SimulationSpeedRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SimulationSpeedRatio_Element = new();
public global::FrooxEngine.LocomotionAnimationConfiguration _defaultConfig { get => _defaultConfig_Element.Data; set => _defaultConfig_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.LocomotionAnimationConfiguration>, global::FrooxEngine.LocomotionAnimationConfiguration> _defaultConfig_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ScreenController", ScreenController_Element.ToLinkReference(context));
members.Add("BodyHorizontalAngle", BodyHorizontalAngle_Element.ToLinkField(context));
members.Add("RenderDebugVisuals", RenderDebugVisuals_Element.ToLinkField(context));
members.Add("PauseLocomotionAnimation", PauseLocomotionAnimation_Element.ToLinkField(context));
members.Add("OverrideLocomotionVelocity", OverrideLocomotionVelocity_Element.ToLinkField(context));
members.Add("OverrideLocomotionAngularVelocity", OverrideLocomotionAngularVelocity_Element.ToLinkField(context));
members.Add("SimulationSpeedRatio", SimulationSpeedRatio_Element.ToLinkField(context));
members.Add("_defaultConfig", _defaultConfig_Element.ToLinkReference(context));
}

}
}
