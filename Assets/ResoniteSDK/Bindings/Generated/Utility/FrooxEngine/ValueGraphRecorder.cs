
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueGraphRecorder
// Generated on: pátek 13. února 2026 5:52:40
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("RecordingUser", new ResoniteLink.SyncObject() { Members = RecordingUser.CollectMembers() });
members.Add("SourceValue", new ResoniteLink.Reference() { });
members.Add("UpdateInterval", UpdateInterval.ToResoniteLinkField());
members.Add("Points", Points.ToResoniteLinkField());
members.Add("TargetArray", new ResoniteLink.Reference() { });
members.Add("TargetArrayOffset", new ResoniteLink.Reference() { });
members.Add("MinRangeAdjustThreshold", MinRangeAdjustThreshold.ToResoniteLinkField());
members.Add("MinRangeAdjustMultiplier", MinRangeAdjustMultiplier.ToResoniteLinkField());
members.Add("MaxRangeAdjustThreshold", MaxRangeAdjustThreshold.ToResoniteLinkField());
members.Add("MaxRangeAdjustMultiplier", MaxRangeAdjustMultiplier.ToResoniteLinkField());
members.Add("RangeMin", new ResoniteLink.Reference() { });
members.Add("RangeMax", new ResoniteLink.Reference() { });
members.Add("Drive", Drive.ToResoniteLinkField());
members.Add("_arrayDrive", new ResoniteLink.Reference() { });
members.Add("_arrayOffsetDrive", new ResoniteLink.Reference() { });
members.Add("_rangeMinDrive", new ResoniteLink.Reference() { });
members.Add("_rangeMaxDrive", new ResoniteLink.Reference() { });
}

}
}
