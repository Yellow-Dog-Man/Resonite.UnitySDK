
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BezierCurve
// Generated on: čtvrtek 26. února 2026 12:28:09
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public global::SyncFieldList<global::FrooxEngine.SyncRelayList<global::FrooxEngine.CurvePoint>, global::FrooxEngine.CurvePoint, Field<global::FrooxEngine.RelayRef<global::FrooxEngine.CurvePoint>, global::FrooxEngine.CurvePoint>> Points = new();
public global::FrooxEngine.Slot CoordinateSpace { get => CoordinateSpace_Element.Data; set => CoordinateSpace_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> CoordinateSpace_Element = new();
public global::FrooxEngine.SyncCurve<UnityEngine.Vector3> AssignCurveData { get => AssignCurveData_Element.Data; set => AssignCurveData_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.SyncCurve<UnityEngine.Vector3>>, global::FrooxEngine.SyncCurve<UnityEngine.Vector3>> AssignCurveData_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Points", Points.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("CoordinateSpace", CoordinateSpace_Element.ToLinkReference(context));
members.Add("AssignCurveData", AssignCurveData_Element.ToLinkReference(context));
}

}
}
