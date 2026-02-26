
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabWorldLocomotion
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GrabWorldLocomotion")]
public partial class GrabWorldLocomotion : global::FrooxEngine.LocomotionModule

{
    public global::FrooxEngine.TurnSubmodule Turn = new();
public global::System.Single ActivationThreshold { get => ActivationThreshold_Element.Data; set => ActivationThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ActivationThreshold_Element = new();
public global::System.Single DeactivationThreshold { get => DeactivationThreshold_Element.Data; set => DeactivationThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DeactivationThreshold_Element = new();
public global::FrooxEngine.Slot _visual { get => _visual_Element.Data; set => _visual_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _visual_Element = new();
public global::FrooxEngine.CrossMesh _crossMesh { get => _crossMesh_Element.Data; set => _crossMesh_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CrossMesh>, global::FrooxEngine.CrossMesh> _crossMesh_Element = new();
public global::FrooxEngine.PBS_RimMetallic _material { get => _material_Element.Data; set => _material_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.PBS_RimMetallic>, global::FrooxEngine.PBS_RimMetallic> _material_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Turn", Turn.ToLinkSyncObject(context));
members.Add("ActivationThreshold", ActivationThreshold_Element.ToLinkField(context));
members.Add("DeactivationThreshold", DeactivationThreshold_Element.ToLinkField(context));
members.Add("_visual", _visual_Element.ToLinkReference(context));
members.Add("_crossMesh", _crossMesh_Element.ToLinkReference(context));
members.Add("_material", _material_Element.ToLinkReference(context));
}

}
}
