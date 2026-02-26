
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoxMeshGizmo
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BoxMeshGizmo")]
public partial class BoxMeshGizmo : global::FrooxEngine.Component, global::FrooxEngine.IComponentGizmo

{
    public global::FrooxEngine.BoxMesh _target { get => _target_Element.Data; set => _target_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.BoxMesh>, global::FrooxEngine.BoxMesh> _target_Element = new();
public global::FrooxEngine.BoxGizmo _cubeGizmo { get => _cubeGizmo_Element.Data; set => _cubeGizmo_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.BoxGizmo>, global::FrooxEngine.BoxGizmo> _cubeGizmo_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_target", _target_Element.ToLinkReference(context));
members.Add("_cubeGizmo", _cubeGizmo_Element.ToLinkReference(context));
}

}
}
