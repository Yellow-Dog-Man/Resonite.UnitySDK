
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.QuantityTextFormatDriver<>
// Generated on: čtvrtek 26. února 2026 15:09:17
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.QuantityTextFormatDriver<>")]
public partial class QuantityTextFormatDriver<U> : global::FrooxEngine.Component
	where U : struct, global::Elements.Quantity.IQuantity<U>

{
    public global::FrooxEngine.IField<global::System.String> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> Target_Element = new();
public global::System.Double BaseValue { get => BaseValue_Element.Data; set => BaseValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Double>, global::System.Double> BaseValue_Element = new();
public global::System.String FormatUnit { get => FormatUnit_Element.Data; set => FormatUnit_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> FormatUnit_Element = new();
public global::System.String FormatNumber { get => FormatNumber_Element.Data; set => FormatNumber_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> FormatNumber_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::System.String>, global::System.String, Field<global::FrooxEngine.Sync<global::System.String>, global::System.String>> CompoundFormatUnits = new();
public global::System.Boolean CompoundUseLongNames { get => CompoundUseLongNames_Element.Data; set => CompoundUseLongNames_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CompoundUseLongNames_Element = new();
public global::System.Boolean CompoundOverrideNames { get => CompoundOverrideNames_Element.Data; set => CompoundOverrideNames_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CompoundOverrideNames_Element = new();
public global::System.Boolean CompoundDiscardLastFraction { get => CompoundDiscardLastFraction_Element.Data; set => CompoundDiscardLastFraction_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CompoundDiscardLastFraction_Element = new();
public global::System.String CompoundSeparator { get => CompoundSeparator_Element.Data; set => CompoundSeparator_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> CompoundSeparator_Element = new();
public global::Elements.Quantity.CompoundZeroHandling CompoundZeroHandling { get => CompoundZeroHandling_Element.Data; set => CompoundZeroHandling_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Quantity.CompoundZeroHandling>, global::Elements.Quantity.CompoundZeroHandling> CompoundZeroHandling_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("BaseValue", BaseValue_Element.ToLinkField(context));
members.Add("FormatUnit", FormatUnit_Element.ToLinkField(context));
members.Add("FormatNumber", FormatNumber_Element.ToLinkField(context));
members.Add("CompoundFormatUnits", CompoundFormatUnits.ToLinkList(context, m => m.ToLinkField(context)));
members.Add("CompoundUseLongNames", CompoundUseLongNames_Element.ToLinkField(context));
members.Add("CompoundOverrideNames", CompoundOverrideNames_Element.ToLinkField(context));
members.Add("CompoundDiscardLastFraction", CompoundDiscardLastFraction_Element.ToLinkField(context));
members.Add("CompoundSeparator", CompoundSeparator_Element.ToLinkField(context));
members.Add("CompoundZeroHandling", CompoundZeroHandling_Element.ToLinkField(context));
}

}
}
