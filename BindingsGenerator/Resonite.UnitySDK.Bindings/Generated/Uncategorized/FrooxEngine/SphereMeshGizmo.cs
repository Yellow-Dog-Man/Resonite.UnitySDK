
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SphereMeshGizmo
// Generated on: čtvrtek 26. února 2026 12:28:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SphereMeshGizmo")]
public partial class SphereMeshGizmo : global::FrooxEngine.Component, global::FrooxEngine.IComponentGizmo

{
    public global::FrooxEngine.SphereMesh _target { get => _target_Element.Data; set => _target_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.SphereMesh>, global::FrooxEngine.SphereMesh> _target_Element = new();
public global::FrooxEngine.SphereGizmo _sphereGizmo { get => _sphereGizmo_Element.Data; set => _sphereGizmo_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SphereGizmo>, global::FrooxEngine.SphereGizmo> _sphereGizmo_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_target", _target_Element.ToLinkReference(context));
members.Add("_sphereGizmo", _sphereGizmo_Element.ToLinkReference(context));
}

}
}
