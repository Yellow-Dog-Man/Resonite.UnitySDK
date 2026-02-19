
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GizmoLink
// Generated on: čtvrtek 19. února 2026 8:00:28
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GizmoLink")]
public partial class GizmoLink : global::FrooxEngine.Component

{
    public global::FrooxEngine.Worker _worker;
public global::FrooxEngine.IComponentGizmo _gizmo;
public System.String _type;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_worker", _worker.ToResoniteReference(context));
members.Add("_gizmo", _gizmo.ToResoniteReference(context));
members.Add("_type", _type.ToResoniteLinkField());
}

}
}
