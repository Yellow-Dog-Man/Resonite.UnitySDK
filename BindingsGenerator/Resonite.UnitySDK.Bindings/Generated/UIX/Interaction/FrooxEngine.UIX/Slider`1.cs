
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.Slider<>
// Generated on: čtvrtek 26. února 2026 10:04:43
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.Slider<>")]
public partial class Slider<T> : global::FrooxEngine.UIX.InteractionElement
	

{
    public T Value { get => Value_Element.Data; set => Value_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> Value_Element = new();
public T Min { get => Min_Element.Data; set => Min_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> Min_Element = new();
public T Max { get => Max_Element.Data; set => Max_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> Max_Element = new();
public global::System.Boolean Integers { get => Integers_Element.Data; set => Integers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Integers_Element = new();
public global::System.Boolean MaxIsExclusive { get => MaxIsExclusive_Element.Data; set => MaxIsExclusive_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MaxIsExclusive_Element = new();
public global::System.Single Power { get => Power_Element.Data; set => Power_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Power_Element = new();
public global::System.Boolean Clamp { get => Clamp_Element.Data; set => Clamp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Clamp_Element = new();
public T VibrationThreshold { get => VibrationThreshold_Element.Data; set => VibrationThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> VibrationThreshold_Element = new();
public global::FrooxEngine.UIX.Slider<T>.Direction SlideDirection { get => SlideDirection_Element.Data; set => SlideDirection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UIX.Slider<T>.Direction>, global::FrooxEngine.UIX.Slider<T>.Direction> SlideDirection_Element = new();
public UnityEngine.Vector2 AnchorOffset { get => AnchorOffset_Element.Data; set => AnchorOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> AnchorOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> HandleAnchorMinDrive { get => HandleAnchorMinDrive_Element.Data; set => HandleAnchorMinDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> HandleAnchorMinDrive_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> HandleAnchorMaxDrive { get => HandleAnchorMaxDrive_Element.Data; set => HandleAnchorMaxDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> HandleAnchorMaxDrive_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> FillLineDrive { get => FillLineDrive_Element.Data; set => FillLineDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> FillLineDrive_Element = new();
public global::System.Boolean RequireLockInToInteract { get => RequireLockInToInteract_Element.Data; set => RequireLockInToInteract_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RequireLockInToInteract_Element = new();
public global::System.Boolean RequireInitialPress { get => RequireInitialPress_Element.Data; set => RequireInitialPress_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RequireInitialPress_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value", Value_Element.Data.ToResoniteLinkField());
members.Add("Min", Min_Element.Data.ToResoniteLinkField());
members.Add("Max", Max_Element.Data.ToResoniteLinkField());
members.Add("Integers", Integers_Element.Data.ToResoniteLinkField());
members.Add("MaxIsExclusive", MaxIsExclusive_Element.Data.ToResoniteLinkField());
members.Add("Power", Power_Element.Data.ToResoniteLinkField());
members.Add("Clamp", Clamp_Element.Data.ToResoniteLinkField());
members.Add("VibrationThreshold", VibrationThreshold_Element.Data.ToResoniteLinkField());
members.Add("SlideDirection", SlideDirection_Element.Data.ToResoniteLinkField());
members.Add("AnchorOffset", AnchorOffset_Element.Data.ToResoniteLinkField());
members.Add("HandleAnchorMinDrive", HandleAnchorMinDrive_Element.Data.ToResoniteReference(context));
members.Add("HandleAnchorMaxDrive", HandleAnchorMaxDrive_Element.Data.ToResoniteReference(context));
members.Add("FillLineDrive", FillLineDrive_Element.Data.ToResoniteReference(context));
members.Add("RequireLockInToInteract", RequireLockInToInteract_Element.Data.ToResoniteLinkField());
members.Add("RequireInitialPress", RequireInitialPress_Element.Data.ToResoniteLinkField());
}

}
}
