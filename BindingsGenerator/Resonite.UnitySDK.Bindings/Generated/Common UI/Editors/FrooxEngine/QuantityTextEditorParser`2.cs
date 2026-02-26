
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.QuantityTextEditorParser<,>
// Generated on: čtvrtek 26. února 2026 12:26:53
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.QuantityTextEditorParser<,>")]
public partial class QuantityTextEditorParser<U,T> : global::FrooxEngine.TextEditorParser<T>
	
	where U : struct, global::Elements.Quantity.IQuantity<U>

{
    public T MinValue { get => MinValue_Element.Data; set => MinValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> MinValue_Element = new();
public T MaxValue { get => MaxValue_Element.Data; set => MaxValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> MaxValue_Element = new();
public global::System.Boolean IgnoreOutOfRange { get => IgnoreOutOfRange_Element.Data; set => IgnoreOutOfRange_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IgnoreOutOfRange_Element = new();
public global::System.String DefaultUnit { get => DefaultUnit_Element.Data; set => DefaultUnit_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> DefaultUnit_Element = new();
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
members.Add("MinValue", MinValue_Element.ToLinkField(context));
members.Add("MaxValue", MaxValue_Element.ToLinkField(context));
members.Add("IgnoreOutOfRange", IgnoreOutOfRange_Element.ToLinkField(context));
members.Add("DefaultUnit", DefaultUnit_Element.ToLinkField(context));
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
