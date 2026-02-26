
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyGlowingSphereToggle
// Generated on: čtvrtek 26. února 2026 10:04:46
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyGlowingSphereToggle")]
public partial class LegacyGlowingSphereToggle : global::FrooxEngine.Component, global::FrooxEngine.ITouchable

{
    public global::FrooxEngine.IField<global::System.Boolean> TargetField { get => TargetField_Element.Data; set => TargetField_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> TargetField_Element = new();
public global::System.Single FadeSpeed { get => FadeSpeed_Element.Data; set => FadeSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FadeSpeed_Element = new();
public global::System.Single CooldownTime { get => CooldownTime_Element.Data; set => CooldownTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CooldownTime_Element = new();
public global::System.Single Radius { get => Radius_Element.Data; set => Radius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Radius_Element = new();
public UnityEngine.ColorX GlowColor { get => GlowColor_Element.Data; set => GlowColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> GlowColor_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _emissiveColor { get => _emissiveColor_Element.Data; set => _emissiveColor_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _emissiveColor_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _rimColor { get => _rimColor_Element.Data; set => _rimColor_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _rimColor_Element = new();
public global::FrooxEngine.IField<global::System.Single> _sphereRadius { get => _sphereRadius_Element.Data; set => _sphereRadius_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _sphereRadius_Element = new();
public global::FrooxEngine.IField<global::System.Single> _sphereExtrude { get => _sphereExtrude_Element.Data; set => _sphereExtrude_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _sphereExtrude_Element = new();
public global::FrooxEngine.IField<global::System.Single> _colliderRadius { get => _colliderRadius_Element.Data; set => _colliderRadius_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _colliderRadius_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetField", TargetField_Element.Data.ToResoniteReference(context));
members.Add("FadeSpeed", FadeSpeed_Element.Data.ToResoniteLinkField());
members.Add("CooldownTime", CooldownTime_Element.Data.ToResoniteLinkField());
members.Add("Radius", Radius_Element.Data.ToResoniteLinkField());
members.Add("GlowColor", GlowColor_Element.Data.ToResoniteLinkField());
members.Add("_emissiveColor", _emissiveColor_Element.Data.ToResoniteReference(context));
members.Add("_rimColor", _rimColor_Element.Data.ToResoniteReference(context));
members.Add("_sphereRadius", _sphereRadius_Element.Data.ToResoniteReference(context));
members.Add("_sphereExtrude", _sphereExtrude_Element.Data.ToResoniteReference(context));
members.Add("_colliderRadius", _colliderRadius_Element.Data.ToResoniteReference(context));
}

}
}
