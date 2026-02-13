
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DistanceMeter
// Generated on: pátek 13. února 2026 23:23:07
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DistanceMeter")]
public partial class DistanceMeter : global::FrooxEngine.Component

{
    public System.Collections.Generic.List<global::FrooxEngine.Slot> Anchors;
public global::FrooxEngine.Slot _legacyAnchor0;
public global::FrooxEngine.Slot _legacyAnchor1;
public global::System.String FormatUnit;
public global::System.String FormatNumber;
public System.Collections.Generic.List<global::System.String> CompoundFormatUnits;
public global::System.Boolean CompoundUseLongNames;
public global::System.Boolean CompoundOverrideNames;
public global::System.Boolean CompoundDiscardLastFraction;
public global::System.String CompoundSeparator;
public global::Elements.Quantity.CompoundZeroHandling CompoundZeroHandling;
public global::FrooxEngine.RootSpace MeasurementSpace;
public global::FrooxEngine.IField<global::System.String> DistanceText;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Anchors", new ResoniteLink.SyncList()
{
    Elements = Anchors.ConvertList(m => new ResoniteLink.Reference() { })
});
members.Add("_legacyAnchor0", new ResoniteLink.Reference() { });
members.Add("_legacyAnchor1", new ResoniteLink.Reference() { });
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
members.Add("MeasurementSpace", new ResoniteLink.SyncObject() { Members = MeasurementSpace.CollectMembers() });
members.Add("DistanceText", new ResoniteLink.Reference() { });
}

}
}
