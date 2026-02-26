
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UnitSystemSwitcher
// Generated on: čtvrtek 26. února 2026 15:07:58
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UnitSystemSwitcher")]
public partial class UnitSystemSwitcher : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.String> DefaultUnit { get => DefaultUnit_Element.Data; set => DefaultUnit_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> DefaultUnit_Element = new();
public global::FrooxEngine.IField<global::System.String> FormatUnit { get => FormatUnit_Element.Data; set => FormatUnit_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> FormatUnit_Element = new();
public global::FrooxEngine.IField<global::System.String> FormatNumber { get => FormatNumber_Element.Data; set => FormatNumber_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> FormatNumber_Element = new();
public global::FrooxEngine.SyncFieldList<global::System.String> CompoundFormatUnits { get => CompoundFormatUnits_Element.Data; set => CompoundFormatUnits_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.SyncFieldList<global::System.String>>, global::FrooxEngine.SyncFieldList<global::System.String>> CompoundFormatUnits_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> CompoundOverrideNames { get => CompoundOverrideNames_Element.Data; set => CompoundOverrideNames_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> CompoundOverrideNames_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> CompoundUseLongNames { get => CompoundUseLongNames_Element.Data; set => CompoundUseLongNames_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> CompoundUseLongNames_Element = new();
public global::FrooxEngine.IField<global::System.String> CompoundSeparator { get => CompoundSeparator_Element.Data; set => CompoundSeparator_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> CompoundSeparator_Element = new();
public global::FrooxEngine.UnitSystemSwitcher.Preset DefaultPreset = new();
public global::FrooxEngine.UnitSystemSwitcher.Preset ImperialPreset = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DefaultUnit", DefaultUnit_Element.ToLinkReference(context));
members.Add("FormatUnit", FormatUnit_Element.ToLinkReference(context));
members.Add("FormatNumber", FormatNumber_Element.ToLinkReference(context));
members.Add("CompoundFormatUnits", CompoundFormatUnits_Element.ToLinkReference(context));
members.Add("CompoundOverrideNames", CompoundOverrideNames_Element.ToLinkReference(context));
members.Add("CompoundUseLongNames", CompoundUseLongNames_Element.ToLinkReference(context));
members.Add("CompoundSeparator", CompoundSeparator_Element.ToLinkReference(context));
members.Add("DefaultPreset", DefaultPreset.ToLinkSyncObject(context));
members.Add("ImperialPreset", ImperialPreset.ToLinkSyncObject(context));
}

}
}
