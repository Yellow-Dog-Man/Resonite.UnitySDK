
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BezierCurve
// Generated on: pátek 6. března 2026 14:19:07
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public global::SyncFieldList<global::FrooxEngine.SyncRelayList<global::FrooxEngine.CurvePoint>, global::FrooxEngine.CurvePoint, Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.CurvePoint>, global::FrooxEngine.CurvePoint>> Points = new();
public global::FrooxEngine.Slot CoordinateSpace { get => CoordinateSpace_Element.Data; set => CoordinateSpace_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> CoordinateSpace_Element = new();
public global::FrooxEngine.SyncCurve<UnityEngine.Vector3> AssignCurveData { get => AssignCurveData_Element.Data; set => AssignCurveData_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.SyncCurve<UnityEngine.Vector3>>, global::FrooxEngine.SyncCurve<UnityEngine.Vector3>> AssignCurveData_Element = new();

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
