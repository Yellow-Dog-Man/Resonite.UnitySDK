
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoxColliderGizmo
// Generated on: čtvrtek 26. února 2026 15:09:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BoxColliderGizmo")]
public partial class BoxColliderGizmo : global::FrooxEngine.Component, global::FrooxEngine.IComponentGizmo

{
    public global::FrooxEngine.BoxCollider _target { get => _target_Element.Data; set => _target_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.BoxCollider>, global::FrooxEngine.BoxCollider> _target_Element = new();
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
