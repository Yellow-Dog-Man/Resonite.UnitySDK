
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UnitSystemSwitcher
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UnitSystemSwitcher")]
public partial class UnitSystemSwitcher : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.String> DefaultUnit;
public global::FrooxEngine.IField<global::System.String> FormatUnit;
public global::FrooxEngine.IField<global::System.String> FormatNumber;
public global::FrooxEngine.SyncFieldList<global::System.String> CompoundFormatUnits;
public global::FrooxEngine.IField<global::System.Boolean> CompoundOverrideNames;
public global::FrooxEngine.IField<global::System.Boolean> CompoundUseLongNames;
public global::FrooxEngine.IField<global::System.String> CompoundSeparator;
public global::FrooxEngine.UnitSystemSwitcher.Preset DefaultPreset;
public global::FrooxEngine.UnitSystemSwitcher.Preset ImperialPreset;

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
members.Add("DefaultPreset", new ResoniteLink.SyncObject() { Members = DefaultPreset.CollectMembers(context) });
members.Add("ImperialPreset", new ResoniteLink.SyncObject() { Members = ImperialPreset.CollectMembers(context) });
}

}
}
