
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GizmoLink
// Generated on: čtvrtek 26. února 2026 12:28:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GizmoLink")]
public partial class GizmoLink : global::FrooxEngine.Component

{
    public global::FrooxEngine.Worker _worker { get => _worker_Element.Data; set => _worker_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Worker>, global::FrooxEngine.Worker> _worker_Element = new();
public global::FrooxEngine.IComponentGizmo _gizmo { get => _gizmo_Element.Data; set => _gizmo_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IComponentGizmo>, global::FrooxEngine.IComponentGizmo> _gizmo_Element = new();
public System.String _type { get => _type_Element.Data; set => _type_Element.Data = value; }
public Field<global::FrooxEngine.SyncType, System.String> _type_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_worker", _worker_Element.ToLinkReference(context));
members.Add("_gizmo", _gizmo_Element.ToLinkReference(context));
members.Add("_type", _type_Element.ToLinkField(context));
}

}
}
