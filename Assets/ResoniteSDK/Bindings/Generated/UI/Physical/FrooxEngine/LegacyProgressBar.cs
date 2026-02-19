
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyProgressBar
// Generated on: čtvrtek 19. února 2026 7:58:55
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::System.Boolean IsEnabledField;
public global::System.Single Progress;
public UnityEngine.ColorX BarColorField;
public UnityEngine.ColorX ContainerColorField;
public global::System.Single WidthField;
public global::System.Single HeightField;
public global::System.Single ThicknessField;
public global::System.Single SlantField;
public global::FrooxEngine.BevelStripeMesh _barMesh;
public global::FrooxEngine.BevelStripeMesh _containerMesh;
public global::FrooxEngine.PBS_RimMetallic _barMaterial;
public global::FrooxEngine.PBS_RimMetallic _containerMaterial;
public global::FrooxEngine.IField<UnityEngine.Vector3> _barPosition;
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderSize;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsEnabledField", IsEnabledField.ToResoniteLinkField());
members.Add("Progress", Progress.ToResoniteLinkField());
members.Add("BarColorField", BarColorField.ToResoniteLinkField());
members.Add("ContainerColorField", ContainerColorField.ToResoniteLinkField());
members.Add("WidthField", WidthField.ToResoniteLinkField());
members.Add("HeightField", HeightField.ToResoniteLinkField());
members.Add("ThicknessField", ThicknessField.ToResoniteLinkField());
members.Add("SlantField", SlantField.ToResoniteLinkField());
members.Add("_barMesh", _barMesh.ToResoniteReference(context));
members.Add("_containerMesh", _containerMesh.ToResoniteReference(context));
members.Add("_barMaterial", _barMaterial.ToResoniteReference(context));
members.Add("_containerMaterial", _containerMaterial.ToResoniteReference(context));
members.Add("_barPosition", _barPosition.ToResoniteReference(context));
members.Add("_colliderSize", _colliderSize.ToResoniteReference(context));
}

}
}
