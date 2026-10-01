
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshRendererGizmo
// Generated on: pátek 14. srpna 2026 21:58:02
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MeshRendererGizmo")]
public partial class MeshRendererGizmo : global::FrooxEngine.Component, global::FrooxEngine.IComponentGizmo, global::FrooxEngine.IGizmo, global::FrooxEngine.IDevModeReceiver

{
    public global::FrooxEngine.MeshRenderer _target { get => _target_Element.Data; set => _target_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer> _target_Element = new();
public global::FrooxEngine.MeshCollider _meshCollider { get => _meshCollider_Element.Data; set => _meshCollider_Element.Data = value; }
public Reference<global::FrooxEngine.CleanupRef<global::FrooxEngine.MeshCollider>, global::FrooxEngine.MeshCollider> _meshCollider_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_target", _target_Element.ToLinkReference(context));
members.Add("_meshCollider", _meshCollider_Element.ToLinkReference(context));
}

}
}
