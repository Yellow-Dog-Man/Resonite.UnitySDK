
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HapticPointMapping
// Generated on: čtvrtek 26. února 2026 12:28:11
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HapticPointMapping")]
public partial class HapticPointMapping : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.HapticPositionType MappingTarget { get => MappingTarget_Element.Data; set => MappingTarget_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.HapticPositionType>, global::FrooxEngine.HapticPositionType> MappingTarget_Element = new();
public global::System.Single PointRadius { get => PointRadius_Element.Data; set => PointRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PointRadius_Element = new();
public global::FrooxEngine.TorsoSide TorsoSide { get => TorsoSide_Element.Data; set => TorsoSide_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.TorsoSide>, global::FrooxEngine.TorsoSide> TorsoSide_Element = new();
public global::System.Single TorsoHorizontalPosition { get => TorsoHorizontalPosition_Element.Data; set => TorsoHorizontalPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TorsoHorizontalPosition_Element = new();
public global::System.Single TorsoVerticalPosition { get => TorsoVerticalPosition_Element.Data; set => TorsoVerticalPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TorsoVerticalPosition_Element = new();
public global::System.Single HeadPitchAngle { get => HeadPitchAngle_Element.Data; set => HeadPitchAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadPitchAngle_Element = new();
public global::System.Single HeadYawAngle { get => HeadYawAngle_Element.Data; set => HeadYawAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadYawAngle_Element = new();
public global::Renderite.Shared.Chirality ArmSide { get => ArmSide_Element.Data; set => ArmSide_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.Chirality>, global::Renderite.Shared.Chirality> ArmSide_Element = new();
public global::System.Single ArmPositionAlong { get => ArmPositionAlong_Element.Data; set => ArmPositionAlong_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ArmPositionAlong_Element = new();
public global::System.Single ArmAngleAround { get => ArmAngleAround_Element.Data; set => ArmAngleAround_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ArmAngleAround_Element = new();
public global::Renderite.Shared.Chirality LegSide { get => LegSide_Element.Data; set => LegSide_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.Chirality>, global::Renderite.Shared.Chirality> LegSide_Element = new();
public global::System.Single LegPositionAlong { get => LegPositionAlong_Element.Data; set => LegPositionAlong_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LegPositionAlong_Element = new();
public global::System.Single LegAngleAround { get => LegAngleAround_Element.Data; set => LegAngleAround_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LegAngleAround_Element = new();
public global::Renderite.Shared.Chirality ControllerSide { get => ControllerSide_Element.Data; set => ControllerSide_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.Chirality>, global::Renderite.Shared.Chirality> ControllerSide_Element = new();
public global::System.String Tag { get => Tag_Element.Data; set => Tag_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Tag_Element = new();
public global::System.Boolean ShowAnyOptions { get => ShowAnyOptions_Element.Data; set => ShowAnyOptions_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowAnyOptions_Element = new();
public global::System.Boolean ShowTorsoOptions { get => ShowTorsoOptions_Element.Data; set => ShowTorsoOptions_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowTorsoOptions_Element = new();
public global::System.Boolean ShowHeadOptions { get => ShowHeadOptions_Element.Data; set => ShowHeadOptions_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowHeadOptions_Element = new();
public global::System.Boolean ShowArmOptions { get => ShowArmOptions_Element.Data; set => ShowArmOptions_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowArmOptions_Element = new();
public global::System.Boolean ShowLegOptions { get => ShowLegOptions_Element.Data; set => ShowLegOptions_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowLegOptions_Element = new();
public global::System.Boolean ShowControllerOptions { get => ShowControllerOptions_Element.Data; set => ShowControllerOptions_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowControllerOptions_Element = new();
public global::System.Boolean ShowTagPositions { get => ShowTagPositions_Element.Data; set => ShowTagPositions_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowTagPositions_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MappingTarget", MappingTarget_Element.ToLinkField(context));
members.Add("PointRadius", PointRadius_Element.ToLinkField(context));
members.Add("TorsoSide", TorsoSide_Element.ToLinkField(context));
members.Add("TorsoHorizontalPosition", TorsoHorizontalPosition_Element.ToLinkField(context));
members.Add("TorsoVerticalPosition", TorsoVerticalPosition_Element.ToLinkField(context));
members.Add("HeadPitchAngle", HeadPitchAngle_Element.ToLinkField(context));
members.Add("HeadYawAngle", HeadYawAngle_Element.ToLinkField(context));
members.Add("ArmSide", ArmSide_Element.ToLinkField(context));
members.Add("ArmPositionAlong", ArmPositionAlong_Element.ToLinkField(context));
members.Add("ArmAngleAround", ArmAngleAround_Element.ToLinkField(context));
members.Add("LegSide", LegSide_Element.ToLinkField(context));
members.Add("LegPositionAlong", LegPositionAlong_Element.ToLinkField(context));
members.Add("LegAngleAround", LegAngleAround_Element.ToLinkField(context));
members.Add("ControllerSide", ControllerSide_Element.ToLinkField(context));
members.Add("Tag", Tag_Element.ToLinkField(context));
members.Add("ShowAnyOptions", ShowAnyOptions_Element.ToLinkField(context));
members.Add("ShowTorsoOptions", ShowTorsoOptions_Element.ToLinkField(context));
members.Add("ShowHeadOptions", ShowHeadOptions_Element.ToLinkField(context));
members.Add("ShowArmOptions", ShowArmOptions_Element.ToLinkField(context));
members.Add("ShowLegOptions", ShowLegOptions_Element.ToLinkField(context));
members.Add("ShowControllerOptions", ShowControllerOptions_Element.ToLinkField(context));
members.Add("ShowTagPositions", ShowTagPositions_Element.ToLinkField(context));
}

}
}
