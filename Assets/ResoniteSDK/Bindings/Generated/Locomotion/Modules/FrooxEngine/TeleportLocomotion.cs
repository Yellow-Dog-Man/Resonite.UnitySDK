
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TeleportLocomotion
// Generated on: pátek 13. února 2026 5:51:14
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Turn", new ResoniteLink.SyncObject() { Members = Turn.CollectMembers() });
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
members.Add("_pathMesh", new ResoniteLink.Reference() { });
members.Add("_pathMaterial", new ResoniteLink.Reference() { });
members.Add("_pathRenderer", new ResoniteLink.Reference() { });
members.Add("_pathVisual", new ResoniteLink.Reference() { });
members.Add("_targetPointVisual", new ResoniteLink.Reference() { });
members.Add("_characterController", new ResoniteLink.Reference() { });
}

}
}
