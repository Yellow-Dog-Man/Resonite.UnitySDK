
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoxMeshGizmo
// Generated on: pátek 14. srpna 2026 21:57:54
// Resonite version: 2026.8.12.1196
// Resonite Link Version: 0.13.1.0
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
public partial class BoxMeshGizmo : global::FrooxEngine.Component, global::FrooxEngine.IComponentGizmo, global::FrooxEngine.IGizmo

{
    public global::FrooxEngine.BoxMesh _target { get => _target_Element.Data; set => _target_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.BoxMesh>, global::FrooxEngine.BoxMesh> _target_Element = new();
public global::FrooxEngine.BoxGizmo _cubeGizmo { get => _cubeGizmo_Element.Data; set => _cubeGizmo_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.BoxGizmo>, global::FrooxEngine.BoxGizmo> _cubeGizmo_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_target", _target_Element.ToLinkReference(context));
members.Add("_cubeGizmo", _cubeGizmo_Element.ToLinkReference(context));
}

}
}
