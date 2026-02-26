
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyGlowCircle
// Generated on: čtvrtek 26. února 2026 10:04:39
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyGlowCircle")]
public partial class LegacyGlowCircle : global::FrooxEngine.Component

{
    public global::System.Single Radius { get => Radius_Element.Data; set => Radius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Radius_Element = new();
public global::System.Single Height { get => Height_Element.Data; set => Height_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Height_Element = new();
public UnityEngine.ColorX Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _cylinderOffset { get => _cylinderOffset_Element.Data; set => _cylinderOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _cylinderOffset_Element = new();
public global::FrooxEngine.IField<global::System.Single> _cylinderRadius { get => _cylinderRadius_Element.Data; set => _cylinderRadius_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _cylinderRadius_Element = new();
public global::FrooxEngine.IField<global::System.Single> _cylinderHeight { get => _cylinderHeight_Element.Data; set => _cylinderHeight_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _cylinderHeight_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _circleQuadSize { get => _circleQuadSize_Element.Data; set => _circleQuadSize_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _circleQuadSize_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _circleTint { get => _circleTint_Element.Data; set => _circleTint_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _circleTint_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _cylinderTint { get => _cylinderTint_Element.Data; set => _cylinderTint_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _cylinderTint_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius_Element.Data.ToResoniteLinkField());
members.Add("Height", Height_Element.Data.ToResoniteLinkField());
members.Add("Color", Color_Element.Data.ToResoniteLinkField());
members.Add("_cylinderOffset", _cylinderOffset_Element.Data.ToResoniteReference(context));
members.Add("_cylinderRadius", _cylinderRadius_Element.Data.ToResoniteReference(context));
members.Add("_cylinderHeight", _cylinderHeight_Element.Data.ToResoniteReference(context));
members.Add("_circleQuadSize", _circleQuadSize_Element.Data.ToResoniteReference(context));
members.Add("_circleTint", _circleTint_Element.Data.ToResoniteReference(context));
members.Add("_cylinderTint", _cylinderTint_Element.Data.ToResoniteReference(context));
}

}
}
