
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldGrabMover
// Generated on: čtvrtek 26. února 2026 15:09:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldGrabMover")]
public partial class WorldGrabMover : global::FrooxEngine.Component

{
    public global::System.Single ShowLerp { get => ShowLerp_Element.Data; set => ShowLerp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ShowLerp_Element = new();
public global::FrooxEngine.User _activatingUser { get => _activatingUser_Element.Data; set => _activatingUser_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> _activatingUser_Element = new();
public global::FrooxEngine.CrossMesh _crossMesh { get => _crossMesh_Element.Data; set => _crossMesh_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.CrossMesh>, global::FrooxEngine.CrossMesh> _crossMesh_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _visualVisible { get => _visualVisible_Element.Data; set => _visualVisible_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _visualVisible_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _visualRotation { get => _visualRotation_Element.Data; set => _visualRotation_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _visualRotation_Element = new();
public global::FrooxEngine.PBS_RimMetallic _material { get => _material_Element.Data; set => _material_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.PBS_RimMetallic>, global::FrooxEngine.PBS_RimMetallic> _material_Element = new();
public UnityEngine.Vector3 _referencePosition { get => _referencePosition_Element.Data; set => _referencePosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> _referencePosition_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ShowLerp", ShowLerp_Element.ToLinkField(context));
members.Add("_activatingUser", _activatingUser_Element.ToLinkReference(context));
members.Add("_crossMesh", _crossMesh_Element.ToLinkReference(context));
members.Add("_visualVisible", _visualVisible_Element.ToLinkReference(context));
members.Add("_visualRotation", _visualRotation_Element.ToLinkReference(context));
members.Add("_material", _material_Element.ToLinkReference(context));
members.Add("_referencePosition", _referencePosition_Element.ToLinkField(context));
}

}
}
