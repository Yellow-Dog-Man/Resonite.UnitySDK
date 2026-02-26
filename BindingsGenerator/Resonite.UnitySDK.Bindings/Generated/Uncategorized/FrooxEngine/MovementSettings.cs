
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MovementSettings
// Generated on: čtvrtek 26. února 2026 15:09:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MovementSettings")]
public partial class MovementSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.MovementSettings>

{
    public global::FrooxEngine.SidewaysMovementMode LeftSidewaysMode { get => LeftSidewaysMode_Element.Data; set => LeftSidewaysMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.SidewaysMovementMode>, global::FrooxEngine.SidewaysMovementMode> LeftSidewaysMode_Element = new();
public global::FrooxEngine.SidewaysMovementMode RightSidewaysMode { get => RightSidewaysMode_Element.Data; set => RightSidewaysMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.SidewaysMovementMode>, global::FrooxEngine.SidewaysMovementMode> RightSidewaysMode_Element = new();
public global::System.Boolean UseHeadDirectionForMovement { get => UseHeadDirectionForMovement_Element.Data; set => UseHeadDirectionForMovement_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseHeadDirectionForMovement_Element = new();
public global::System.Boolean UseSmoothTurn { get => UseSmoothTurn_Element.Data; set => UseSmoothTurn_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseSmoothTurn_Element = new();
public global::System.Boolean SmoothTurnExclusiveMode { get => SmoothTurnExclusiveMode_Element.Data; set => SmoothTurnExclusiveMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SmoothTurnExclusiveMode_Element = new();
public global::System.Single SmoothTurnSpeed { get => SmoothTurnSpeed_Element.Data; set => SmoothTurnSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SmoothTurnSpeed_Element = new();
public global::System.Single SnapTurnAngle { get => SnapTurnAngle_Element.Data; set => SnapTurnAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SnapTurnAngle_Element = new();
public global::System.Single NoClipSpeed { get => NoClipSpeed_Element.Data; set => NoClipSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NoClipSpeed_Element = new();
public global::System.Single MovementDeadzone { get => MovementDeadzone_Element.Data; set => MovementDeadzone_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MovementDeadzone_Element = new();
public global::System.Single TurningDeadzone { get => TurningDeadzone_Element.Data; set => TurningDeadzone_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TurningDeadzone_Element = new();
public global::System.Single MovementExponent { get => MovementExponent_Element.Data; set => MovementExponent_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MovementExponent_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LeftSidewaysMode", LeftSidewaysMode_Element.ToLinkField(context));
members.Add("RightSidewaysMode", RightSidewaysMode_Element.ToLinkField(context));
members.Add("UseHeadDirectionForMovement", UseHeadDirectionForMovement_Element.ToLinkField(context));
members.Add("UseSmoothTurn", UseSmoothTurn_Element.ToLinkField(context));
members.Add("SmoothTurnExclusiveMode", SmoothTurnExclusiveMode_Element.ToLinkField(context));
members.Add("SmoothTurnSpeed", SmoothTurnSpeed_Element.ToLinkField(context));
members.Add("SnapTurnAngle", SnapTurnAngle_Element.ToLinkField(context));
members.Add("NoClipSpeed", NoClipSpeed_Element.ToLinkField(context));
members.Add("MovementDeadzone", MovementDeadzone_Element.ToLinkField(context));
members.Add("TurningDeadzone", TurningDeadzone_Element.ToLinkField(context));
members.Add("MovementExponent", MovementExponent_Element.ToLinkField(context));
}

}
}
