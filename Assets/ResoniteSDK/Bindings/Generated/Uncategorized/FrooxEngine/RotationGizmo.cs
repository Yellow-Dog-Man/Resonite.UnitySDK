
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RotationGizmo
// Generated on: pátek 13. února 2026 5:52:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RotationGizmo")]
public partial class RotationGizmo : global::FrooxEngine.Component

{
    public global::FrooxEngine.AxisRotationGizmo _xGizmo;
public global::FrooxEngine.AxisRotationGizmo _yGizmo;
public global::FrooxEngine.AxisRotationGizmo _zGizmo;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_xGizmo", new ResoniteLink.Reference() { });
members.Add("_yGizmo", new ResoniteLink.Reference() { });
members.Add("_zGizmo", new ResoniteLink.Reference() { });
}

}
}
