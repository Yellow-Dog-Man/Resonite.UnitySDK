
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TeleportLocomotion
// Generated on: úterý 24. února 2026 18:17:51
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::FrooxEngine.TurnSubmodule Turn;
public global::System.Single BackstepDistance;
public global::System.Single ActivationTime;
public global::System.Single HeightInputMax;
public global::System.Single HeightInputMin;
public global::System.Single InitialForceMin;
public global::System.Single InitialForceMax;
public global::System.Single RangeExp;
public global::System.Single StepUnit;
public global::System.Single Drag;
public global::System.Single MaxSmallObjectSize;
public global::System.Single WallDistance;
public global::FrooxEngine.BallisticPathMesh _pathMesh;
public global::FrooxEngine.PBS_RimMetallic _pathMaterial;
public global::FrooxEngine.MeshRenderer _pathRenderer;
public global::FrooxEngine.Slot _pathVisual;
public global::FrooxEngine.Slot _targetPointVisual;
public global::FrooxEngine.CharacterController _characterController;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Turn", new ResoniteLink.SyncObject() { Members = Turn.CollectMembers(context) });
members.Add("BackstepDistance", BackstepDistance.ToResoniteLinkField());
members.Add("ActivationTime", ActivationTime.ToResoniteLinkField());
members.Add("HeightInputMax", HeightInputMax.ToResoniteLinkField());
members.Add("HeightInputMin", HeightInputMin.ToResoniteLinkField());
members.Add("InitialForceMin", InitialForceMin.ToResoniteLinkField());
members.Add("InitialForceMax", InitialForceMax.ToResoniteLinkField());
members.Add("RangeExp", RangeExp.ToResoniteLinkField());
members.Add("StepUnit", StepUnit.ToResoniteLinkField());
members.Add("Drag", Drag.ToResoniteLinkField());
members.Add("MaxSmallObjectSize", MaxSmallObjectSize.ToResoniteLinkField());
members.Add("WallDistance", WallDistance.ToResoniteLinkField());
members.Add("_pathMesh", _pathMesh.ToResoniteReference(context));
members.Add("_pathMaterial", _pathMaterial.ToResoniteReference(context));
members.Add("_pathRenderer", _pathRenderer.ToResoniteReference(context));
members.Add("_pathVisual", _pathVisual.ToResoniteReference(context));
members.Add("_targetPointVisual", _targetPointVisual.ToResoniteReference(context));
members.Add("_characterController", _characterController.ToResoniteReference(context));
}

}
}
