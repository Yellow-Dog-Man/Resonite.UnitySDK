
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.IcoSphereMeshGizmo
// Generated on: čtvrtek 26. února 2026 15:09:12
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.IcoSphereMeshGizmo")]
public partial class IcoSphereMeshGizmo : global::FrooxEngine.Component, global::FrooxEngine.IComponentGizmo

{
    public global::FrooxEngine.IcoSphereMesh _target { get => _target_Element.Data; set => _target_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.IcoSphereMesh>, global::FrooxEngine.IcoSphereMesh> _target_Element = new();
public global::FrooxEngine.SphereGizmo _sphereGizmo { get => _sphereGizmo_Element.Data; set => _sphereGizmo_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.SphereGizmo>, global::FrooxEngine.SphereGizmo> _sphereGizmo_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_target", _target_Element.ToLinkReference(context));
members.Add("_sphereGizmo", _sphereGizmo_Element.ToLinkReference(context));
}

}
}
