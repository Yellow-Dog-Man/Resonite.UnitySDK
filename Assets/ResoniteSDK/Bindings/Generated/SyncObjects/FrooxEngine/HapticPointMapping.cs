
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HapticPointMapping
// Generated on: sobota 14. února 2026 8:58:44
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HapticPointMapping")]
public partial class HapticPointMapping : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.HapticPositionType MappingTarget;
public global::System.Single PointRadius;
public global::FrooxEngine.TorsoSide TorsoSide;
public global::System.Single TorsoHorizontalPosition;
public global::System.Single TorsoVerticalPosition;
public global::System.Single HeadPitchAngle;
public global::System.Single HeadYawAngle;
public global::Renderite.Shared.Chirality ArmSide;
public global::System.Single ArmPositionAlong;
public global::System.Single ArmAngleAround;
public global::Renderite.Shared.Chirality LegSide;
public global::System.Single LegPositionAlong;
public global::System.Single LegAngleAround;
public global::Renderite.Shared.Chirality ControllerSide;
public global::System.String Tag;
public global::System.Boolean ShowAnyOptions;
public global::System.Boolean ShowTorsoOptions;
public global::System.Boolean ShowHeadOptions;
public global::System.Boolean ShowArmOptions;
public global::System.Boolean ShowLegOptions;
public global::System.Boolean ShowControllerOptions;
public global::System.Boolean ShowTagPositions;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MappingTarget", MappingTarget.ToResoniteLinkField());
members.Add("PointRadius", PointRadius.ToResoniteLinkField());
members.Add("TorsoSide", TorsoSide.ToResoniteLinkField());
members.Add("TorsoHorizontalPosition", TorsoHorizontalPosition.ToResoniteLinkField());
members.Add("TorsoVerticalPosition", TorsoVerticalPosition.ToResoniteLinkField());
members.Add("HeadPitchAngle", HeadPitchAngle.ToResoniteLinkField());
members.Add("HeadYawAngle", HeadYawAngle.ToResoniteLinkField());
members.Add("ArmSide", ArmSide.ToResoniteLinkField());
members.Add("ArmPositionAlong", ArmPositionAlong.ToResoniteLinkField());
members.Add("ArmAngleAround", ArmAngleAround.ToResoniteLinkField());
members.Add("LegSide", LegSide.ToResoniteLinkField());
members.Add("LegPositionAlong", LegPositionAlong.ToResoniteLinkField());
members.Add("LegAngleAround", LegAngleAround.ToResoniteLinkField());
members.Add("ControllerSide", ControllerSide.ToResoniteLinkField());
members.Add("Tag", Tag.ToResoniteLinkField());
members.Add("ShowAnyOptions", ShowAnyOptions.ToResoniteLinkField());
members.Add("ShowTorsoOptions", ShowTorsoOptions.ToResoniteLinkField());
members.Add("ShowHeadOptions", ShowHeadOptions.ToResoniteLinkField());
members.Add("ShowArmOptions", ShowArmOptions.ToResoniteLinkField());
members.Add("ShowLegOptions", ShowLegOptions.ToResoniteLinkField());
members.Add("ShowControllerOptions", ShowControllerOptions.ToResoniteLinkField());
members.Add("ShowTagPositions", ShowTagPositions.ToResoniteLinkField());
}

}
}
