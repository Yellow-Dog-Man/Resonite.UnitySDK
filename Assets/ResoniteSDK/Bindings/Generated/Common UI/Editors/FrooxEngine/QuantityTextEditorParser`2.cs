
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.QuantityTextEditorParser<,>
// Generated on: sobota 14. února 2026 8:57:04
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.QuantityTextEditorParser<,>")]
public partial class QuantityTextEditorParser<U,T> : global::FrooxEngine.TextEditorParser<T>
	
	where U : struct, global::Elements.Quantity.IQuantity<U>

{
    public T MinValue;
public T MaxValue;
public global::System.Boolean IgnoreOutOfRange;
public global::System.String DefaultUnit;
public global::System.String FormatUnit;
public global::System.String FormatNumber;
public System.Collections.Generic.List<global::System.String> CompoundFormatUnits;
public global::System.Boolean CompoundUseLongNames;
public global::System.Boolean CompoundOverrideNames;
public global::System.Boolean CompoundDiscardLastFraction;
public global::System.String CompoundSeparator;
public global::Elements.Quantity.CompoundZeroHandling CompoundZeroHandling;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinValue", MinValue.ToResoniteLinkField());
members.Add("MaxValue", MaxValue.ToResoniteLinkField());
members.Add("IgnoreOutOfRange", IgnoreOutOfRange.ToResoniteLinkField());
members.Add("DefaultUnit", DefaultUnit.ToResoniteLinkField());
members.Add("FormatUnit", FormatUnit.ToResoniteLinkField());
members.Add("FormatNumber", FormatNumber.ToResoniteLinkField());
members.Add("CompoundFormatUnits", new ResoniteLink.SyncList()
{
    Elements = CompoundFormatUnits.ConvertList(m => m.ToResoniteLinkField())
});
members.Add("CompoundUseLongNames", CompoundUseLongNames.ToResoniteLinkField());
members.Add("CompoundOverrideNames", CompoundOverrideNames.ToResoniteLinkField());
members.Add("CompoundDiscardLastFraction", CompoundDiscardLastFraction.ToResoniteLinkField());
members.Add("CompoundSeparator", CompoundSeparator.ToResoniteLinkField());
members.Add("CompoundZeroHandling", CompoundZeroHandling.ToResoniteLinkField());
}

}
}
