
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueGraphRecorder
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueGraphRecorder")]
public partial class ValueGraphRecorder : global::FrooxEngine.Component

{
    public global::FrooxEngine.UserRef RecordingUser = new();
public global::FrooxEngine.IField<global::System.Single> SourceValue { get => SourceValue_Element.Data; set => SourceValue_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> SourceValue_Element = new();
public global::System.Single UpdateInterval { get => UpdateInterval_Element.Data; set => UpdateInterval_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> UpdateInterval_Element = new();
public global::System.Int32 Points { get => Points_Element.Data; set => Points_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Points_Element = new();
public global::FrooxEngine.SyncArray<global::System.Single> TargetArray { get => TargetArray_Element.Data; set => TargetArray_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncArray<global::System.Single>>, global::FrooxEngine.SyncArray<global::System.Single>> TargetArray_Element = new();
public global::FrooxEngine.IField<global::System.Int32> TargetArrayOffset { get => TargetArrayOffset_Element.Data; set => TargetArrayOffset_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> TargetArrayOffset_Element = new();
public global::System.Single MinRangeAdjustThreshold { get => MinRangeAdjustThreshold_Element.Data; set => MinRangeAdjustThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinRangeAdjustThreshold_Element = new();
public global::System.Single MinRangeAdjustMultiplier { get => MinRangeAdjustMultiplier_Element.Data; set => MinRangeAdjustMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinRangeAdjustMultiplier_Element = new();
public global::System.Single MaxRangeAdjustThreshold { get => MaxRangeAdjustThreshold_Element.Data; set => MaxRangeAdjustThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxRangeAdjustThreshold_Element = new();
public global::System.Single MaxRangeAdjustMultiplier { get => MaxRangeAdjustMultiplier_Element.Data; set => MaxRangeAdjustMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxRangeAdjustMultiplier_Element = new();
public global::FrooxEngine.IField<global::System.Single> RangeMin { get => RangeMin_Element.Data; set => RangeMin_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> RangeMin_Element = new();
public global::FrooxEngine.IField<global::System.Single> RangeMax { get => RangeMax_Element.Data; set => RangeMax_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> RangeMax_Element = new();
public global::System.Boolean Drive { get => Drive_Element.Data; set => Drive_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Drive_Element = new();
public global::FrooxEngine.SyncArray<global::System.Single> _arrayDrive { get => _arrayDrive_Element.Data; set => _arrayDrive_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.SyncArray<global::System.Single>>, global::FrooxEngine.SyncArray<global::System.Single>> _arrayDrive_Element = new();
public global::FrooxEngine.IField<global::System.Int32> _arrayOffsetDrive { get => _arrayOffsetDrive_Element.Data; set => _arrayOffsetDrive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Int32>, global::FrooxEngine.IField<global::System.Int32>> _arrayOffsetDrive_Element = new();
public global::FrooxEngine.IField<global::System.Single> _rangeMinDrive { get => _rangeMinDrive_Element.Data; set => _rangeMinDrive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _rangeMinDrive_Element = new();
public global::FrooxEngine.IField<global::System.Single> _rangeMaxDrive { get => _rangeMaxDrive_Element.Data; set => _rangeMaxDrive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _rangeMaxDrive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RecordingUser", RecordingUser.ToLinkSyncObject(context));
members.Add("SourceValue", SourceValue_Element.ToLinkReference(context));
members.Add("UpdateInterval", UpdateInterval_Element.ToLinkField(context));
members.Add("Points", Points_Element.ToLinkField(context));
members.Add("TargetArray", TargetArray_Element.ToLinkReference(context));
members.Add("TargetArrayOffset", TargetArrayOffset_Element.ToLinkReference(context));
members.Add("MinRangeAdjustThreshold", MinRangeAdjustThreshold_Element.ToLinkField(context));
members.Add("MinRangeAdjustMultiplier", MinRangeAdjustMultiplier_Element.ToLinkField(context));
members.Add("MaxRangeAdjustThreshold", MaxRangeAdjustThreshold_Element.ToLinkField(context));
members.Add("MaxRangeAdjustMultiplier", MaxRangeAdjustMultiplier_Element.ToLinkField(context));
members.Add("RangeMin", RangeMin_Element.ToLinkReference(context));
members.Add("RangeMax", RangeMax_Element.ToLinkReference(context));
members.Add("Drive", Drive_Element.ToLinkField(context));
members.Add("_arrayDrive", _arrayDrive_Element.ToLinkReference(context));
members.Add("_arrayOffsetDrive", _arrayOffsetDrive_Element.ToLinkReference(context));
members.Add("_rangeMinDrive", _rangeMinDrive_Element.ToLinkReference(context));
members.Add("_rangeMaxDrive", _rangeMaxDrive_Element.ToLinkReference(context));
}

}
}
