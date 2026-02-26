
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DistanceMeter
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DistanceMeter")]
public partial class DistanceMeter : global::FrooxEngine.Component

{
    public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.Slot>, global::FrooxEngine.Slot, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot>> Anchors = new();
public global::FrooxEngine.Slot _legacyAnchor0 { get => _legacyAnchor0_Element.Data; set => _legacyAnchor0_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _legacyAnchor0_Element = new();
public global::FrooxEngine.Slot _legacyAnchor1 { get => _legacyAnchor1_Element.Data; set => _legacyAnchor1_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _legacyAnchor1_Element = new();
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
public global::FrooxEngine.RootSpace MeasurementSpace = new();
public global::FrooxEngine.IField<global::System.String> DistanceText { get => DistanceText_Element.Data; set => DistanceText_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> DistanceText_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Anchors", new ResoniteLink.SyncList()
{
    Elements = Anchors.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("_legacyAnchor0", _legacyAnchor0_Element.Data.ToResoniteReference(context));
members.Add("_legacyAnchor1", _legacyAnchor1_Element.Data.ToResoniteReference(context));
members.Add("FormatUnit", FormatUnit_Element.Data.ToResoniteLinkField());
members.Add("FormatNumber", FormatNumber_Element.Data.ToResoniteLinkField());
members.Add("CompoundFormatUnits", new ResoniteLink.SyncList()
{
    Elements = CompoundFormatUnits.Data.ConvertList(m => m.Data.ToResoniteLinkField())
});
members.Add("CompoundUseLongNames", CompoundUseLongNames_Element.Data.ToResoniteLinkField());
members.Add("CompoundOverrideNames", CompoundOverrideNames_Element.Data.ToResoniteLinkField());
members.Add("CompoundDiscardLastFraction", CompoundDiscardLastFraction_Element.Data.ToResoniteLinkField());
members.Add("CompoundSeparator", CompoundSeparator_Element.Data.ToResoniteLinkField());
members.Add("CompoundZeroHandling", CompoundZeroHandling_Element.Data.ToResoniteLinkField());
members.Add("MeasurementSpace", new ResoniteLink.SyncObject() { Members = MeasurementSpace.CollectMembers(context) });
members.Add("DistanceText", DistanceText_Element.Data.ToResoniteReference(context));
}

}
}
