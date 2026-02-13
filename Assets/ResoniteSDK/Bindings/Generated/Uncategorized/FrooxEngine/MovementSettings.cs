
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MovementSettings
// Generated on: pátek 13. února 2026 23:23:16
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MovementSettings")]
public partial class MovementSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.MovementSettings>

{
    public global::FrooxEngine.SidewaysMovementMode LeftSidewaysMode;
public global::FrooxEngine.SidewaysMovementMode RightSidewaysMode;
public global::System.Boolean UseHeadDirectionForMovement;
public global::System.Boolean UseSmoothTurn;
public global::System.Boolean SmoothTurnExclusiveMode;
public global::System.Single SmoothTurnSpeed;
public global::System.Single SnapTurnAngle;
public global::System.Single NoClipSpeed;
public global::System.Single MovementDeadzone;
public global::System.Single TurningDeadzone;
public global::System.Single MovementExponent;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("LeftSidewaysMode", LeftSidewaysMode.ToResoniteLinkField());
members.Add("RightSidewaysMode", RightSidewaysMode.ToResoniteLinkField());
members.Add("UseHeadDirectionForMovement", UseHeadDirectionForMovement.ToResoniteLinkField());
members.Add("UseSmoothTurn", UseSmoothTurn.ToResoniteLinkField());
members.Add("SmoothTurnExclusiveMode", SmoothTurnExclusiveMode.ToResoniteLinkField());
members.Add("SmoothTurnSpeed", SmoothTurnSpeed.ToResoniteLinkField());
members.Add("SnapTurnAngle", SnapTurnAngle.ToResoniteLinkField());
members.Add("NoClipSpeed", NoClipSpeed.ToResoniteLinkField());
members.Add("MovementDeadzone", MovementDeadzone.ToResoniteLinkField());
members.Add("TurningDeadzone", TurningDeadzone.ToResoniteLinkField());
members.Add("MovementExponent", MovementExponent.ToResoniteLinkField());
}

}
}
