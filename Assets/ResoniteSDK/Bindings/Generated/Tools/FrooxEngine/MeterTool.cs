
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeterTool
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MeterTool")]
public partial class MeterTool : global::FrooxEngine.Tool

{
    public global::FrooxEngine.IField<UnityEngine.ColorX> _indicationColor;
public global::FrooxEngine.MeterTool.Mode MeterMode;
public global::System.Boolean MeasureInObjectSpace;
public global::System.Boolean RaycastIgnoresUsers;
public global::System.Boolean MultiPoint;
public global::FrooxEngine.Slot _lastPoint;
public global::FrooxEngine.DistanceMeter _currentMeter;
public global::FrooxEngine.LineTransform _currentLineTransform;
public global::System.String FormatNumber;
public global::System.String FormatUnit;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_indicationColor", new ResoniteLink.Reference() { });
members.Add("MeterMode", MeterMode.ToResoniteLinkField());
members.Add("MeasureInObjectSpace", MeasureInObjectSpace.ToResoniteLinkField());
members.Add("RaycastIgnoresUsers", RaycastIgnoresUsers.ToResoniteLinkField());
members.Add("MultiPoint", MultiPoint.ToResoniteLinkField());
members.Add("_lastPoint", new ResoniteLink.Reference() { });
members.Add("_currentMeter", new ResoniteLink.Reference() { });
members.Add("_currentLineTransform", new ResoniteLink.Reference() { });
members.Add("FormatNumber", FormatNumber.ToResoniteLinkField());
members.Add("FormatUnit", FormatUnit.ToResoniteLinkField());
}

}
}
