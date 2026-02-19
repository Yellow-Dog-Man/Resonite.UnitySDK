
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedQuantityFieldInterface<,>
// Generated on: čtvrtek 19. února 2026 8:00:17
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FeedQuantityFieldInterface<,>")]
public partial class FeedQuantityFieldInterface<Q,T> : global::FrooxEngine.FeedClampedValueFieldInterface<T>
	
	where Q : struct, global::Elements.Quantity.IQuantity<Q>

{
    public global::FrooxEngine.IField<global::System.String> DefaultUnit;
public global::FrooxEngine.IField<global::System.String> FormatUnit;
public global::FrooxEngine.IField<global::System.String> FormatNumber;
public global::FrooxEngine.SyncFieldList<global::System.String> CompoundFormatUnits;
public global::FrooxEngine.IField<global::System.Boolean> CompoundOverrideNames;
public global::FrooxEngine.IField<global::System.Boolean> CompoundUseLongNames;
public global::FrooxEngine.IField<global::System.String> CompoundSeparator;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DefaultUnit", DefaultUnit.ToResoniteReference(context));
members.Add("FormatUnit", FormatUnit.ToResoniteReference(context));
members.Add("FormatNumber", FormatNumber.ToResoniteReference(context));
members.Add("CompoundFormatUnits", CompoundFormatUnits.ToResoniteReference(context));
members.Add("CompoundOverrideNames", CompoundOverrideNames.ToResoniteReference(context));
members.Add("CompoundUseLongNames", CompoundUseLongNames.ToResoniteReference(context));
members.Add("CompoundSeparator", CompoundSeparator.ToResoniteReference(context));
}

}
}
