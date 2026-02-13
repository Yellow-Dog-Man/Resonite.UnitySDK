
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Slider
// Generated on: pátek 13. února 2026 23:23:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Slider")]
public partial class Slider : global::FrooxEngine.Draggable

{
    public global::System.Boolean Rotatable;
public global::System.Boolean Scalable;
public UnityEngine.Vector3 Range;
public UnityEngine.Vector3 Origin;
public UnityEngine.Vector3 MinScale;
public UnityEngine.Vector3 MaxScale;
public global::System.Single VibrationOffset;
public global::FrooxEngine.VibratePreset VibrationPreset;
public global::System.Single SnapIncrement;
public global::System.Single SnapTime;
public global::System.Boolean SnapOnRelease;
public System.Collections.Generic.List<global::FrooxEngine.Slider.SnapPosition> SnapPositions;
public UnityEngine.Vector3 posOffset;
public UnityEngine.Quaternion rotOffset;
public UnityEngine.Vector3 scaleReference;
public global::FrooxEngine.Slot referenceParent;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Rotatable", Rotatable.ToResoniteLinkField());
members.Add("Scalable", Scalable.ToResoniteLinkField());
members.Add("Range", Range.ToResoniteLinkField());
members.Add("Origin", Origin.ToResoniteLinkField());
members.Add("MinScale", MinScale.ToResoniteLinkField());
members.Add("MaxScale", MaxScale.ToResoniteLinkField());
members.Add("VibrationOffset", VibrationOffset.ToResoniteLinkField());
members.Add("VibrationPreset", VibrationPreset.ToResoniteLinkField());
members.Add("SnapIncrement", SnapIncrement.ToResoniteLinkField());
members.Add("SnapTime", SnapTime.ToResoniteLinkField());
members.Add("SnapOnRelease", SnapOnRelease.ToResoniteLinkField());
members.Add("SnapPositions", new ResoniteLink.SyncList()
{
    Elements = SnapPositions.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
members.Add("posOffset", posOffset.ToResoniteLinkField());
members.Add("rotOffset", rotOffset.ToResoniteLinkField());
members.Add("scaleReference", scaleReference.ToResoniteLinkField());
members.Add("referenceParent", new ResoniteLink.Reference() { });
}

}
}
