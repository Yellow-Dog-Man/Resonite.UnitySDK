
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicBoneSphereColliderGizmo
// Generated on: pátek 14. srpna 2026 21:57:56
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicBoneSphereColliderGizmo")]
public partial class DynamicBoneSphereColliderGizmo : global::FrooxEngine.Component, global::FrooxEngine.IComponentGizmo, global::FrooxEngine.IGizmo

{
    public global::FrooxEngine.DynamicBoneSphereCollider _target { get => _target_Element.Data; set => _target_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.DynamicBoneSphereCollider>, global::FrooxEngine.DynamicBoneSphereCollider> _target_Element = new();
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
