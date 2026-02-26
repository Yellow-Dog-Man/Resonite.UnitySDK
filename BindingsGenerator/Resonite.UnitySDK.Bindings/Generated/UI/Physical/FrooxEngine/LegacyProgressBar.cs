
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyProgressBar
// Generated on: čtvrtek 26. února 2026 15:07:57
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyProgressBar")]
public partial class LegacyProgressBar : global::FrooxEngine.LegacyUIElement

{
    public global::System.Boolean IsEnabledField { get => IsEnabledField_Element.Data; set => IsEnabledField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsEnabledField_Element = new();
public global::System.Single Progress { get => Progress_Element.Data; set => Progress_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Progress_Element = new();
public UnityEngine.ColorX BarColorField { get => BarColorField_Element.Data; set => BarColorField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> BarColorField_Element = new();
public UnityEngine.ColorX ContainerColorField { get => ContainerColorField_Element.Data; set => ContainerColorField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> ContainerColorField_Element = new();
public global::System.Single WidthField { get => WidthField_Element.Data; set => WidthField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> WidthField_Element = new();
public global::System.Single HeightField { get => HeightField_Element.Data; set => HeightField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeightField_Element = new();
public global::System.Single ThicknessField { get => ThicknessField_Element.Data; set => ThicknessField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ThicknessField_Element = new();
public global::System.Single SlantField { get => SlantField_Element.Data; set => SlantField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SlantField_Element = new();
public global::FrooxEngine.BevelStripeMesh _barMesh { get => _barMesh_Element.Data; set => _barMesh_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.BevelStripeMesh>, global::FrooxEngine.BevelStripeMesh> _barMesh_Element = new();
public global::FrooxEngine.BevelStripeMesh _containerMesh { get => _containerMesh_Element.Data; set => _containerMesh_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.BevelStripeMesh>, global::FrooxEngine.BevelStripeMesh> _containerMesh_Element = new();
public global::FrooxEngine.PBS_RimMetallic _barMaterial { get => _barMaterial_Element.Data; set => _barMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.PBS_RimMetallic>, global::FrooxEngine.PBS_RimMetallic> _barMaterial_Element = new();
public global::FrooxEngine.PBS_RimMetallic _containerMaterial { get => _containerMaterial_Element.Data; set => _containerMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.PBS_RimMetallic>, global::FrooxEngine.PBS_RimMetallic> _containerMaterial_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _barPosition { get => _barPosition_Element.Data; set => _barPosition_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _barPosition_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderSize { get => _colliderSize_Element.Data; set => _colliderSize_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _colliderSize_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsEnabledField", IsEnabledField_Element.ToLinkField(context));
members.Add("Progress", Progress_Element.ToLinkField(context));
members.Add("BarColorField", BarColorField_Element.ToLinkField(context));
members.Add("ContainerColorField", ContainerColorField_Element.ToLinkField(context));
members.Add("WidthField", WidthField_Element.ToLinkField(context));
members.Add("HeightField", HeightField_Element.ToLinkField(context));
members.Add("ThicknessField", ThicknessField_Element.ToLinkField(context));
members.Add("SlantField", SlantField_Element.ToLinkField(context));
members.Add("_barMesh", _barMesh_Element.ToLinkReference(context));
members.Add("_containerMesh", _containerMesh_Element.ToLinkReference(context));
members.Add("_barMaterial", _barMaterial_Element.ToLinkReference(context));
members.Add("_containerMaterial", _containerMaterial_Element.ToLinkReference(context));
members.Add("_barPosition", _barPosition_Element.ToLinkReference(context));
members.Add("_colliderSize", _colliderSize_Element.ToLinkReference(context));
}

}
}
