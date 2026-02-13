
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyProgressBar
// Generated on: pátek 13. února 2026 5:51:10
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("IsEnabledField", IsEnabledField.ToResoniteLinkField());
members.Add("Progress", Progress.ToResoniteLinkField());
members.Add("BarColorField", BarColorField.ToResoniteLinkField());
members.Add("ContainerColorField", ContainerColorField.ToResoniteLinkField());
members.Add("WidthField", WidthField.ToResoniteLinkField());
members.Add("HeightField", HeightField.ToResoniteLinkField());
members.Add("ThicknessField", ThicknessField.ToResoniteLinkField());
members.Add("SlantField", SlantField.ToResoniteLinkField());
members.Add("_barMesh", new ResoniteLink.Reference() { });
members.Add("_containerMesh", new ResoniteLink.Reference() { });
members.Add("_barMaterial", new ResoniteLink.Reference() { });
members.Add("_containerMaterial", new ResoniteLink.Reference() { });
members.Add("_barPosition", new ResoniteLink.Reference() { });
members.Add("_colliderSize", new ResoniteLink.Reference() { });
}

}
}
