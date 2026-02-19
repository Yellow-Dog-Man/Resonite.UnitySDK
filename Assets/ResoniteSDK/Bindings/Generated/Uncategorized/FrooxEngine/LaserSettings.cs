
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LaserSettings
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LaserSettings")]
public partial class LaserSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.LaserSettings>

{
    public global::System.Single SmoothSpeed;
public global::System.Single ModulateStartAngle;
public global::System.Single ModulateEndAngle;
public global::System.Single ModulateExponent;
public global::System.Single ModulateSpeedMultiplier;
public global::System.Single StickThreshold;
public global::System.Boolean ShowInDesktop;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SmoothSpeed", SmoothSpeed.ToResoniteLinkField());
members.Add("ModulateStartAngle", ModulateStartAngle.ToResoniteLinkField());
members.Add("ModulateEndAngle", ModulateEndAngle.ToResoniteLinkField());
members.Add("ModulateExponent", ModulateExponent.ToResoniteLinkField());
members.Add("ModulateSpeedMultiplier", ModulateSpeedMultiplier.ToResoniteLinkField());
members.Add("StickThreshold", StickThreshold.ToResoniteLinkField());
members.Add("ShowInDesktop", ShowInDesktop.ToResoniteLinkField());
}

}
}
