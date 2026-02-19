
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueGraphRecorder
// Generated on: čtvrtek 19. února 2026 8:00:33
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueGraphRecorder")]
public partial class ValueGraphRecorder : global::FrooxEngine.Component

{
    public global::FrooxEngine.UserRef RecordingUser;
public global::FrooxEngine.IField<global::System.Single> SourceValue;
public global::System.Single UpdateInterval;
public global::System.Int32 Points;
public global::FrooxEngine.SyncArray<global::System.Single> TargetArray;
public global::FrooxEngine.IField<global::System.Int32> TargetArrayOffset;
public global::System.Single MinRangeAdjustThreshold;
public global::System.Single MinRangeAdjustMultiplier;
public global::System.Single MaxRangeAdjustThreshold;
public global::System.Single MaxRangeAdjustMultiplier;
public global::FrooxEngine.IField<global::System.Single> RangeMin;
public global::FrooxEngine.IField<global::System.Single> RangeMax;
public global::System.Boolean Drive;
public global::FrooxEngine.SyncArray<global::System.Single> _arrayDrive;
public global::FrooxEngine.IField<global::System.Int32> _arrayOffsetDrive;
public global::FrooxEngine.IField<global::System.Single> _rangeMinDrive;
public global::FrooxEngine.IField<global::System.Single> _rangeMaxDrive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RecordingUser", new ResoniteLink.SyncObject() { Members = RecordingUser.CollectMembers(context) });
members.Add("SourceValue", SourceValue.ToResoniteReference(context));
members.Add("UpdateInterval", UpdateInterval.ToResoniteLinkField());
members.Add("Points", Points.ToResoniteLinkField());
members.Add("TargetArray", TargetArray.ToResoniteReference(context));
members.Add("TargetArrayOffset", TargetArrayOffset.ToResoniteReference(context));
members.Add("MinRangeAdjustThreshold", MinRangeAdjustThreshold.ToResoniteLinkField());
members.Add("MinRangeAdjustMultiplier", MinRangeAdjustMultiplier.ToResoniteLinkField());
members.Add("MaxRangeAdjustThreshold", MaxRangeAdjustThreshold.ToResoniteLinkField());
members.Add("MaxRangeAdjustMultiplier", MaxRangeAdjustMultiplier.ToResoniteLinkField());
members.Add("RangeMin", RangeMin.ToResoniteReference(context));
members.Add("RangeMax", RangeMax.ToResoniteReference(context));
members.Add("Drive", Drive.ToResoniteLinkField());
members.Add("_arrayDrive", _arrayDrive.ToResoniteReference(context));
members.Add("_arrayOffsetDrive", _arrayOffsetDrive.ToResoniteReference(context));
members.Add("_rangeMinDrive", _rangeMinDrive.ToResoniteReference(context));
members.Add("_rangeMaxDrive", _rangeMaxDrive.ToResoniteReference(context));
}

}
}
