
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TeleportLocomotion
// Generated on: čtvrtek 26. února 2026 12:26:56
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TeleportLocomotion")]
public partial class TeleportLocomotion : global::FrooxEngine.LocomotionModule

{
    public global::FrooxEngine.TurnSubmodule Turn = new();
public global::System.Single BackstepDistance { get => BackstepDistance_Element.Data; set => BackstepDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BackstepDistance_Element = new();
public global::System.Single ActivationTime { get => ActivationTime_Element.Data; set => ActivationTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ActivationTime_Element = new();
public global::System.Single HeightInputMax { get => HeightInputMax_Element.Data; set => HeightInputMax_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeightInputMax_Element = new();
public global::System.Single HeightInputMin { get => HeightInputMin_Element.Data; set => HeightInputMin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeightInputMin_Element = new();
public global::System.Single InitialForceMin { get => InitialForceMin_Element.Data; set => InitialForceMin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InitialForceMin_Element = new();
public global::System.Single InitialForceMax { get => InitialForceMax_Element.Data; set => InitialForceMax_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InitialForceMax_Element = new();
public global::System.Single RangeExp { get => RangeExp_Element.Data; set => RangeExp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RangeExp_Element = new();
public global::System.Single StepUnit { get => StepUnit_Element.Data; set => StepUnit_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StepUnit_Element = new();
public global::System.Single Drag { get => Drag_Element.Data; set => Drag_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Drag_Element = new();
public global::System.Single MaxSmallObjectSize { get => MaxSmallObjectSize_Element.Data; set => MaxSmallObjectSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxSmallObjectSize_Element = new();
public global::System.Single WallDistance { get => WallDistance_Element.Data; set => WallDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> WallDistance_Element = new();
public global::FrooxEngine.BallisticPathMesh _pathMesh { get => _pathMesh_Element.Data; set => _pathMesh_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.BallisticPathMesh>, global::FrooxEngine.BallisticPathMesh> _pathMesh_Element = new();
public global::FrooxEngine.PBS_RimMetallic _pathMaterial { get => _pathMaterial_Element.Data; set => _pathMaterial_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.PBS_RimMetallic>, global::FrooxEngine.PBS_RimMetallic> _pathMaterial_Element = new();
public global::FrooxEngine.MeshRenderer _pathRenderer { get => _pathRenderer_Element.Data; set => _pathRenderer_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer> _pathRenderer_Element = new();
public global::FrooxEngine.Slot _pathVisual { get => _pathVisual_Element.Data; set => _pathVisual_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _pathVisual_Element = new();
public global::FrooxEngine.Slot _targetPointVisual { get => _targetPointVisual_Element.Data; set => _targetPointVisual_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _targetPointVisual_Element = new();
public global::FrooxEngine.CharacterController _characterController { get => _characterController_Element.Data; set => _characterController_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CharacterController>, global::FrooxEngine.CharacterController> _characterController_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Turn", Turn.ToLinkSyncObject(context));
members.Add("BackstepDistance", BackstepDistance_Element.ToLinkField(context));
members.Add("ActivationTime", ActivationTime_Element.ToLinkField(context));
members.Add("HeightInputMax", HeightInputMax_Element.ToLinkField(context));
members.Add("HeightInputMin", HeightInputMin_Element.ToLinkField(context));
members.Add("InitialForceMin", InitialForceMin_Element.ToLinkField(context));
members.Add("InitialForceMax", InitialForceMax_Element.ToLinkField(context));
members.Add("RangeExp", RangeExp_Element.ToLinkField(context));
members.Add("StepUnit", StepUnit_Element.ToLinkField(context));
members.Add("Drag", Drag_Element.ToLinkField(context));
members.Add("MaxSmallObjectSize", MaxSmallObjectSize_Element.ToLinkField(context));
members.Add("WallDistance", WallDistance_Element.ToLinkField(context));
members.Add("_pathMesh", _pathMesh_Element.ToLinkReference(context));
members.Add("_pathMaterial", _pathMaterial_Element.ToLinkReference(context));
members.Add("_pathRenderer", _pathRenderer_Element.ToLinkReference(context));
members.Add("_pathVisual", _pathVisual_Element.ToLinkReference(context));
members.Add("_targetPointVisual", _targetPointVisual_Element.ToLinkReference(context));
members.Add("_characterController", _characterController_Element.ToLinkReference(context));
}

}
}
