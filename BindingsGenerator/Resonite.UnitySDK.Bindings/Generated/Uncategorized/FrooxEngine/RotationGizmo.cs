
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RotationGizmo
// Generated on: středa 25. února 2026 16:14:42
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RotationGizmo")]
public partial class RotationGizmo : global::FrooxEngine.Component

{
    public global::FrooxEngine.AxisRotationGizmo _xGizmo;
public global::FrooxEngine.AxisRotationGizmo _yGizmo;
public global::FrooxEngine.AxisRotationGizmo _zGizmo;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_xGizmo", _xGizmo.ToResoniteReference(context));
members.Add("_yGizmo", _yGizmo.ToResoniteReference(context));
members.Add("_zGizmo", _zGizmo.ToResoniteReference(context));
}

}
}
