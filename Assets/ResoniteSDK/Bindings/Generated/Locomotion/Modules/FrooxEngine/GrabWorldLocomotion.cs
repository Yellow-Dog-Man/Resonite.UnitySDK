
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabWorldLocomotion
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GrabWorldLocomotion")]
public partial class GrabWorldLocomotion : global::FrooxEngine.LocomotionModule

{
    public global::FrooxEngine.TurnSubmodule Turn;
public global::System.Single ActivationThreshold;
public global::System.Single DeactivationThreshold;
public global::FrooxEngine.Slot _visual;
public global::FrooxEngine.CrossMesh _crossMesh;
public global::FrooxEngine.PBS_RimMetallic _material;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Turn", new ResoniteLink.SyncObject() { Members = Turn.CollectMembers(context) });
members.Add("ActivationThreshold", ActivationThreshold.ToResoniteLinkField());
members.Add("DeactivationThreshold", DeactivationThreshold.ToResoniteLinkField());
members.Add("_visual", _visual.ToResoniteReference(context));
members.Add("_crossMesh", _crossMesh.ToResoniteReference(context));
members.Add("_material", _material.ToResoniteReference(context));
}

}
}
