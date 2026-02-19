
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BezierCurve
// Generated on: čtvrtek 19. února 2026 8:00:26
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BezierCurve")]
public partial class BezierCurve : global::FrooxEngine.Component

{
    public System.Collections.Generic.List<global::FrooxEngine.CurvePoint> Points;
public global::FrooxEngine.Slot CoordinateSpace;
public global::FrooxEngine.SyncCurve<UnityEngine.Vector3> AssignCurveData;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Points", new ResoniteLink.SyncList()
{
    Elements = Points.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("CoordinateSpace", CoordinateSpace.ToResoniteReference(context));
members.Add("AssignCurveData", AssignCurveData.ToResoniteReference(context));
}

}
}
