
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GizmoLink
// Generated on: pátek 13. února 2026 5:52:32
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GizmoLink")]
public partial class GizmoLink : global::FrooxEngine.Component

{
    public global::FrooxEngine.Worker _worker;
public global::FrooxEngine.IComponentGizmo _gizmo;
public System.String _type;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_worker", new ResoniteLink.Reference() { });
members.Add("_gizmo", new ResoniteLink.Reference() { });
members.Add("_type", _type.ToResoniteLinkField());
}

}
}
