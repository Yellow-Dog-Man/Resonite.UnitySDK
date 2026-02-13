
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BezierCurve
// Generated on: pátek 13. února 2026 23:23:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BezierCurve")]
public partial class BezierCurve : global::FrooxEngine.Component

{
    public System.Collections.Generic.List<global::FrooxEngine.CurvePoint> Points;
public global::FrooxEngine.Slot CoordinateSpace;
public global::FrooxEngine.SyncCurve<UnityEngine.Vector3> AssignCurveData;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Points", new ResoniteLink.SyncList()
{
    Elements = Points.ConvertList(m => new ResoniteLink.Reference() { })
});
members.Add("CoordinateSpace", new ResoniteLink.Reference() { });
members.Add("AssignCurveData", new ResoniteLink.Reference() { });
}

}
}
